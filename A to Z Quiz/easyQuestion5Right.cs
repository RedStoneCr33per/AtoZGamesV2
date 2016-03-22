using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_to_Z_Quiz
{
    public partial class easyQuestion5Right : Form
    {
        public easyQuestion5Right()
        {
            InitializeComponent();
        }

        private void nextBtn9_Click(object sender, EventArgs e)
        {
            this.Hide();
            mQuestion1 popup = new mQuestion1();
            popup.Show();
        }
    }
}
