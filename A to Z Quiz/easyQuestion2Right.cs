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
    public partial class easyQuestion2Right : Form
    {
        public easyQuestion2Right()
        {
            InitializeComponent();
        }

        private void nextBtn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            easyQuestion3 popup = new easyQuestion3();
            popup.Show();
        }
    }
}
