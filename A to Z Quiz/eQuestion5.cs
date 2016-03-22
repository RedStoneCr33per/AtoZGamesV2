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
    public partial class eQuestion5 : Form
    {
        public eQuestion5()
        {
            InitializeComponent();
        }

        private void eAnswerBtn13_Click(object sender, EventArgs e)
        {
            this.Hide();
            easyQuestion5Wrong popup = new easyQuestion5Wrong();
            popup.Show();
        }

        private void eAnswerBtn14_Click(object sender, EventArgs e)
        {
            this.Hide();
            easyQuestion5Right popup = new easyQuestion5Right();
            popup.Show();
        }

        private void eAnswerBtn15_Click(object sender, EventArgs e)
        {
            this.Hide();
            easyQuestion5Wrong popup = new easyQuestion5Wrong();
            popup.Show();
        }
    }
}
