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
    public partial class easyQuestion4 : Form
    {
        public easyQuestion4()
        {
            InitializeComponent();
        }

        private void eAnswerBtn10_Click(object sender, EventArgs e)
        {
            this.Hide();
            easyQuestion4Wrong popup = new easyQuestion2Wrong();
            popup.Show();
        }

        private void eAnswerBtn11_Click(object sender, EventArgs e)
        {
            this.Hide();
            easyQuestion4Wrong popup = new easyQuestion2Wrong();
            popup.Show();
        }

        private void eAnswerBtn12_Click(object sender, EventArgs e)
        {
            this.Hide();
            easyQuestion4Right popup = new easyQuestion2Wrong();
            popup.Show();
        }
    }
}
