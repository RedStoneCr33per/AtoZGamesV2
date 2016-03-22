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
    public partial class chooseDifficulty : Form
    {
        public chooseDifficulty()
        {
            InitializeComponent();
        }

        private void easyBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            chooseLanguageEasy popup = new chooseLanguageEasy();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void mediumBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            mQuestion1 popup = new mQuestion1();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void hardBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            hQuestion1 popup = new hQuestion1();
            DialogResult dialogresult = popup.ShowDialog();
        }
    }
}
