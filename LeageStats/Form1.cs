using FileSystem;
using LeageStats.API;
using LeageStats.Controller;
using LeageStats.Utilits;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
namespace LeageStats
{
    public partial class Form1 : Form
    {
        readonly ControllerMain controller;

        string SummonerRegion { get; set; }
        string SummonerName { get; set; }

        public Form1()
        {
            InitializeComponent();
            controller = new ControllerMain();


            foreach (string summonerDIR in Directory.GetFiles(@"Info\Summoners\"))
            {
                comboBox1.Items.Add(ReadWrite.ReadJson<SummonerDTO>(summonerDIR).Name);
            }
        }



        private void Search_Click(object sender, EventArgs e)
        {
            SummonerRegion = SRegion.SelectedItem.ToString();
            SummonerName = comboBox1.Text;

            if (string.IsNullOrEmpty(SummonerRegion) || string.IsNullOrEmpty(SummonerName))
                return;

            if (File.Exists(@"Info\Summoners\" + SummonerName + ".json"))
                Constants.Summoner = ReadWrite.ReadJson<SummonerDTO>(@"Info\Summoners\" + SummonerName + ".json");
            else if (controller.GetSummener(SummonerRegion, SummonerName))
                ReadWrite.WriteJson(Constants.Summoner, @"Info\Summoners\" + SummonerName + ".json");
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
                pointMoveTo = this.PointToScreen(new Point(e.X, e.Y));

                pointMoveTo.Offset(-pointClicked.X, -pointClicked.Y);

                this.Location = pointMoveTo;
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
