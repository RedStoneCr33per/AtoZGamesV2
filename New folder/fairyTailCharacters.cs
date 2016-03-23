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
    public partial class fairyTailCharacters : Form
    {
        public fairyTailCharacters()
        {
            InitializeComponent();
        }

        private void natsuDragneelBio_Click(object sender, EventArgs e)
        {
            this.Hide();
            natsuDragneelBio popup = new natsuDragneelBio();
            DialogResult dialogresult = popup.ShowDialog();
        }
    }
}
