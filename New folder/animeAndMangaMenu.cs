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
    public partial class animeAndMangaMenu : Form
    {
        public animeAndMangaMenu()
        {
            InitializeComponent();
        }

        private void fairyTail_Click(object sender, EventArgs e)
        {
            this.Hide();
            fairyTailMenu popup = new fairyTailMenu();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void swordArtOnlineBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            swordArtOnlineMenu popup = new swordArtOnlineMenu();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void bleachMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            bleachMenu popup = new bleachMenu();
            DialogResult dialogresult = popup.ShowDialog();
        }
    }
}
