using LeageStats.API;
using LeageStats.Controller;
using LeageStats.Model;
using LeageStats.Utilits;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeageStats
{
    public partial class ModelStatMini : UserControl
    {
        
        public ModelStatMini(Participant1 participant,DateTime date)
        {
            InitializeComponent();

            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            SummoneSpeel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, SummoneSpeel1.Width, SummoneSpeel1.Height, 5, 5));
            SummoneSpeel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, SummoneSpeel2.Width, SummoneSpeel2.Height, 5, 5));
            ChampionLogo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ChampionLogo.Width, ChampionLogo.Height, 5, 5));

            Item1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Item1.Width, Item1.Height, 5, 5));
            Item2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Item2.Width, Item2.Height, 5, 5));
            Item3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Item3.Width, Item3.Height, 5, 5));
            Item4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Item4.Width, Item4.Height, 5, 5));
            Item5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Item5.Width, Item5.Height, 5, 5));
            Item6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Item6.Width, Item6.Height, 5, 5));
            Superitem.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Superitem.Width, Superitem.Height, 5, 5));
            RankPiccuere.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Item6.Width, Item6.Height, 5, 5));
            MainRune.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Item6.Width, Item6.Height, 5, 5));
            SubRune.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Item6.Width, Item6.Height, 5, 5));


            ChampionLogo.Image = GetImage(@"SummonerIcons\" + participant.championName + ".png", "https://ddragon.leagueoflegends.com/cdn/11.8.1/img/champion/" + participant.championName + ".png");
            SummoneSpeel1.Image = Image.FromFile(@"SummonerSpells\" + participant.summoner1Id + ".png");
            SummoneSpeel2.Image = Image.FromFile(@"SummonerSpells\" + participant.summoner2Id + ".png");
            ChampionLvL.Text = participant.champLevel.ToString();

            SummonerName.Text = participant.summonerName;
            var entry = ControlerProfile.GetPosition(participant.summonerId);

            Rank.Text = entry.Tier.ToUpper()[0] + entry.Tier.Substring(1).ToLower() + " " + entry.Rank;
            RankPiccuere.Image = Image.FromFile("emblems/Season_2019_-_" + entry.Tier.ToUpper()[0] + entry.Tier.Substring(1) + "_" + convertRomanToInt(entry.Rank) + ".png");

            KDA.Text = participant.kills + "/ " + participant.deaths + " /" + participant.assists;
            double d = participant.deaths, k = participant.kills, a = participant.assists;
            double kda = (k + a) / d;
            KDAProsent.Text = DecimalPlaceNoRounding(kda)+" KDA";
            double tm = participant.neutralMinionsKilled + participant.totalMinionsKilled, m = date.Minute;
            double csm = tm / m;
            CS.Text = (participant.neutralMinionsKilled + participant.totalMinionsKilled).ToString();

            Damauge.Text = participant.totalDamageDealtToChampions.ToString();
            Gold.Text = Math.Round((decimal)participant.goldEarned / 1000, 1) + "k";
            Wards.Text = participant.wardsPlaced.ToString();

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

            SummonerName.Left = panel1.Width / 2 - SummonerName.Size.Width / 2;
            Rank.Left = panel1.Width / 2 - Rank.Size.Width / 2;
            Damauge.Left = panel4.Width / 2 - Damauge.Size.Width / 2;

            KDA.Left = panel3.Width / 2 - KDA.Size.Width / 2;
            KDAProsent.Left = panel3.Width / 2 - KDAProsent.Size.Width / 2;
            CS.Left = panel6.Width / 2 - CS.Size.Width / 2;
            Gold.Left = panel5.Width / 2 - Gold.Size.Width / 2;
            Wards.Left = panel7.Width / 2 - Wards.Size.Width / 2;

        }
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
        private static int convertRomanToInt(String romanNumeral)
        {
            Dictionary<Char, Int32> romanMap = new Dictionary<char, int>
            {
                {'I', 1 },
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            Int32 result = 0;
            for (Int32 index = romanNumeral.Length - 1, last = 0; index >= 0; index--)
            {
                Int32 current = romanMap[romanNumeral[index]];
                result += (current < last ? -current : current);
                last = current;
            }

            return result;
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
        private Image GetImage(string filleName, string url = "")
        {

            if (File.Exists(filleName))
            {
                return Image.FromFile(filleName);
            }
            return DownloadImage(url);
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

        private void panel9_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://"+Constants.Summoner.Region+".op.gg/summoner/userName="+ SummonerName.Text);
            Process.Start(sInfo);
        }
    }
}
