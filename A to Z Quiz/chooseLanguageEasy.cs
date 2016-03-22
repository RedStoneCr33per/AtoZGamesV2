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
    public partial class chooseLanguageEasy : Form
    {
        public chooseLanguageEasy()
        {
            InitializeComponent();
        }

        private void englishBtn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            easyQuestion1 popup = new easyQuestion1();
            popup.Show();
        }

        private void spanishBtn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            spanishEasyQuestion1 popup = new spanishEasyQuestion1();
            popup.Show();
        }
    }
}
