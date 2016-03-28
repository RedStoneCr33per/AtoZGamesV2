using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sciencetific_Calc
{
    public partial class swordArtOnlineMenu : Form
    {
        public swordArtOnlineMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            saoOpenings popup = new saoOpenings();
            DialogResult dialogresult = popup.ShowDialog();
        }
    }
}
