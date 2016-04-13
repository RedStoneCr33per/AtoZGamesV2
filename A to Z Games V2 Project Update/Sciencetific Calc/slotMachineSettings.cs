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
    public partial class slotMachineSettings : Form
    {
        public slotMachineSettings()
        {
            InitializeComponent();
        }

        slotMachine sM = new slotMachine();

        private void musicOnBtn_Click(object sender, EventArgs e)
        {
            sM.music = true;
        }

        private void musicOffBtn_Click(object sender, EventArgs e)
        {
            sM.music = false;
        }
    }
}
