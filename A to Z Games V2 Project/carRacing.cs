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
    public partial class carRacing : Form
    {
        #region Fields

        private int _row;
        private int _col;

        private int _startX;
        private int _startY;
        private int _carX;
        private int _carY;

        private Random _random;
        private int _myCarPosition;

        private int _elementSize;
        private int[,] _gameMatrix;


        #endregion

        public carRacing()
        {
            InitializeComponent();

            InitializeGame();
        }

        private void InitializeGame()
        {
            _row = 16;
            _col = 6;
            _startX = 50;
            _startY = 50;
            _elementSize = 15;

            _carX = _carY = 0;
            _gameMatrix = new int[_row, _col];
            ResetGameBoard();

            _random = new Random();
            _myCarPosition = 0;
            DrawACar(12, _myCarPosition, 2);

        }

        private void carRacing_Paint(object sender, PaintEventArgs e)
        {
            DrawGameBoard(e.Graphics);
        }

        private void DrawGameBoard(Graphics g)
        {
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _col; j++)
                {
                    g.DrawRectangle(new Pen(Brushes.Brown), _startX + j * _elementSize,
                        _startY + i * _elementSize, _elementSize, _elementSize);
                    if (_gameMatrix[i, j] == 1)
                    {
                        g.FillRectangle(Brushes.DarkCyan, _startX + j * _elementSize,
                        _startY + i * _elementSize, _elementSize, _elementSize);
                    }
                    if (_gameMatrix[i, j] == 2)
                    {
                        g.FillRectangle(Brushes.DeepSkyBlue, _startX + j * _elementSize,
                        _startY + i * _elementSize, _elementSize, _elementSize);
                    }
                }
            }
        }

        #region Functions

        private void ResetGameBoard()
        {
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _col; j++)
                {
                    _gameMatrix[i, j] = 0;
                }
            }
        }

        private void DrawACar(int x, int y, int value)
        {
            DrawAPoint(x, y + 1, value);
            DrawAPoint(x + 1, y + 1, value);
            DrawAPoint(x + 2, y + 1, value);
            DrawAPoint(x + 3, y + 1, value);
            DrawAPoint(x + 1, y, value);
            DrawAPoint(x + 1, y + 2, value);
            DrawAPoint(x + 3, y, value);
            DrawAPoint(x + 3, y + 2, value);
        }

        private void DrawAPoint(int x, int y, int value)
        {
            if (x < _row && x >= 0 && y < _col && y >= 0)
            {
                _gameMatrix[x, y] = value;
            }
        }

        #endregion

        private void tmrRacing_Tick(object sender, EventArgs e)
        {
            ResetGameBoard();
            DrawACar(12, _myCarPosition, 2);
            DrawACar(_carX, _carY, 1);
            Invalidate();

            _carX++;
            if (_carX == _row)
            {
                _carX = 0;
                _carY = _random.Next() % 2 == 0 ? 0 : 3;
            }

            CheckGame();
        }

        private void CheckGame()
        {
            if (_carX + 3 > 12 && _carY == _myCarPosition)
            {
                tmrRacing.Enabled = false;
            }
        }

        private void carRacing_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && _myCarPosition == 3)
            {
                _myCarPosition = 0;
            }
            else if (e.KeyCode == Keys.Right && _myCarPosition == 0)
            {
                _myCarPosition = 3;
            }
        }

        private void carRacing_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            _carX = _carY = 0;
            _myCarPosition = 0;
            tmrRacing.Enabled = true;
        }

        private void regularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 popup = new Form1();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void sciencetificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 popup = new Form2();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            paint popup = new paint();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void snakeGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Snake popup = new Snake();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void internetTvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Internet_Tv popup = new Internet_Tv();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void digitalClockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DigitalClock popup = new DigitalClock();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void analongClockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnalogClock popup = new AnalogClock();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void pDFReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mypdf popup = new Mypdf();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void audioFileReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Audio_File_Player popup = new Audio_File_Player();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void getIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Get_IP_Address popup = new Get_IP_Address();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void mP3PlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MP3_Player popup = new MP3_Player();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mynotepad popup = new Mynotepad();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void chatClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chat_Client_APP popup = new Chat_Client_APP();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void singlePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DiceGame popup = new DiceGame();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void speakToTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Speaker popup = new Speaker();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void flappyBirdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Flappy_Bird popup = new Flappy_Bird();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void keyboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            onscreenKeyboard popup = new onscreenKeyboard();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void animeMangaMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            animeAndMangaMenu popup = new animeAndMangaMenu();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void twoPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            diceGameTwoPlayer popup = new diceGameTwoPlayer();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void crosswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            crossword popup = new crossword();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void ticTacToeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ticTacToe popup = new ticTacToe();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void pingPongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            pingPong popup = new pingPong();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void aToZGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("A to Z Quiz.exe");
        }

        private void carRacingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            carRacing popup = new carRacing();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by: Adam Alexander and Zachary Krause");
        }
    }
}