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
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SummonerRegion = (string)SRegion.Items[SRegion.SelectedIndex];
        }

        private void BlockText(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void SName_TextChanged(object sender, EventArgs e)
        {
            SummonerName = SName.Text;
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SummonerRegion))
                return;
            if (string.IsNullOrEmpty(SummonerName))
                return;

            if (controller.GetSummener(SummonerRegion,SummonerName))
            {

                Form2 form2 = new Form2();
                Hide();
                form2.Show();
                
            }
            else
            {
                MessageBox.Show("Not Found");
            }
            
        }

        private void InputPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
