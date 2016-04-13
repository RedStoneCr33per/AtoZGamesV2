using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sciencetific_Calc
{
    public partial class fairyTailEpisode4 : Form
    {
        public fairyTailEpisode4()
        {
            InitializeComponent();
        }

        private void fairyTailEpisodeMenuBtn4_Click(object sender, EventArgs e)
        {
            this.Hide();
            fairyTailEpisodesMenu popup = new fairyTailEpisodesMenu();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void fairyTailEpisodeNextBtn4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 popup = new Form1();
            DialogResult dialogresult = popup.ShowDialog();
        }
    }
}
