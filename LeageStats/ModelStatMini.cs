using LeageStats.Controller;
using LeageStats.Model;
using LeageStats.Model.Match;
using LeageStats.Utilits;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LeageStats
{
    public partial class ModelStatMini : UserControl
    {

        public ModelStatMini(Participant participant, DateTime date)
        {
            InitializeComponent();

            Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            SummoneSpeel1.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, SummoneSpeel1.Width, SummoneSpeel1.Height, 5, 5));
            SummoneSpeel2.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, SummoneSpeel2.Width, SummoneSpeel2.Height, 5, 5));
            ChampionLogo.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, ChampionLogo.Width, ChampionLogo.Height, 5, 5));

            Item1.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, Item1.Width, Item1.Height, 5, 5));
            Item2.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, Item2.Width, Item2.Height, 5, 5));
            Item3.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, Item3.Width, Item3.Height, 5, 5));
            Item4.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, Item4.Width, Item4.Height, 5, 5));
            Item5.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, Item5.Width, Item5.Height, 5, 5));
            Item6.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, Item6.Width, Item6.Height, 5, 5));
            Superitem.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, Superitem.Width, Superitem.Height, 5, 5));
            RankPiccuere.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, Item6.Width, Item6.Height, 5, 5));
            MainRune.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, Item6.Width, Item6.Height, 5, 5));
            SubRune.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, Item6.Width, Item6.Height, 5, 5));


            ChampionLogo.Image = Constants.GetImage(@"Resurses\SummonerIcons\" + participant.championName + ".png", "https://ddragon.leagueoflegends.com/cdn/11.8.1/img/champion/" + participant.championName + ".png");
            SummoneSpeel1.Image = Image.FromFile(@"Resurses\SummonerSpells\" + participant.summoner1Id + ".png");
            SummoneSpeel2.Image = Image.FromFile(@"Resurses\SummonerSpells\" + participant.summoner2Id + ".png");
            ChampionLvL.Text = participant.champLevel.ToString();

            MainRune.Image = Image.FromFile(@"Resurses\Runes\" + participant.perks.styles[0].style + ".png");
            SubRune.Image = Image.FromFile(@"Resurses\Runes\" + participant.perks.styles[1].style + ".png");

            SummonerName.Text = participant.summonerName;
            LeagueEntryDTO entry = ControlerProfile.GetPosition(participant.summonerId);

            Rank.Text = entry.Tier.ToUpper()[0] + entry.Tier.Substring(1).ToLower() + " " + entry.Rank;
            RankPiccuere.Image = Image.FromFile("Resurses/Emblems/Season_2019_-_" + entry.Tier.ToUpper()[0] + entry.Tier.Substring(1) + "_" + Constants.convertRomanToInt(entry.Rank) + ".png");

            KDA.Text = participant.kills + "/ " + participant.deaths + " /" + participant.assists;
            double d = participant.deaths, k = participant.kills, a = participant.assists;
            double kda = (k + a) / d;
            KDAProsent.Text = Constants.DecimalPlaceNoRounding(kda) + " KDA";
            double tm = participant.neutralMinionsKilled + participant.totalMinionsKilled, m = date.Minute;
            double csm = tm / m;
            CS.Text = (participant.neutralMinionsKilled + participant.totalMinionsKilled).ToString();

            Damauge.Text = participant.totalDamageDealtToChampions.ToString();
            Gold.Text = Math.Round((decimal)participant.goldEarned / 1000, 1) + "k";
            Wards.Text = participant.wardsPlaced.ToString();

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

            SummonerName.Left = panel1.Width / 2 - SummonerName.Size.Width / 2;
            Rank.Left = panel1.Width / 2 - Rank.Size.Width / 2;
            Damauge.Left = panel4.Width / 2 - Damauge.Size.Width / 2;

            KDA.Left = panel3.Width / 2 - KDA.Size.Width / 2;
            KDAProsent.Left = panel3.Width / 2 - KDAProsent.Size.Width / 2;
            CS.Left = panel6.Width / 2 - CS.Size.Width / 2;
            Gold.Left = panel5.Width / 2 - Gold.Size.Width / 2;
            Wards.Left = panel7.Width / 2 - Wards.Size.Width / 2;

        }


        private void panel9_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://" + Constants.Summoner.Region + ".op.gg/summoner/userName=" + SummonerName.Text);
            Process.Start(sInfo);
        }
    }
}
