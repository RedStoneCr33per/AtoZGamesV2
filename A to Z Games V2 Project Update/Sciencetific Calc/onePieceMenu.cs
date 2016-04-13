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
    public partial class onePieceMenu : Form
    {
        public onePieceMenu()
        {
            InitializeComponent();
        }

        private void onePieceOpenings_Click(object sender, EventArgs e)
        {
            this.Hide();
            onePieceOpenings popup = new onePieceOpenings();
            DialogResult dialogresult = popup.ShowDialog();
        }
    }
}
