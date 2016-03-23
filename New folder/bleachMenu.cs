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
    public partial class bleachMenu : Form
    {
        public bleachMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            bleachOpenings popup = new bleachOpenings();
            DialogResult dialogresult = popup.ShowDialog();
        }
    }
}
