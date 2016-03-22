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
    public partial class hQuestion1 : Form
    {
        public hQuestion1()
        {
            InitializeComponent();
        }

        private void hQuestion1_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer("Music/fairy_tail_theme.mp3");
        }
    }
}
