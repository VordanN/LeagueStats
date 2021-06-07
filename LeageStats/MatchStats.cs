using LeageStats.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeageStats
{
    public partial class MatchStats : Form
    {

        public MatchStats(Root game)
        {
            InitializeComponent();
            List<Participant1> RedSide = new List<Participant1>();  //200
            List<Participant1> BlueSide = new List<Participant1>(); //100

            
            foreach (Participant1 participant in game.info.participants)
            {
                if (participant.teamId == 100)
                {
                    BlueSide.Add(participant);
                }else if(participant.teamId == 200)
                {
                    RedSide.Add(participant);
                }
            }
            Team2.Text = RedSide.Last().win ? "Victory (Red Team)" : "Defeat (Red Team)";
            Team1.Text = BlueSide.Last().win ? "Victory (Blue Team)" : "Defeat (Blue Team)";


            flowLayoutPanel1.Controls.Add(Redside);
            foreach (var item in RedSide)
            {
                flowLayoutPanel1.Controls.Add(new ModelStatMini(item, new DateTime().AddMilliseconds(double.Parse(game.info.gameDuration.ToString()))));
            }
            flowLayoutPanel1.Controls.Add(Blueside);
            foreach (var item in BlueSide)
            {
                flowLayoutPanel1.Controls.Add(new ModelStatMini(item, new DateTime().AddMilliseconds(double.Parse(game.info.gameDuration.ToString()))));
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
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

    }
}
