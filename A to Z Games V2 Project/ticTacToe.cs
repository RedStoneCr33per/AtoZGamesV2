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
    public partial class ticTacToe : Form
    {
        bool turn = true;
        int turn_count = 0;
        static String player1, player2;

        public ticTacToe()
        {
            InitializeComponent();
        }

        public static void setPlayerNames(String n1, String n2)
        {
            player1 = n1;
            player2 = n2;
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkForWinner();
        }

        private void checkForWinner()
        {
            bool there_is_a_winner = false;

            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                there_is_a_winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                there_is_a_winner = true;

            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                there_is_a_winner = true;

            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                there_is_a_winner = true;

            if (there_is_a_winner)
            {
                dissableButtons();

                String winner = "";
                if (turn)
                {
                    winner = player2;
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
                }
                else
                {
                    winner = player1;
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                }

                MessageBox.Show(winner + " wins!", "Yay!");
                
            }
            else
            {
                if (turn_count == 9)
                {
                    MessageBox.Show("Draw!", "Bummer!");
                }
            }
        }

        private void dissableButtons()
        {
            try
            {
                foreach (Component c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            
                foreach (Component c in Controls)
                {
                    try
                    {
                        Button b = (Button)c;
                        b.Enabled = false;
                    }
                    catch { }
                }
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";
            }
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void resetWinCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            o_win_count.Text = "0";
            x_win_count.Text = "0";
            draw_count.Text = "0";
        }

        private void ticTacToe_Load(object sender, EventArgs e)
        {
            names f2 = new names();
            f2.ShowDialog();
            label1.Text = player1;
            label3.Text = player2;
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
