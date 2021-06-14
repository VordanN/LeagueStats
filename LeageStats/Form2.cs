using LeageStats.API;
using LeageStats.Model;
using LeageStats.Utilits;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;


namespace LeageStats
{
    public partial class Form2 : Form
    {
        private readonly Controller.ControlerProfile controler;
        private readonly ModelProfile model;
        private Match_V5 match;
        private readonly Panel paneladd = new Panel();
        public int start = 0;

        public Form2()
        {
            InitializeComponent();
            controler = new Controller.ControlerProfile();
            model = (ModelProfile)controler.GetContext();
            SName.Text = model.SummonerName;
            ISLogo.ImageLocation = model.Icon;
            IRankImage.Image = Image.FromFile(model.Emblem);


            LTier.Text = model.Tier.ToUpper()[0] + model.Tier.Substring(1).ToLower() + " " + model.Rank;
            LTier.Left = panel3.Width / 2 - LTier.Size.Width / 2;

            LP.Text = model.LegaePoints + " LP";
            LP.Left = panel3.Width / 2 - LP.Size.Width / 2;


            Losses.Text = Convert.ToString(model.Losses);
            SLvL.Text = Convert.ToString(model.Level);
            ISLogo.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, ISLogo.Width, ISLogo.Height, 20, 20));


            if (!Directory.Exists("Matches"))
            {
                Directory.CreateDirectory("Matches");
            }

            if (!Directory.Exists(@"Matches\" + Constants.Summoner.Id))
            {
                Directory.CreateDirectory(@"Matches\" + Constants.Summoner.Id);
            }

            match = new Match_V5(Constants.Summoner.Region);
            List<string> m = match.GetMatchIDs(Constants.Summoner.Puuid, start);
            foreach (string MatchId in m)
            {
                AddMathchToPanel(MatchId);
            }

            Label add = new Label
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0),
                Location = new System.Drawing.Point(259, 31),
                Name = "add",
                Size = new System.Drawing.Size(53, 30),
                TabIndex = 0
            };
            add.Click += new System.EventHandler(Add_Click);
            add.Text = "Add";


            paneladd.BackColor = System.Drawing.Color.SeaShell;
            paneladd.Controls.Add(add);
            paneladd.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            paneladd.Name = "Add";
            paneladd.Size = new System.Drawing.Size(623, 88);
            paneladd.Click += new System.EventHandler(Add_Click);
            add.Left = paneladd.Width / 2 - add.Size.Width / 2;
            paneladd.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, paneladd.Width, paneladd.Height, 10, 10));

            flowLayoutPanel1.Controls.Add(paneladd);
        }


        private void Add_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.RemoveAt(flowLayoutPanel1.Controls.Count - 1);
            start += 20;
            match = new Match_V5(Constants.Summoner.Region);
            List<string> m = match.GetMatchIDs(Constants.Summoner.Puuid, start);
            foreach (string MatchId in m)
            {
                MatchDto modelStat = match.GetModelSat(MatchId);
                MatchView matchView = new MatchView(modelStat);
                flowLayoutPanel1.Controls.Add(matchView);

            }
            flowLayoutPanel1.Controls.Add(paneladd);
        }




        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddMathchToPanel(string MatchId)
        {
            MatchDto modelStat = match.GetModelSat(MatchId);
            MatchView matchView = new MatchView(modelStat);
            flowLayoutPanel1.Controls.Add(matchView);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle,
                                                               Color.FromArgb(117, 72, 95),
                                                               Color.FromArgb(191, 113, 109),
                                                               180F))
            {
                e.Graphics.FillRectangle(brush, ClientRectangle);
            }
        }



        private bool dragging;
        private Point pointClicked;
        private new void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                pointClicked = new Point(e.X, e.Y);
            }
            else
            {
                dragging = false;
            }
        }
        private new void MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point pointMoveTo;
                pointMoveTo = PointToScreen(new Point(e.X, e.Y));

                pointMoveTo.Offset(-pointClicked.X, -pointClicked.Y);

                Location = pointMoveTo;
            }
        }
        private new void MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private new void Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Scrool scrool = new Scrool();
            scrool.ShowDialog();
            List<string> m = match.GetMatchIDs(Constants.Summoner.Puuid, scrool.start, scrool.end);
            flowLayoutPanel1.Controls.Clear();
            foreach (string MatchId in m)
            {
                MatchDto modelStat = match.GetModelSat(MatchId);
                MatchView matchView = new MatchView(modelStat);
                flowLayoutPanel1.Controls.Add(matchView);
            }

        }
    }
}