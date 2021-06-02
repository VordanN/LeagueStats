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
using System.IO;
using System.Linq;
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
            Size = new Size(441, 604);
            model = (ModelProfile)controler.GetContext();

            SName.Text = model.SummonerName;
            ISLogo.ImageLocation = model.Icon;
            IRankImage.Image = Image.FromFile(model.Emblem);
            Wins.Text = Convert.ToString(model.Wins);
            LTier.Text = model.Tier;
            LRank.Text = model.Rank;
            
            Losses.Text = Convert.ToString(model.Losses);
            SLvL.Text = Convert.ToString(model.Level);



            if (!Directory.Exists("Matches"))
                Directory.CreateDirectory("Matches");
            if (!Directory.Exists(@"Matches\" + Constants.Summoner.Id))
                Directory.CreateDirectory(@"Matches\" + Constants.Summoner.Id);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Сделать умную ситстему
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MatcHisroy_Click(object sender, EventArgs e)
        {
            if (Size.Width == 1464)
            {
                Size = new Size(441, 604);
                return;
            }
            Size = new Size(1464, 604);
            match = new Match_V5(Constants.Summoner.Region);

            List<string> m = match.GetMatchIDs(Constants.Summoner.Puuid);
            foreach (var MatchId in m)
            {
                AddMathchToPanel(MatchId);
            }
        }

        async void AddMathchToPanel(string MatchId)
        {
            ModelStat modelStat = await match.GetModelSat(MatchId);
            MatchView matchView = new MatchView(modelStat);
            flowLayoutPanel1.Controls.Add(matchView);
        }
    }
}