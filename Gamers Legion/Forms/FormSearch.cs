using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using IGDB;
using IGDB.Models;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;

namespace Gamers_Legion.Forms
{
    public partial class FormSearch : Form
    {
        IGDBClient igdb = FormIndex.igdb;
        HttpClient client = FormIndex.client;
        string en_Summary, it_Summary;
        public FormSearch()
        {
            InitializeComponent();
            if (!client.DefaultRequestHeaders.Contains("Authorization"))
            {
                client.DefaultRequestHeaders.Add("Authorization", "Token 5b81c25dfd8850009d29cbd4b96d9def51b7ccd9");
                client.DefaultRequestHeaders.Add("User-Agent", "PostmanRuntime/7.31.3");
                client.DefaultRequestHeaders.Add("Connection", "keep-alive");
            }
        }

        private void startLoading()
        {
            labelLoading.Visible = true;
            SearchBar.Enabled = false;
            btnSearch.Enabled = false;
        }
        private void stopLoading()
        {
            labelLoading.Visible = false;
            SearchBar.Enabled = true;
            btnSearch.Enabled = true;
        }
        private void SearchBar_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void SearchBar_Enter(object sender, EventArgs e)
        {
            if (SearchBar.Text == "Search")
            {
                SearchBar.Text = "";
                SearchBar.ForeColor = Color.Black;
            }
        }

        private void SearchBar_Leave(object sender, EventArgs e)
        {
            if (SearchBar.Text == "")
            {
                SearchBar.Text = "Search";
                SearchBar.ForeColor = Color.Silver;
            }
        }

        async private void btnSearch_Click(object sender, EventArgs e)
        {
            startLoading();
            string search = '"' + SearchBar.Text + '"';
            var games = await igdb.QueryAsync<Game>(IGDBClient.Endpoints.Games, query: "fields summary ,name, id, total_rating; where name ~ " + search + ";");
            labelError.Visible = false;
            try
            {
                var game = games.First();
                var covers = await igdb.QueryAsync<Cover>(IGDBClient.Endpoints.Covers, query: "fields url; where game = " + game.Id + ";");
                var cover = covers.First();
                string[] splitUrl = cover.Url.Split('/');
                splitUrl[6] = "t_1080p";
                string coverUrl = "https://" + splitUrl[2] + "/" + splitUrl[3] + "/" + splitUrl[4] + "/" + splitUrl[5] + "/" + splitUrl[6] + "/" + splitUrl[7];
                Data data = new Data();
                data.text = game.Summary;
                data.source = "eng_Latn";
                data.target = "ita_Latn";
                var value = JsonConvert.SerializeObject(data);
                var content = new StringContent(value, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://api.nlpcloud.io/v1/nllb-200-3-3b/translation", content);
                var responseString = await response.Content.ReadAsStringAsync();
                Translation t = JsonConvert.DeserializeObject<Translation>(responseString);
                it_Summary = t.translation_text;
                en_Summary = game.Summary;
                GameCover.ImageLocation = coverUrl;
                labelTitle.Text = game.Name;
                labelSummary.Text = it_Summary;
                labelRating.Text = "Rating: " + Math.Round(Convert.ToDouble(game.TotalRating), 2).ToString() + "/100";
                
                labelTitle.Visible = true;
                labelSummary.Visible = true;
                labelRating.Visible = true;
                stopLoading();
            }
            catch(Exception ex)
            {
                labelError.Visible = true;
                stopLoading();
            }

        }

        private void iconSwitchLanguage_Click(object sender, EventArgs e)
        {
            if(labelSummary.Text == it_Summary)
                labelSummary.Text = en_Summary;
            else if(labelSummary.Text == en_Summary)
                labelSummary.Text = it_Summary;
        }
    }
}
public class Translation
{
    public string translation_text { get; set; }
}

public class Data
{
    public string text { get; set; }
    public string source { get; set; }
    public string target { get; set; }
}
