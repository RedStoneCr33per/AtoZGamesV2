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
    public partial class paint : Form
    {
        Graphics g;
        Pen p = new Pen(Color.Black, 1);
        Point sp = new Point(0, 0);
        Point ep = new Point(0, 0);
        int k = 0;

        public paint()
        {
            InitializeComponent();
        }

        private void red_Click(object sender, EventArgs e)
        {
            p.Color = red.BackColor;
            defualt.BackColor = red.BackColor;
        }

        private void green_Click(object sender, EventArgs e)
        {
            p.Color = green.BackColor;
            defualt.BackColor = green.BackColor;
        }

        private void blue_Click(object sender, EventArgs e)
        {
            p.Color = blue.BackColor;
            defualt.BackColor = blue.BackColor;
        }

        private void paint_MouseDown(object sender, MouseEventArgs e)
        {
            sp = e.Location;
            if (e.Button == MouseButtons.Left)
                k = 1;
        }

        private void paint_MouseUp(object sender, MouseEventArgs e)
        {
            k = 0;
        }

        private void paint_MouseMove(object sender, MouseEventArgs e)
        {
            if (k == 1)
            {
                ep = e.Location;
                g = this.CreateGraphics();
                g.DrawLine(p, sp, ep);
            }
            sp = ep;
        }

        private void orange_Click(object sender, EventArgs e)
        {
            p.Color = orange.BackColor;
            defualt.BackColor = orange.BackColor;
        }

        private void yellow_Click(object sender, EventArgs e)
        {
            p.Color = yellow.BackColor;
            defualt.BackColor = yellow.BackColor;
        }

        private void purple_Click(object sender, EventArgs e)
        {
            p.Color = purple.BackColor;
            defualt.BackColor = purple.BackColor;
        }

        private void pink_Click(object sender, EventArgs e)
        {
            p.Color = pink.BackColor;
            defualt.BackColor = pink.BackColor;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void white_Click(object sender, EventArgs e)
        {
            p.Color = white.BackColor;
            defualt.BackColor = white.BackColor;
        }

        private void black_Click(object sender, EventArgs e)
        {
            p.Color = black.BackColor;
            defualt.BackColor = black.BackColor;
        }

        private void silver_Click(object sender, EventArgs e)
        {
            p.Color = silver.BackColor;
            defualt.BackColor = silver.BackColor;
        }

        private void tan_Click(object sender, EventArgs e)
        {
            p.Color = tan.BackColor;
            defualt.BackColor = tan.BackColor;
        }

        private void skyBlue_Click(object sender, EventArgs e)
        {
            p.Color = skyBlue.BackColor;
            defualt.BackColor = skyBlue.BackColor;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            g.Clear(panel1.BackColor);
        }
    }
}
