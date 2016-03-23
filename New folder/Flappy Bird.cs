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
using System.Media;

namespace Sciencetific_Calc
{
    public partial class Flappy_Bird : Form
    {
        public Flappy_Bird()
        {
            InitializeComponent();
        }

        List<int> Pipe1 = new List<int>();
        List<int> Pipe2 = new List<int>();
        int PipeWidth = 55;
        int PipeDifferentX = 140;
        int PipeDifferentY = 150;
        bool Start = true;
        bool running;
        int step = 5;
        int originalsX, originalsY;
        bool ResetPipes = false;
        int points;
        bool inPipes = false;
        int score;
        int scoreDifferent;

        private void Die()
        {
            running = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            button1.Visible = true;
            button1.Enabled = true;
            ReadAndShowScore();
            points = 0;
            pictureBox1.Location = new Point(originalsX, originalsY);
            ResetPipes = true;
            Pipe1.Clear();
        }

        private void ReadAndShowScore()
        {
            using (StreamReader reader = new StreamReader("score ini"))
            {
                score = int.Parse(reader.ReadToEnd());
                reader.Close();
                if(int.Parse(label1.Text) == 0 | int.Parse(label1.Text) > 0)
                {
                    scoreDifferent = score - int.Parse(label1.Text) + 1;
                }
                if(score < int.Parse(label1.Text))
                {
                    MessageBox.Show(string.Format("Congratulations, you made a higher score than {0}. The new score is{1}", score, label1.Text), "Flappy Bird", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    using (StreamReader writer = new StreamReader("score.ini"))
                    {
                        //writer.Write(label1.Text); 
                        writer.Close();
                    }
                }
                if(score > int.Parse(label1.Text))
                {
                    MessageBox.Show(string.Format("Do you need {0} To overcome score maximum", score, label1.Text), "Flappy Bird");
                }
            }
        }

        private void StartGame()
        {
            ResetPipes = false;
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            Random random = new Random();
            int num = random.Next(40, (this.Height - PipeDifferentY));
            int num1 = num + this.PipeDifferentY;
            Pipe1.Clear();
            Pipe1.Add(this.Width);
            Pipe1.Add(num);
            Pipe1.Add(this.Width);
            Pipe1.Add(num1);

            num = random.Next(40, (this.Height - PipeDifferentY));
            num1 = num + this.PipeDifferentY;
            Pipe2.Clear();
            Pipe1.Add(this.Width);
            Pipe1.Add(num);
            Pipe1.Add(this.Width);
            Pipe1.Add(num1);
        }

        private void Flappy_Bird_Load(object sender, EventArgs e)
        {
            originalsX = pictureBox1.Location.X;
            originalsY = pictureBox1.Location.Y;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(Pipe1[0] + PipeWidth <=  0 | Start == true)
            {
                Random rnd = new Random();
                int px = this.Width;
                int py = rnd.Next(40, (this.Height - PipeDifferentY));
                int p2x = px;
                int p2y = py + PipeDifferentY;
                Pipe1.Clear();
                Pipe1.Add(px);
                Pipe1.Add(py);
                Pipe1.Add(p2x);
                Pipe1.Add(p2y);
            }
            else
            {
                Pipe1[0] = Pipe1[0] - 2;
                Pipe1[2] = Pipe1[2] - 2;
            }
            if (Pipe1[0] + PipeWidth <= 0 | Start == true)
            {
                Random rnd = new Random();
                int px = this.Width;
                int py = rnd.Next(40, (this.Height - PipeDifferentY));
                int p2x = px;
                int p2y = py + PipeDifferentY;
                Pipe1.Clear();
                Pipe1.Add(px);
                Pipe1.Add(py);
                Pipe1.Add(p2x);
                Pipe1.Add(p2y);
            }
            else
            {
                Pipe1[0] = Pipe1[0] - 2;
                Pipe1[2] = Pipe1[2] - 2;
            }
            if(Start == true)
            {
                Start = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void Flappy_Bird_Paint(object sender, PaintEventArgs e)
        {
            if(!ResetPipes && Pipe1.Any() && Pipe2.Any())
            {
                e.Graphics.FillRectangle(Brushes.DarkGreen, new Rectangle(Pipe1[0], 0, PipeWidth, Pipe1[1]));
                e.Graphics.FillRectangle(Brushes.DarkGreen, new Rectangle(Pipe1[0] - 10, Pipe1[3] - PipeDifferentY, 75, 15));

                e.Graphics.FillRectangle(Brushes.DarkGreen, new Rectangle(Pipe1[2], 0, PipeWidth, Pipe1[3]));
                e.Graphics.FillRectangle(Brushes.DarkGreen, new Rectangle(Pipe1[2] - 10, Pipe1[3], 75, 15));

                e.Graphics.FillRectangle(Brushes.DarkGreen, new Rectangle(Pipe2[0], 0, PipeWidth, Pipe2[1]));
                e.Graphics.FillRectangle(Brushes.DarkGreen, new Rectangle(Pipe2[0] - 10, Pipe2[3] - PipeDifferentY, 75, 15));

                e.Graphics.FillRectangle(Brushes.DarkGreen, new Rectangle(Pipe2[2], 0, PipeWidth, Pipe2[3]));
                e.Graphics.FillRectangle(Brushes.DarkGreen, new Rectangle(Pipe2[2] - 10, Pipe2[3], 75, 15));
            }
        }

        private void CheckForPoint()
        {
            Rectangle rec = pictureBox1.Bounds;
            Rectangle rec1 = new Rectangle(Pipe1[2] + 20, Pipe1[3] - PipeDifferentY, 15, PipeDifferentY);
            Rectangle rec2 = new Rectangle(Pipe1[2] + 20, Pipe1[3] - PipeDifferentY, 15, PipeDifferentY);
            Rectangle intersect1 = Rectangle.Intersect(rec, rec1);
            Rectangle intersect2 = Rectangle.Intersect(rec, rec1);
            if(!ResetPipes | Start)
            {
                if(intersect1 != Rectangle.Empty | intersect2 != Rectangle.Empty)
                {
                    if(!inPipes)
                    {
                        points++;
                    }
                }
            }
        }

        private void CheckForCollision()
        {
            Rectangle rec = pictureBox1.Bounds;
            Rectangle rec1 = new Rectangle(Pipe1[0], 0, PipeWidth, Pipe1[1]);
            Rectangle rec2 = new Rectangle(Pipe1[2], Pipe1[3], PipeWidth, this.Height - Pipe1[3]);
            Rectangle rec3 = new Rectangle(Pipe2[0], 0, PipeWidth, Pipe2[1]);
            Rectangle rec4 = new Rectangle(Pipe2[2], Pipe2[3], PipeWidth, this.Height - Pipe2[3]);
            Rectangle intersect1 = Rectangle.Intersect(rec, rec1);
            Rectangle intersect2 = Rectangle.Intersect(rec, rec2);
            Rectangle intersect3 = Rectangle.Intersect(rec, rec3);
            Rectangle intersect4 = Rectangle.Intersect(rec, rec4);
            if(!ResetPipes | Start)
            {
                if(intersect1 != Rectangle.Empty | intersect2 != Rectangle.Empty | intersect3 != Rectangle.Empty | intersect4 != Rectangle.Empty)
                {
                    Die();
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + step);
            if(pictureBox1.Location.Y < 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, 0);
            }
            if (pictureBox1.Location.Y + pictureBox1.Height < this.ClientSize.Height)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, this.ClientSize.Height - pictureBox1.Height);
            }
            CheckForCollision();
            if(running)
            {
                CheckForPoint();
            }
            label1.Text = Convert.ToString(points);
        }

        private void Flappy_Bird_KeyUp(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Space:
                    step = 5;
                    //pictureBox1.Image = Resources.flappyBird;
                    break;
            }
        }

        private void Flappy_Bird_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    step = -5;
                    //pictureBox1.Image = Resources.bird_down;
                    break;
            }
        }
    }
}
