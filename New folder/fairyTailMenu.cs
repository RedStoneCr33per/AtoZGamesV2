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
    public partial class fairyTailMenu : Form
    {
        public fairyTailMenu()
        {
            InitializeComponent();
        }

        private void fairyTailCharacters_Click(object sender, EventArgs e)
        {
            this.Hide();
            fairyTailCharacters popup = new fairyTailCharacters();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void fairyTailOpenings_Click(object sender, EventArgs e)
        {
            this.Hide();
            fairyTailOpenings popup = new fairyTailOpenings();
            DialogResult dialogresult = popup.ShowDialog();
        }
    }
}
