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
    public partial class easyQuestion1 : Form
    {
        public easyQuestion1()
        {
            InitializeComponent();
        }

        private void eAnswerBtn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            easyQuestion1Right popup = new easyQuestion1Right();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void eAnswerBtn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            easyQuestion1Right popup = new easyQuestion1Right();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void eAnswerBtn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            easyQuestion1Right popup = new easyQuestion1Right();
            DialogResult dialogresult = popup.ShowDialog();
        }
    }
}
