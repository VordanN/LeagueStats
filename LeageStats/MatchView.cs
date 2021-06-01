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
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeageStats
{
    public partial class MatchView : UserControl
    {
        private Image GetImage(string filleName,string url= "")
        {
            if (File.Exists(filleName))
            {
                return Image.FromFile(filleName);
            }
            return DownloadImage(url);
        }
        public MatchView(ModelStat participant)
        {
            InitializeComponent();

            CharecterIcon.Image = GetImage(@"SummonerIcons\" + participant.championName + ".png", "https://ddragon.leagueoflegends.com/cdn/11.8.1/img/champion/"+participant.championName+".png");

            CharecterName.Text = participant.championName;
            Level.Text = participant.champLevel.ToString();
            kda.Text = participant.kills + "/" + participant.deaths + "/" + participant.assists;
            if (participant.win)
                winluse.BackColor = Color.Green;
            else { winluse.BackColor = Color.Red; }
            
            moneyernerd.Text = Math.Round((decimal)participant.goldEarned/1000,1)+"k";
            cs.Text = (participant.neutralMinionsKilled+participant.totalMinionsKilled).ToString();
            Spell1.Image = Image.FromFile(@"SummonerSpells\" +participant.summoner1Id + ".png");
            Spell2.Image = Image.FromFile(@"SummonerSpells\" + participant.summoner2Id + ".png");
            chechItem(ref pictureBox1,participant.item0);
            chechItem(ref pictureBox2,participant.item1);
            chechItem(ref pictureBox3,participant.item2);
            chechItem(ref pictureBox4,participant.item3);
            chechItem(ref pictureBox5,participant.item4);
            chechItem(ref pictureBox6,participant.item5);
            
        }
        public void chechItem(ref PictureBox pb,int item)
        {
            if (item != 0)
            {
                pb.Image = Image.FromFile(@"Items\" + item + ".png");
                return;
            }
        }

        public string ConvertToSummonerSpell(int spell)
        {
            if (spell == 7)//7 6 21 3 39 12 1 11 4 14
            {
                return "SummonerHeal";
            }
            if (spell == 6)
            {
                return "SummonerGost";
            }
            if (spell == 21)
            {
                return "SummonerBarrier";
            }
            if (spell == 3)
            {
                return "SummonerExhaust";
            }
            if (spell == 39)
            {
                return "SummonerMark";
            }
            if (spell == 13)
            {
                return "SummonerBoost";
            }
            if (spell == 12)
            {
                return "SummonerTeleport";
            }
            if (spell == 1)
            {
                return "SummonerCleanse";
            }
            if (spell == 11)
            {
                return "SummonerSmite";
            }
            if (spell == 4)
            {
                return "SummonerFlash";
            }
            if (spell == 14)
            {
                return "SummonerDot";
            }
            return "SummonerHeal";

            
        }
        public Image DownloadImage(string fromUrl)
        {
            using (WebClient webClient = new WebClient())
            {
                using (Stream stream = webClient.OpenRead(fromUrl))
                {
                    return Image.FromStream(stream);
                }
            }

        }
        private void MatchView_Load(object sender, EventArgs e)
        {

        }


    }
}
