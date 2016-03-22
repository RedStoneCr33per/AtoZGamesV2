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
    public partial class mQuestion1 : Form
    {
        public mQuestion1()
        {
            InitializeComponent();
        }

        private void mAnswerBtn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mediumQuestion1Wrong popup = new mediumQuestion1Wrong();
            popup.Show();
        }

        private void mAnswerBtn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mediumQuestion1Right popup = new mediumQuestion1Right();
            popup.Show();
        }

        private void mAnswerBtn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            mediumQuestion1Wrong popup = new mediumQuestion1Wrong();
            popup.Show();
        }
    }
}
