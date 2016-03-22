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
    public partial class easyQuestion2 : Form
    {
        public easyQuestion2()
        {
            InitializeComponent();
        }

        private void eQuestionBtn4_Click(object sender, EventArgs e)
        {
            this.Hide();
            easyQuestion2Wrong popup = new easyQuestion2Wrong();
            popup.Show();
        }

        private void eQuestionBtn5_Click(object sender, EventArgs e)
        {
            this.Hide();
            easyQuestion2Right popup = new easyQuestion2Right();
            popup.Show();
        }

        private void eQuestionBtn6_Click(object sender, EventArgs e)
        {
            this.Hide();
            easyQuestion2Wrong popup = new easyQuestion2Wrong();
            popup.Show();
        }
    }
}
