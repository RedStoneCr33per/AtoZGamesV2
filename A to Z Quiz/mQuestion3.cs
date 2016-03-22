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
    public partial class mQuestion3 : Form
    {
        public mQuestion3()
        {
            InitializeComponent();
        }

        private void mAnswerBtn7_Click(object sender, EventArgs e)
        {
            this.Hide();
            mediumQuestion3Wrong popup = new mediumQuestion3Wrong();
            popup.Show();
        }

        private void mAnswerBtn8_Click(object sender, EventArgs e)
        {
            this.Hide();
            mediumQuestion3Wrong popup = new mediumQuestion3Wrong();
            popup.Show();
        }

        private void mAnswerBtn9_Click(object sender, EventArgs e)
        {
            this.Hide();
            mediumQuestion3Right popup = new mediumQuestion3Right();
            popup.Show();
        }
    }
}
