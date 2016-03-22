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
    public partial class easyQuestion4Right : Form
    {
        public easyQuestion4Right()
        {
            InitializeComponent();
        }

        private void nextBtn7_Click(object sender, EventArgs e)
        {
            this.Hide();
            eQuestion5 popup = new eQuestion5();
            popup.Show();
        }
    }
}
