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
    public partial class easyQuestion3Right : Form
    {
        public easyQuestion3Right()
        {
            InitializeComponent();
        }

        private void nextBtn5_Click(object sender, EventArgs e)
        {
            this.Hide();
            easyQuestion4 popup = new easyQuestion4();
            popup.Show();
        }
    }
}
