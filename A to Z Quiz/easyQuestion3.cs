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
    public partial class easyQuestion3 : Form
    {
        public easyQuestion3()
        {
            InitializeComponent();
        }

        private void eAnswerBtn7_Click(object sender, EventArgs e)
        {
            this.Hide();
            easyQuestion3Wrong popup = new easyQuestion2();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void eAnswerBtn8_Click(object sender, EventArgs e)
        {
            this.Hide();
            easyQuestion3Right popup = new easyQuestion3Right();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void eAnswerBtn9_Click(object sender, EventArgs e)
        {
            this.Hide();
            easyQuestion3Wrong popup = new easyQuestion2();
            DialogResult dialogresult = popup.ShowDialog();
        }
    }
}
