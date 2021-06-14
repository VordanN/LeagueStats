using FileSystem;
using LeageStats.API;
using LeageStats.Controller;
using LeageStats.Utilits;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace LeageStats
{
    public partial class Form1 : Form
    {
        private readonly ControllerMain controller;

        private string SummonerRegion { get; set; }
        private string SummonerName { get; set; }

        public Form1()
        {
            InitializeComponent();
            controller = new ControllerMain();


            foreach (string summonerDIR in Directory.GetFiles(@"Resurses\Info\Summoners\"))
            {
                comboBox1.Items.Add(ReadWrite.ReadJson<SummonerDTO>(summonerDIR).Name);
            }
        }



        private void Search_Click(object sender, EventArgs e)
        {
            SummonerRegion = SRegion.SelectedItem.ToString();
            SummonerName = comboBox1.Text;

            if (string.IsNullOrEmpty(SummonerRegion) || string.IsNullOrEmpty(SummonerName))
            {
                return;
            }

            if (File.Exists(@"Resurses\Info\Summoners\" + SummonerName + ".json"))
            {
                Constants.Summoner = ReadWrite.ReadJson<SummonerDTO>(@"Resurses\Info\Summoners\" + SummonerName + ".json");
            }
            else if (controller.GetSummener(SummonerRegion, SummonerName))
            {
                ReadWrite.WriteJson(Constants.Summoner, @"Resurses\Info\Summoners\" + SummonerName + ".json");
            }
            else
            {
                MessageBox.Show("Not Found/API out of date", "EROR");
                return;
            }

            Form2 form2 = new Form2();
            Hide();
            form2.Show();
        }

        private bool dragging;
        private Point pointClicked;
        private void Button1_MouseDown(object sender, MouseEventArgs e)
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
        private void Button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point pointMoveTo;
                pointMoveTo = PointToScreen(new Point(e.X, e.Y));

                pointMoveTo.Offset(-pointClicked.X, -pointClicked.Y);

                Location = pointMoveTo;
            }
        }
        private void Button1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
