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
    public partial class Snake : Form
    {
        private List<Circle>nake = new List<Circle>();
        private Circle food = new Circle();

        public Snake()
        {
            InitializeComponent();

            new Settings();

            gameTimer.Interval = 1000/Settings.Speed;
            //gameTimer.Tick += UpdateScreen();
            gameTimer.Start();

            StartGame();
        }

        private void StartGame()
        {
            lblGameOver.Visible = false;

            new Settings();

            nake.Clear();
            Circle head = new Circle();
            head.X = 10;
            head.Y = 5;
            nake.Add(head);

            lblScore.Text = Settings.Score.ToString();
            GenerateFood();
        }

        private void GenerateFood()
        {
            int maxXPros = pbCanvas.Size.Width / Settings.Width;
            int maxYPros = pbCanvas.Size.Height / Settings.Height;

            Random random = new Random();
            food = new Circle();
            food.X = random.Next(0, maxXPros);
            food.Y = random.Next(0, maxYPros);
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            if (Settings.GameOver == true)
            {
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                    Settings.direction = Direction.Right;
                else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                    Settings.direction = Direction.Left;
                else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                    Settings.direction = Direction.Up;
                else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                    Settings.direction = Direction.Down;

                MovePlayer();
            }

            pbCanvas.Invalidate();
        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (Settings.GameOver != false)
            {
                Brush nakeColour;

                for (int i = 0; i < nake.Count; i++)
                {
                    if (i == 0)
                        nakeColour = Brushes.Black;
                    else
                        nakeColour = Brushes.Green;

                    canvas.FillEllipse(nakeColour,
                        new Rectangle(nake[i].X * Settings.Width,
                                        nake[i].Y * Settings.Height,
                                        Settings.Width, Settings.Height));

                    canvas.FillEllipse(Brushes.Red,
                        new Rectangle(food.X * Settings.Width,
                            food.Y * Settings.Height, Settings.Width, Settings.Height));
                }
            }
            else
            {
                String gameOver = "Game Over \nYour final score is: " + Settings.Score + "Press Enter to try again";
                lblGameOver.Text = gameOver;
                lblGameOver.Visible = true;
            }
        }

        private void MovePlayer()
          {
             for(int i = nake.Count -1; i>0; i--)
              {
                  if(i==0)
                  {
                      switch(Settings.direction)
                      {
                          case Direction.Right:
                             nake[i].X++;
                             break;
                          case Direction.Left:
                              nake[i].X--;
                              break;
                          case Direction.Up:
                              nake[i].Y--;
                              break;
                          case Direction.Down:
                              nake[i].Y++;
                              break;
                      }
                      int maxXPros = pbCanvas.Size.Width/Settings.Width;
                      int maxYPros = pbCanvas.Size.Height/Settings.Height;

                      if(nake[i].X<0||nake[i].Y<0
                          ||nake[i].X>=maxXPros||nake[i].Y>=maxYPros)
                      {
                          Die();
                      }

                      for(int j = 1; j<nake.Count; j++)
                      {
                          if(nake[i].X==nake[j].X&&
                              nake[i].Y==nake[j].X)
                          {
                              Die();
                          }
                      }
                      if(nake[0].X==food.X&&nake[0].Y==food.Y)
                      {
                          Eat();
                      }
                  }
                  else
                  {
                      nake[i].X=nake[i-1].X;
                      nake[i].Y=nake[i-1].Y;
                  }
                    
               }
           }

           private void Snake_KeyUp(object sender, KeyEventArgs e)
           {
               Input.ChangeState(e.KeyCode, false);
           }

           private void Snake_KeyDown(object sender, KeyEventArgs e)
           {
               Input.ChangeState(e.KeyCode, true);
           }

           private void Die()
           {
               Settings.GameOver=true;
           }

           private void Eat()
           {
               Circle food = new Circle();
               food.X=nake[nake.Count -1].X;
               food.Y=nake[nake.Count -1].Y;

               nake.Add(food);

               Settings.Score += Settings.Points;
               lblScore.Text = Settings.Score.ToString();
           }
        }
    }
