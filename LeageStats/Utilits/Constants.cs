using LeageStats.API;
using LeageStats.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LeageStats.Utilits
{
    public static class Constants
    {
        public static SummonerDTO Summoner { get; set; }
        public static LeagueEntryDTO entryDTO { get; set; }


        public static string DecimalPlaceNoRounding(double d, int decimalPlaces = 2)
        {
            d *= Math.Pow(10, decimalPlaces);
            d = Math.Truncate(d);
            d /= Math.Pow(10, decimalPlaces);
            return string.Format("{0:N" + Math.Abs(decimalPlaces) + "}", d);
        }
        public static void ChechItem(ref PictureBox pb, int item)
        {
            if (item != 0)
            {
                pb.Image = Image.FromFile(@"Resurses\Items\" + item + ".png");
                return;
            }
        }
        public static int convertRomanToInt(string romanNumeral)
        {
            Dictionary<char, int> romanMap = new Dictionary<char, int>
            {
                {'I', 1 },
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            int result = 0;
            for (int index = romanNumeral.Length - 1, last = 0; index >= 0; index--)
            {
                int current = romanMap[romanNumeral[index]];
                result += (current < last ? -current : current);
                last = current;
            }

            return result;
        }
        public static string ConvertToSummonerSpell(int spell)
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
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public static Image GetImage(string filleName, string url = "")
        {

            if (File.Exists(filleName))
            {
                return Image.FromFile(filleName);
            }
            return DownloadImage(url);
        }
        public static Image DownloadImage(string fromUrl)
        {
            using (WebClient webClient = new WebClient())
            {
                using (Stream stream = webClient.OpenRead(fromUrl))
                {
                    return Image.FromStream(stream);
                }
            }

        }



    }

}
