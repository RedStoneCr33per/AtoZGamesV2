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
    public partial class Snake : Form
    {
        private List<Circle> nake = new List<Circle>();
        private Circle food = new Circle();

        public Snake()
        {
            InitializeComponent();

            //Set settings to default
            new Settings();

            //Set game speed and start timer
            gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();

            //Start New game
            StartGame();
        }

        private void StartGame()
        {
            lblGameOver.Visible = false;

            //Set settings to default
            new Settings();

            //Create new player object
            nake.Clear();
            Circle head = new Circle { X = 10, Y = 5 };
            nake.Add(head);


            lblScore.Text = Settings.Score.ToString();
            GenerateFood();
        }

        private void GenerateFood()
        {
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;

            Random random = new Random();
            food = new Circle { X = random.Next(0, maxXPos), Y = random.Next(0, maxYPos) };
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            //Check for Game Over
            if (Settings.GameOver)
            {
                //Check if Enter is pressed
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

            if (!Settings.GameOver)
            {
                //Set colour of snake

                //Draw snake
                for (int i = 0; i < nake.Count; i++)
                {
                    Brush nakeColor;
                    if (i == 0)
                        nakeColor = Brushes.Black;     //Draw head
                    else
                        nakeColor = Brushes.Green;    //Rest of body

                    //Draw snake
                    canvas.FillEllipse(nakeColor,
                        new Rectangle(nake[i].X * Settings.Width,
                                      nake[i].Y * Settings.Height,
                                      Settings.Width, Settings.Height));


                    //Draw Food
                    canvas.FillEllipse(Brushes.Red,
                        new Rectangle(food.X * Settings.Width,
                             food.Y * Settings.Height, Settings.Width, Settings.Height));

                }
            }
            else
            {
                string gameOver = "Game over \nYour final score is: " + Settings.Score + "\nPress Enter to try again";
                lblGameOver.Text = gameOver;
                lblGameOver.Visible = true;
            }
        }

        private void MovePlayer()
          {
              for (int i = nake.Count - 1; i >= 0; i--)
              {
                  //Move head
                  if (i == 0)
                  {
                      switch (Settings.direction)
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


                      //Get maximum X and Y Pos
                      int maxXPos = pbCanvas.Size.Width / Settings.Width;
                      int maxYPos = pbCanvas.Size.Height / Settings.Height;

                      //Detect collission with game borders.
                      if (nake[i].X < 0 || nake[i].Y < 0
                          || nake[i].X >= maxXPos || nake[i].Y >= maxYPos)
                      {
                          Die();
                      }


                      //Detect collission with body
                      for (int j = 1; j < nake.Count; j++)
                      {
                          if (nake[i].X == nake[j].X &&
                             nake[i].Y == nake[j].Y)
                          {
                              Die();
                          }
                      }

                      //Detect collision with food piece
                      if (nake[0].X == food.X && nake[0].Y == food.Y)
                      {
                          Eat();
                      }

                  }
                  else
                  {
                      //Move body
                      nake[i].X = nake[i - 1].X;
                      nake[i].Y = nake[i - 1].Y;
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
               Settings.GameOver = true;
           }

           private void Eat()
           {
               //Add circle to body
               Circle circle = new Circle
               {
                   X = nake[nake.Count - 1].X,
                   Y = nake[nake.Count - 1].Y
               };
               nake.Add(circle);

               //Update Score
               Settings.Score += Settings.Points;
               lblScore.Text = Settings.Score.ToString();

               GenerateFood();
           }
        }
    }
