using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sciencetific_Calc
{
    public partial class chatSetName : Form
    {
        public chatSetName()
        {
            InitializeComponent();
        }

        private void setChatName_Click(object sender, EventArgs e)
        {
            Chat_Client_APP.setPlayerNames(chatName.Text);
            this.Close();
        }
    }
}
