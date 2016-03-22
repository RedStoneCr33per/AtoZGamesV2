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
    public partial class mQuestion2 : Form
    {
        public mQuestion2()
        {
            InitializeComponent();
        }

        private void mAnswerBtn4_Click(object sender, EventArgs e)
        {
            this.Hide();
            mediumQuestion2Wrong popup = new mediumQuestion2Wrong();
            popup.Show();
        }

        private void mAnswerBtn5_Click(object sender, EventArgs e)
        {
            this.Hide();
            mediumQuestion2Wrong popup = new mediumQuestion2Wrong();
            popup.Show();
        }

        private void mAnswerBtn6_Click(object sender, EventArgs e)
        {
            this.Hide();
            mediumQuestion2Right popup = new mediumQuestion2Right();
            popup.Show();
        }
    }
}
