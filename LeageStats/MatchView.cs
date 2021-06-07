using LeageStats.Model;
using LeageStats.Utilits;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LeageStats
{
    public partial class MatchView : UserControl
    {
        private Image GetImage(string filleName, string url = "")
        {

            if (File.Exists(filleName))
            {
                return Image.FromFile(filleName);
            }
            return DownloadImage(url);
        }
        public Root game;
        public MatchView(Root game)
        {

            InitializeComponent();
            this.game = game;
            Participant1 participant = new Participant1();
            foreach (Participant1 item in game.info.participants)
            {
                if (item.puuid == Constants.Summoner.Puuid)
                {
                    participant = item;
                    break;
                }
            }



            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            SummoneSpeel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, SummoneSpeel1.Width, SummoneSpeel1.Height, 10, 10));
            SummoneSpeel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, SummoneSpeel2.Width, SummoneSpeel2.Height, 10, 10));
            ChampionLogo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ChampionLogo.Width, ChampionLogo.Height, 10, 10));

            Item1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Item1.Width, Item1.Height, 10, 10));
            Item2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Item2.Width, Item2.Height, 10, 10));
            Item3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Item3.Width, Item3.Height, 10, 10));
            Item4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Item4.Width, Item4.Height, 10, 10));
            Item5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Item5.Width, Item5.Height, 10, 10));
            Item6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Item6.Width, Item6.Height, 10, 10));
            Superitem.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Superitem.Width, Superitem.Height, 10, 10));



            dicorativWLColor.BackColor = participant.win ? Color.Green : Color.Red;

            GameMode.Text = game.info.gameType;
            WORL.Text = participant.win ? "WIN" : "LOSS";
            WORL.ForeColor = dicorativWLColor.BackColor;
            var date = (new DateTime()).AddMilliseconds(double.Parse(game.info.gameDuration.ToString()));
            GameTime.Text = date.Minute + ":" + date.Second;
            TimeWhenPlayed.Text = (DateTime.Now - DateTimeOffset.FromUnixTimeMilliseconds(game.info.gameStartTimestamp).DateTime.AddHours(3)).Hours + " hours ago";

            ChampionLogo.Image = GetImage(@"SummonerIcons\" + participant.championName + ".png", "https://ddragon.leagueoflegends.com/cdn/11.8.1/img/champion/" + participant.championName + ".png");
            SummoneSpeel1.Image = Image.FromFile(@"SummonerSpells\" + participant.summoner1Id + ".png");
            SummoneSpeel2.Image = Image.FromFile(@"SummonerSpells\" + participant.summoner2Id + ".png");
            ChampionLvL.Text = participant.champLevel.ToString();

            KDA.Text = participant.kills + "/ " + participant.deaths + " /" + participant.assists;
            double d = participant.deaths, k = participant.kills, a = participant.assists;
            double kda = (k + a) / d;
            KDAProsent.Text = DecimalPlaceNoRounding(kda);
            double tm = participant.neutralMinionsKilled + participant.totalMinionsKilled, m = date.Minute;
            double csm = tm / m;
            CS.Text = (participant.neutralMinionsKilled + participant.totalMinionsKilled).ToString() + " CS (" + DecimalPlaceNoRounding(csm, 1) + ")";


            ChechItem(ref Superitem, participant.item6);
            List<int> items = new List<int>()
            {
                participant.item0,
                participant.item1,
                participant.item2,
                participant.item3,
                participant.item4,
                participant.item5,
            };
            items = items.OrderByDescending(x => x).ToList();
            ChechItem(ref Item1, items[0]);
            ChechItem(ref Item2, items[1]);
            ChechItem(ref Item3, items[2]);
            ChechItem(ref Item4, items[3]);
            ChechItem(ref Item5, items[4]);
            ChechItem(ref Item6, items[5]);
            Vision.Text = "Vision: " + participant.visionScore;


            summonerLogo1.Image = GetImage(@"SummonerIcons\" + game.info.participants.ElementAt(0).championName + ".png", "https://ddragon.leagueoflegends.com/cdn/11.8.1/img/champion/" + game.info.participants.ElementAt(0).championName + ".png");
            summonerLogo2.Image = GetImage(@"SummonerIcons\" + game.info.participants.ElementAt(1).championName + ".png", "https://ddragon.leagueoflegends.com/cdn/11.8.1/img/champion/" + game.info.participants.ElementAt(1).championName + ".png");
            summonerLogo3.Image = GetImage(@"SummonerIcons\" + game.info.participants.ElementAt(2).championName + ".png", "https://ddragon.leagueoflegends.com/cdn/11.8.1/img/champion/" + game.info.participants.ElementAt(2).championName + ".png");
            summonerLogo4.Image = GetImage(@"SummonerIcons\" + game.info.participants.ElementAt(3).championName + ".png", "https://ddragon.leagueoflegends.com/cdn/11.8.1/img/champion/" + game.info.participants.ElementAt(3).championName + ".png");
            summonerLogo5.Image = GetImage(@"SummonerIcons\" + game.info.participants.ElementAt(4).championName + ".png", "https://ddragon.leagueoflegends.com/cdn/11.8.1/img/champion/" + game.info.participants.ElementAt(4).championName + ".png");
            summonerLogo6.Image = GetImage(@"SummonerIcons\" + game.info.participants.ElementAt(5).championName + ".png", "https://ddragon.leagueoflegends.com/cdn/11.8.1/img/champion/" + game.info.participants.ElementAt(5).championName + ".png");
            summonerLogo7.Image = GetImage(@"SummonerIcons\" + game.info.participants.ElementAt(6).championName + ".png", "https://ddragon.leagueoflegends.com/cdn/11.8.1/img/champion/" + game.info.participants.ElementAt(6).championName + ".png");
            summonerLogo8.Image = GetImage(@"SummonerIcons\" + game.info.participants.ElementAt(7).championName + ".png", "https://ddragon.leagueoflegends.com/cdn/11.8.1/img/champion/" + game.info.participants.ElementAt(7).championName + ".png");
            summonerLogo9.Image = GetImage(@"SummonerIcons\" + game.info.participants.ElementAt(8).championName + ".png", "https://ddragon.leagueoflegends.com/cdn/11.8.1/img/champion/" + game.info.participants.ElementAt(8).championName + ".png");
            summonerLogo10.Image = GetImage(@"SummonerIcons\" + game.info.participants.ElementAt(9).championName + ".png", "https://ddragon.leagueoflegends.com/cdn/11.8.1/img/champion/" + game.info.participants.ElementAt(9).championName + ".png");

            summonerName1.Text = game.info.participants.ElementAt(0).summonerName;
            summonerName2.Text = game.info.participants.ElementAt(1).summonerName;
            summonerName3.Text = game.info.participants.ElementAt(2).summonerName;
            summonerName4.Text = game.info.participants.ElementAt(3).summonerName;
            summonerName5.Text = game.info.participants.ElementAt(4).summonerName;
            summonerName6.Text = game.info.participants.ElementAt(5).summonerName;
            summonerName7.Text = game.info.participants.ElementAt(6).summonerName;
            summonerName8.Text = game.info.participants.ElementAt(7).summonerName;
            summonerName9.Text = game.info.participants.ElementAt(8).summonerName;
            summonerName10.Text = game.info.participants.ElementAt(9).summonerName;


            GameMode.Left = panel1.Width / 2 - GameMode.Size.Width / 2;
            TimeWhenPlayed.Left = panel1.Width / 2 - TimeWhenPlayed.Size.Width / 2;

            KDA.Left = panel3.Width / 2 - KDA.Size.Width / 2;
            KDAProsent.Left = panel3.Width / 2 - KDAProsent.Size.Width / 2;
            CS.Left = panel3.Width / 2 - CS.Size.Width / 2;
            Vision.Left = panel4.Width / 2 - Vision.Width / 2;
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

        string DecimalPlaceNoRounding(double d, int decimalPlaces = 2)
        {
            d *= Math.Pow(10, decimalPlaces);
            d = Math.Truncate(d);
            d /= Math.Pow(10, decimalPlaces);
            return string.Format("{0:N" + Math.Abs(decimalPlaces) + "}", d);
        }
        public void ChechItem(ref PictureBox pb, int item)
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

        private void MatchView_Click(object sender, EventArgs e)
        {
            MatchStats matchStats = new MatchStats(game);
            matchStats.Show();

        }
    }
}
