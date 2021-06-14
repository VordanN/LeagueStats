using LeageStats.Model;
using LeageStats.Model.Match;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LeageStats
{
    public partial class MatchStats : Form
    {

        public MatchStats(MatchDto game)
        {
            InitializeComponent();
            List<Participant> RedSide = new List<Participant>();  //200
            List<Participant> BlueSide = new List<Participant>(); //100

            foreach (Participant participant in game.info.participants)
            {
                if (participant.teamId == 100)
                {
                    BlueSide.Add(participant);
                }
                else if (participant.teamId == 200)
                {
                    RedSide.Add(participant);
                }
            }
            Team2.Text = RedSide.Last().win ? "Victory (Red Team)" : "Defeat (Red Team)";
            Team1.Text = BlueSide.Last().win ? "Victory (Blue Team)" : "Defeat (Blue Team)";


            flowLayoutPanel1.Controls.Add(Redside);
            foreach (Participant item in RedSide)
            {
                flowLayoutPanel1.Controls.Add(new ModelStatMini(item, new DateTime().AddMilliseconds(double.Parse(game.info.gameDuration.ToString()))));
            }
            flowLayoutPanel1.Controls.Add(Blueside);
            foreach (Participant item in BlueSide)
            {
                flowLayoutPanel1.Controls.Add(new ModelStatMini(item, new DateTime().AddMilliseconds(double.Parse(game.info.gameDuration.ToString()))));
            }
        }

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
                pointMoveTo = PointToScreen(new Point(e.X, e.Y));

                pointMoveTo.Offset(-pointClicked.X, -pointClicked.Y);

                Location = pointMoveTo;
            }
        }
        private new void MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

    }
}
