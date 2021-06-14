using LeageStats.Model;
using LeageStats.Model.Match;
using LeageStats.Utilits;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LeageStats
{
    public partial class MatchView : UserControl
    {

        public MatchDto game;
        public MatchView(MatchDto game)
        {

            InitializeComponent();
            this.game = game;
            Participant participant = new Participant();
            foreach (Participant item in game.info.participants)
            {
                if (item.puuid == Constants.Summoner.Puuid)
                {
                    participant = item;
                    break;
                }
            }



            Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            SummoneSpeel1.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, SummoneSpeel1.Width, SummoneSpeel1.Height, 10, 10));
            SummoneSpeel2.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, SummoneSpeel2.Width, SummoneSpeel2.Height, 10, 10));
            ChampionLogo.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, ChampionLogo.Width, ChampionLogo.Height, 10, 10));

            Item1.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, Item1.Width, Item1.Height, 10, 10));
            Item2.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, Item2.Width, Item2.Height, 10, 10));
            Item3.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, Item3.Width, Item3.Height, 10, 10));
            Item4.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, Item4.Width, Item4.Height, 10, 10));
            Item5.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, Item5.Width, Item5.Height, 10, 10));
            Item6.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, Item6.Width, Item6.Height, 10, 10));
            Superitem.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, Superitem.Width, Superitem.Height, 10, 10));



            dicorativWLColor.BackColor = participant.win ? Color.Green : Color.Red;

            if (game.info.gameMode == "CLASSIC")
            {
                GameMode.Text = "Ranked Solo";
            }
            else if (game.info.gameMode == "ARAM")
            {
                GameMode.Text = "Aram";
            }
            else
            {
                GameMode.Text = game.info.gameMode;
            }

            WORL.Text = participant.win ? "WIN" : "LOSS";
            WORL.ForeColor = dicorativWLColor.BackColor;
            DateTime date = (new DateTime()).AddMilliseconds(double.Parse(game.info.gameDuration.ToString()));
            GameTime.Text = date.Minute + ":" + date.Second;
            var twp = DateTime.Now - DateTimeOffset.FromUnixTimeMilliseconds(game.info.gameStartTimestamp).DateTime.AddHours(3);
            if(twp.Days > 0)
            {
                TimeWhenPlayed.Text = twp.Days.ToString() + " d " + twp.Hours + " h ago";
            }
            else if (twp.Hours > 0)
            {
                TimeWhenPlayed.Text = twp.Hours.ToString() + " hours ago";
            }
            else
            {
                TimeWhenPlayed.Text = twp.Minutes.ToString() + " minutes ago";
            }
            

            ChampionLogo.Image = Constants.GetImage(@"Resurses\SummonerIcons\" + participant.championName + ".png", "https://ddragon.leagueoflegends.com/cdn/11.8.1/img/champion/" + participant.championName + ".png");
            SummoneSpeel1.Image = Image.FromFile(@"Resurses\SummonerSpells\" + participant.summoner1Id + ".png");
            SummoneSpeel2.Image = Image.FromFile(@"Resurses\SummonerSpells\" + participant.summoner2Id + ".png");
            ChampionLvL.Text = participant.champLevel.ToString();

            KDA.Text = participant.kills + "/ " + participant.deaths + " /" + participant.assists;
            double d = participant.deaths, k = participant.kills, a = participant.assists;
            double kda = (k + a) / d;
            KDAProsent.Text = Constants.DecimalPlaceNoRounding(kda);
            double tm = participant.neutralMinionsKilled + participant.totalMinionsKilled, m = date.Minute;
            double csm = tm / m;
            CS.Text = (participant.neutralMinionsKilled + participant.totalMinionsKilled).ToString() + " CS (" + Constants.DecimalPlaceNoRounding(csm, 1) + ")";


            Constants.ChechItem(ref Superitem, participant.item6);
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
            Constants.ChechItem(ref Item1, items[0]);
            Constants.ChechItem(ref Item2, items[1]);
            Constants.ChechItem(ref Item3, items[2]);
            Constants.ChechItem(ref Item4, items[3]);
            Constants.ChechItem(ref Item5, items[4]);
            Constants.ChechItem(ref Item6, items[5]);
            Vision.Text = "Vision: " + participant.visionScore;


            summonerLogo1.Image = Constants.GetImage(@"Resurses\SummonerIcons\" + game.info.participants.ElementAt(0).championName + ".png", "https://ddragon.leagueoflegends.com/cdn/11.8.1/img/champion/" + game.info.participants.ElementAt(0).championName + ".png");
            summonerLogo2.Image = Constants.GetImage(@"Resurses\SummonerIcons\" + game.info.participants.ElementAt(1).championName + ".png", "https://ddragon.leagueoflegends.com/cdn/11.8.1/img/champion/" + game.info.participants.ElementAt(1).championName + ".png");
            summonerLogo3.Image = Constants.GetImage(@"Resurses\SummonerIcons\" + game.info.participants.ElementAt(2).championName + ".png", "https://ddragon.leagueoflegends.com/cdn/11.8.1/img/champion/" + game.info.participants.ElementAt(2).championName + ".png");
            summonerLogo4.Image = Constants.GetImage(@"Resurses\SummonerIcons\" + game.info.participants.ElementAt(3).championName + ".png", "https://ddragon.leagueoflegends.com/cdn/11.8.1/img/champion/" + game.info.participants.ElementAt(3).championName + ".png");
            summonerLogo5.Image = Constants.GetImage(@"Resurses\SummonerIcons\" + game.info.participants.ElementAt(4).championName + ".png", "https://ddragon.leagueoflegends.com/cdn/11.8.1/img/champion/" + game.info.participants.ElementAt(4).championName + ".png");
            summonerLogo6.Image = Constants.GetImage(@"Resurses\SummonerIcons\" + game.info.participants.ElementAt(5).championName + ".png", "https://ddragon.leagueoflegends.com/cdn/11.8.1/img/champion/" + game.info.participants.ElementAt(5).championName + ".png");
            summonerLogo7.Image = Constants.GetImage(@"Resurses\SummonerIcons\" + game.info.participants.ElementAt(6).championName + ".png", "https://ddragon.leagueoflegends.com/cdn/11.8.1/img/champion/" + game.info.participants.ElementAt(6).championName + ".png");
            summonerLogo8.Image = Constants.GetImage(@"Resurses\SummonerIcons\" + game.info.participants.ElementAt(7).championName + ".png", "https://ddragon.leagueoflegends.com/cdn/11.8.1/img/champion/" + game.info.participants.ElementAt(7).championName + ".png");
            summonerLogo9.Image = Constants.GetImage(@"Resurses\SummonerIcons\" + game.info.participants.ElementAt(8).championName + ".png", "https://ddragon.leagueoflegends.com/cdn/11.8.1/img/champion/" + game.info.participants.ElementAt(8).championName + ".png");
            summonerLogo10.Image = Constants.GetImage(@"Resurses\SummonerIcons\" + game.info.participants.ElementAt(9).championName + ".png", "https://ddragon.leagueoflegends.com/cdn/11.8.1/img/champion/" + game.info.participants.ElementAt(9).championName + ".png");

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


        private void MatchView_Click(object sender, EventArgs e)
        {
            MatchStats matchStats = new MatchStats(game);
            matchStats.Show();

        }
    }
}
