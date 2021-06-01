using LeageStats.Controller;
using LeageStats.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeageStats.Utilits;
using FileSystem;
using System.IO;

namespace LeageStats
{
    public partial class Form1 : Form
    {
        ControllerMain controller;

        string SummonerRegion { get; set; }
        string SummonerName { get; set; }

        public Form1()
        {
            controller = new ControllerMain();
            InitializeComponent();
            string[] summoners = Directory.GetFiles(@"Info\Summoners\");
            foreach (string summonerDIR in summoners)
            {
                comboBox1.Items.Add(ReadWrite.ReadJson<SummonerDTO>(summonerDIR).Name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void search_Click(object sender, EventArgs e)
        {
            SummonerName = comboBox1.Text;
            SummonerRegion = SRegion.SelectedItem.ToString();
            if (string.IsNullOrEmpty(SummonerRegion) || string.IsNullOrEmpty(SummonerName))
                return;

            if (File.Exists(@"Info\Summoners\" + SummonerName + ".json"))
            {
                Constants.Summoner = ReadWrite.ReadJson<SummonerDTO>(@"Info\Summoners\" + SummonerName + ".json");
            }
            else if (controller.GetSummener(SummonerRegion, SummonerName))
            {
                ReadWrite.WriteJson(Constants.Summoner, @"Info\Summoners\" + SummonerName + ".json");
            }
            else
            {
                MessageBox.Show("Not Found/API out of date","EROR");
                return;
            }
            Form2 form2 = new Form2();
            Hide();
            form2.Show();
        }

    }
}
