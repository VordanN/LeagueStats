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
        Model.ModelProfile model;
        Match_V5 match;
       
        public Form2()
        {
            controler = new Controller.ControlerProfile();
            InitializeComponent();
            model = (ModelProfile)controler.GetContext();

            SName.Text = model.SummonerName;
            ISLogo.ImageLocation = model.Icon;
            IRankImage.Image = Image.FromFile(model.Emblem);
            Wins.Text = Convert.ToString(model.Wins);
            LTier.Text = model.Tier;
            LRank.Text = model.Rank;
            
            Losses.Text = Convert.ToString(model.Losses);
            SLvL.Text = Convert.ToString(model.Level);

            match = new Match_V5(Constants.Summoner.Region);
            //RU_329377877

            List<string> m = match.GetMatchIDs(Constants.Summoner.Puuid);
            for (int i = 0; i < m.Count; i++)
            {
                flowLayoutPanel1.Controls.Add(new MatchView(match.GetModelSat(m[i])));
            }
        }

          
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IRankImage_Click(object sender, EventArgs e)
        {

        }


    }
}