using FileSystem;
using LeageStats.API;
using LeageStats.Model;
using LeageStats.Model.Match;
using LeageStats.Utilits;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace LeageStats
{
    public partial class Form2 : Form
    {
        Controller.ControlerProfile controler;
        ModelProfile model;
        Match_V5 match;
       
        public Form2()
        {
            InitializeComponent();
            controler = new Controller.ControlerProfile();
            model = (ModelProfile)controler.GetContext();
            SName.Text = model.SummonerName;
            ISLogo.ImageLocation = model.Icon;
            IRankImage.Image = Image.FromFile(model.Emblem);
            Wins.Text = Convert.ToString(model.Wins);
            
            
            LTier.Text = model.Tier.ToUpper()[0] + model.Tier.Substring(1).ToLower() + " " + model.Rank;
            LTier.Left =panel3.Width/2 - LTier.Size.Width / 2;
            
            LP.Text = model.LegaePoints + " LP";
            LP.Left = panel3.Width/2 - LP.Size.Width/ 2;


            Losses.Text = Convert.ToString(model.Losses);
            SLvL.Text = Convert.ToString(model.Level);
            ISLogo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ISLogo.Width, ISLogo.Height, 20, 20));


            if (!Directory.Exists("Matches"))
                Directory.CreateDirectory("Matches");
            if (!Directory.Exists(@"Matches\" + Constants.Summoner.Id))
                Directory.CreateDirectory(@"Matches\" + Constants.Summoner.Id);


            match = new Match_V5(Constants.Summoner.Region);

            List<string> m = match.GetMatchIDs(Constants.Summoner.Puuid);
            foreach (var MatchId in m)
            {
                AddMathchToPanel(MatchId);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Сделать умную ситстему
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        void AddMathchToPanel(string MatchId)
        {
            Root modelStat = match.GetModelSat(MatchId);
            MatchView matchView = new MatchView(modelStat);
            flowLayoutPanel1.Controls.Add(matchView);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                               Color.FromArgb(117, 72, 95),
                                                               Color.FromArgb(191, 113, 109),
                                                               180F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }



        private bool dragging;
        private Point pointClicked;
        private void MouseDown(object sender, MouseEventArgs e)
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
        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point pointMoveTo;
                pointMoveTo = this.PointToScreen(new Point(e.X, e.Y));

                pointMoveTo.Offset(-pointClicked.X, -pointClicked.Y);

                this.Location = pointMoveTo;
            }
        }
        private void MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}