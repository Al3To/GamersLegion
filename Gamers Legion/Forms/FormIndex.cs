using FontAwesome.Sharp;
using Gamers_Legion.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using IGDB;
using IGDB.Models;


namespace Gamers_Legion
{
    public partial class FormIndex : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public static IGDBClient igdb = new IGDBClient("34cwc1w2reh7z58njhknyk36yjgs5y", "7yku4ksa4ng7wviwnqdzm8fz0drxsy");
        public static readonly HttpClient client = new HttpClient();


        public FormIndex()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            this.CenterToScreen();
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            ShowMostRated();
        }
        async public void ShowMostRated()
        {
            var games = await igdb.QueryAsync<Game>(IGDBClient.Endpoints.Games, query: "fields name, id, total_rating, total_rating_count; sort total_rating desc; where total_rating != null & total_rating_count > 2000; limit 3;");
            var covers = await igdb.QueryAsync<Cover>(IGDBClient.Endpoints.Covers, query: "fields url, game; where (game = " + games[0].Id + ") |(game = " + games[1].Id + ") |(game = " + games[2].Id + ") ;");
            Console.WriteLine(covers[0].Url + " " + covers[1].Game + " " + covers[2].Game);
            for (int n = 0; n < 3; ++n) {
                string[] splitUrl = covers[n].Url.Split('/');
                splitUrl[6] = "t_1080p";
                string coverUrl = "https://" + splitUrl[2] + "/" + splitUrl[3] + "/" + splitUrl[4] + "/" + splitUrl[5] + "/" + splitUrl[6] + "/" + splitUrl[7];
                switch (n)
                {
                    case 0:
                        coverGame3.ImageLocation = coverUrl;
                        break;
                    case 1:
                        coverGame2.ImageLocation = coverUrl;
                        break;
                    case 2:
                        coverGame1.ImageLocation = coverUrl;
                        break;
                }
            }
            labelGame1.Text = games[0].Name;
            labelGame2.Text = games[1].Name;
            labelGame3.Text = games[2].Name;
            
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left Border Button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //Open only one form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            if (currentBtn != null)
                labelTitleChildForm.Text = currentBtn.Text;

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormSearch());
        }

        private void buttonFindTheGame_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormFindTheGame());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
                currentChildForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            labelTitleChildForm.Text = "Home";
        }

        
    }
}
