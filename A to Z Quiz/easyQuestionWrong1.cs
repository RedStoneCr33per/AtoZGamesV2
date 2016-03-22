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
    public partial class easyQuestionWrong1 : Form
    {
        public easyQuestionWrong1()
        {
            InitializeComponent();
        }

        private void NextBtn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            easyQuestion2 popup = new easyQuestion2();
            DialogResult dialogresult = popup.ShowDialog();
        }
    }
}
