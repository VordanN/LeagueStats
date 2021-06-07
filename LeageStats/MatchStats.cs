using LeageStats.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }
    }
}
