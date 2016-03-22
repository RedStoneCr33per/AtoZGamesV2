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
    public partial class spanishEasyQuestion1 : Form
    {
        public spanishEasyQuestion1()
        {
            InitializeComponent();
        }

        private void spanishAnswerBtn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            spanishEasyQuestion1Right popup = new spanishEasyQuestion1Right();
            popup.Show();
        }

        private void spanishAnswerBtn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            spanishEasyQuestion1Wrong popup = new spanishEasyQuestion1Wrong();
            popup.Show();
        }

        private void spanishAnswerBtn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            spanishEasyQuestion1Wrong popup = new spanishEasyQuestion1Wrong();
            popup.Show();
        }
    }
}
