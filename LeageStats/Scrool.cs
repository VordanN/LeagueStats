using System;
using System.Windows.Forms;

namespace LeageStats
{
    public partial class Scrool : Form
    {
        public int start;
        public int end;
        public Scrool()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (Start.Text == "" || End.Text == "")
                return;

            start = Convert.ToInt32(Start.Text);
            end = Convert.ToInt32(End.Text);

            Close();
        }
    }
}
