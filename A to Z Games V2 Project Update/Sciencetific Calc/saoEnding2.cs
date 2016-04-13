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
    public partial class saoEnding2 : Form
    {
        public saoEnding2()
        {
            InitializeComponent();
        }

        private void saoEndingsBackBtn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            saoEnding1 popup = new saoEnding1();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void saoEndingsNextBtn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            saoEnding2 popup = new saoEnding2();
            DialogResult dialogresult = popup.ShowDialog();
        }
    }
}
