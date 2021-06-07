using System;
using System.Drawing;
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





        private bool dragging;
        private Point pointClicked;
        private new void MouseDown(object sender, MouseEventArgs e)
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
        private new void MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point pointMoveTo;
                pointMoveTo = this.PointToScreen(new Point(e.X, e.Y));

                pointMoveTo.Offset(-pointClicked.X, -pointClicked.Y);

                this.Location = pointMoveTo;
            }
        }
        private new void MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
