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
    public partial class saoEnding4 : Form
    {
        public saoEnding4()
        {
            InitializeComponent();
        }

        private void saoEndingsBackBtn4_Click(object sender, EventArgs e)
        {
            this.Hide();
            saoEnding3 popup = new saoEnding3();
            DialogResult dialogresult = popup.ShowDialog();
        }
    }
}
