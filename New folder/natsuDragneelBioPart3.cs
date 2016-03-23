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
    public partial class natsuDragneelBioPart3 : Form
    {
        public natsuDragneelBioPart3()
        {
            InitializeComponent();
        }

        private void natsuNextBtn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            natsuDragneelBioPart3 popup = new natsuDragneelBioPart3();
            DialogResult dialogresult = popup.ShowDialog();
        }
    }
}
