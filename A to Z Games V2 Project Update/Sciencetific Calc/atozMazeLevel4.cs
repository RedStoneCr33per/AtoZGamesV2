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
    public partial class atozMazeLevel4 : Form
    {
        public atozMazeLevel4()
        {
            InitializeComponent();
        }

        private void finishBtn4_Click(object sender, EventArgs e)
        {
            this.Hide();
            atozMazeLevel5 popup = new atozMazeLevel5();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void Wall_MouseEnter(object sender, EventArgs e)
        {
            Point startingPoint = panel1.Location;
            startingPoint.Offset(5, 10);
            Cursor.Position = PointToScreen(startingPoint);
        }
    }
}
