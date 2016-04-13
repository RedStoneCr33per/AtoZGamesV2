using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sciencetific_Calc
{
    public partial class favorites : Form
    {
        public favorites()
        {
            InitializeComponent();
        }

        public void WriteFavorites()
        {
            StreamReader favoritesFile = new StreamReader("favorites.txt");

            string line;

            while (!favoritesFile.EndOfStream)
            {
                line = favoritesFile.ReadLine();
                listBox1.Items.Add(line);
            }
            favoritesFile.Close();
        }
    }
}
