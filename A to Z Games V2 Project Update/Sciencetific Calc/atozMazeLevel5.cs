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
    public partial class atozMazeLevel5 : Form
    {
        public atozMazeLevel5()
        {
            InitializeComponent();
        }

        private void Wall_MouseEnter(object sender, EventArgs e)
        {
            Point startingPoint = panel1.Location;
            startingPoint.Offset(5, 10);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void finishLevelBtn5_Click(object sender, EventArgs e)
        {

        }
    }
}
