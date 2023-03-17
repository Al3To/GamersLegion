using IGDB;
using IGDB.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Markup;
using static System.Net.WebRequestMethods;

namespace Gamers_Legion.Forms
{
    public partial class FormFindTheGame : Form
    {
        IGDBClient igdb = FormIndex.igdb;
        HttpClient client = FormIndex.client;
        int[] ids = { 1009, 6036, 159119, 114283, 119133, 1942, 19560, 25076, 14593, 72, 7331, 427, 75235, 231 };
        List<string> game = new List<string>();
        int errors = 0, score = 0;
        string lastImageUrl;
        public FormFindTheGame()
        {
            InitializeComponent();
            ChangeImage();
        }
        private void startLoading()
        {
            labelLoading.Visible = true;
            Guess.Enabled = false;
            iconEnter.Enabled = false;
        }

        private void stopLoading()
        {
            labelLoading.Visible = false;
            Guess.Enabled = true;
            iconEnter.Enabled = true;
        }
        async private void ChangeImage()
        {
            try
            {
                startLoading();
                game.Clear();
                labelError.Visible = false;
                Random rnd = new Random();
                string rndId = ids[rnd.Next(0, ids.Length - 1)].ToString();
                var covers = await igdb.QueryAsync<Cover>(IGDBClient.Endpoints.Covers, query: "fields url; where game = " + rndId + ";");
                var games = await igdb.QueryAsync<Game>(IGDBClient.Endpoints.Games, query: "fields name, id; where id = " + rndId + ";");
                var alternativeNames = await igdb.QueryAsync<AlternativeName>(IGDBClient.Endpoints.AlternativeNames, query: "fields *; where game = " + rndId + "; limit 50;");

                game.Add(games.First().Name);
                for (int n = 0; n < alternativeNames.Length; ++n)
                    game.Add(alternativeNames[n].Name);
                var cover = covers.First();
                string[] splitUrl = cover.Url.Split('/');
                splitUrl[6] = "t_1080p";
                string coverUrl = "https://" + splitUrl[2] + "/" + splitUrl[3] + "/" + splitUrl[4] + "/" + splitUrl[5] + "/" + splitUrl[6] + "/" + splitUrl[7];
                lastImageUrl = coverUrl;
                var builder = new UriBuilder("https://studio.pixelixe.com/api/blur/v1");
                builder.Port = -1;
                var query = HttpUtility.ParseQueryString(builder.Query);
                query["apiKey"] = "f161AdzM67NN7XIrvAWn7CjkEbX2";
                query["value"] = "20";
                query["imageUrl"] = coverUrl;
                builder.Query = query.ToString();
                string url = builder.ToString();

                byte[] response = await client.GetByteArrayAsync(url);
                MemoryStream ms = new MemoryStream(response);
                Image returnImage = Image.FromStream(ms);
                GameCover.Image = returnImage;
                stopLoading();
            }
            catch (Exception ex)
            {
                labelError.Visible = true;
            }
        }

        private void Guess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iconEnter.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        async private void DownScaleImage()
        {
            startLoading();
            var builder = new UriBuilder("https://studio.pixelixe.com/api/blur/v1");
            builder.Port = -1;
            var query = HttpUtility.ParseQueryString(builder.Query);
            query["apiKey"] = "f161AdzM67NN7XIrvAWn7CjkEbX2";
            switch (errors)
            {
                case 1:
                    query["value"] = "15";
                    break;
                case 2:
                    query["value"] = "5";
                    break;
            }

            query["imageUrl"] = lastImageUrl;
            builder.Query = query.ToString();
            string url = builder.ToString();
            byte[] response = await client.GetByteArrayAsync(url);
            MemoryStream ms = new MemoryStream(response);
            Image returnImage = Image.FromStream(ms);
            GameCover.Image = returnImage;
            stopLoading();
        }
        private void iconEnter_Click(object sender, EventArgs e)
        {
            bool found = false;
            for(int n = 0; n < game.Count; ++n)
                if(Guess.Text.ToLower() == game[n].ToLower())
                    found = true;

            if (found)
            {
                score++;
                labelScore.Text = score.ToString();
                ChangeImage();
            }
            else
            {
                errors++;
                if (errors == 3)
                {
                    Heart1.IconChar = FontAwesome.Sharp.IconChar.Heart;
                    Heart2.IconChar = FontAwesome.Sharp.IconChar.Heart;
                    score = 0;
                    errors = 0;
                    labelScore.Text = score.ToString();
                    ChangeImage();
                }
                else
                {
                    switch (errors)
                    {
                        case 1:
                            Heart1.IconChar = FontAwesome.Sharp.IconChar.HeartBroken;
                            break;
                        case 2:
                            Heart2.IconChar = FontAwesome.Sharp.IconChar.HeartBroken;
                            break;
                    }
                    DownScaleImage();
                }
            }
        }
    }
}
