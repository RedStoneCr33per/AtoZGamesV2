using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sciencetific_Calc
{
    public partial class pingPong : Form
    {
        public int speed_left = 4;
        public int speed_top = 4;
        public int points = 0;

        public pingPong()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            racket.Top = playground.Bottom - (playground.Bottom / 10);

            gameover_1bl.Left = (playground.Width / 2) - (gameover_1bl.Width / 2);
            gameover_1bl.Top = (playground.Height / 2) - (gameover_1bl.Height / 2);
            gameover_1bl.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);

            ball.Left += speed_left;
            ball.Top += speed_top;

            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                points += 1;
                points_1bl.Text = points.ToString();

                Random r = new Random();
                playground.BackColor = Color.FromArgb(r.Next(150, 225), r.Next(150, 225), r.Next(150, 225));

            }

            if (ball.Left <= playground.Left)
            {
                speed_left = -speed_left;
            }
            if (ball.Right >= playground.Right)
            {
                speed_left = -speed_left;
            }
            if (ball.Top <= playground.Top)
            {
                speed_top = -speed_top;
            }

            if (ball.Bottom >= playground.Bottom)
            {
                timer1.Enabled = false;
                gameover_1bl.Visible = true;
            }
        }

        private void pingPong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
            if (e.KeyCode == Keys.F1)
            {
                ball.Top = 50;
                ball.Left = 50;
                speed_left = 4;
                speed_top = 4;
                points = 0;
                points_1bl.Text = "0";
                timer1.Enabled = true;
                gameover_1bl.Visible = false;
                playground.BackColor = Color.White;
            }
        }
    }
}
