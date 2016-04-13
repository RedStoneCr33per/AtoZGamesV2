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
    public partial class saoEnding1 : Form
    {
        public saoEnding1()
        {
            InitializeComponent();
        }

        private void saoEndingsBackBtn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            swordArtOnlineMenu popup = new swordArtOnlineMenu();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void saoEndingsNextBtn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            saoEnding2 popup = new saoEnding2();
            DialogResult dialogresult = popup.ShowDialog();
        }
    }
}
