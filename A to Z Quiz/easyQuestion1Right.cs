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
    public partial class easyQuestion1Right : Form
    {
        public easyQuestion1Right()
        {
            InitializeComponent();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            easyQuestion2 popup = new easyQuestion2();
            DialogResult dialogresult = popup.ShowDialog();
        }
    }
}
