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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by: Adam Alexander and Zachary Krause");
        }
    }
}
