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
    public partial class atozMazeLevel1 : Form
    {
        public atozMazeLevel1()
        {
            InitializeComponent();
        }

        private void Wall_MouseEnter(object sender, EventArgs e)
        {
            Point startingPoint = panel1.Location;
            startingPoint.Offset(5, 10);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void finishLevelBtn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            atozMazeLevel2 popup = new atozMazeLevel2();
            DialogResult dialogresult = popup.ShowDialog();
        }
    }
}
