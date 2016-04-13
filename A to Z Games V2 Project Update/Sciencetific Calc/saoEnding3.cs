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
    public partial class saoEnding3 : Form
    {
        public saoEnding3()
        {
            InitializeComponent();
        }

        private void saoEndingsBackBtn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            saoEnding2 popup = new saoEnding2();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void saoEndingsNextBtn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            saoEnding2 popup = new saoEnding2();
            DialogResult dialogresult = popup.ShowDialog();
        }
    }
}
