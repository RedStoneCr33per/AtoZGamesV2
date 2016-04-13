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
using System.Diagnostics;

namespace Sciencetific_Calc
{
    public partial class crossword : Form
    {
        clues clue_window = new clues();
        List<id_cells> idc = new List<id_cells>();
        public String puzzle_file = Application.StartupPath + "\\Puzzles\\puzzle_1.pzl";

        public crossword()
        {
            buildWordList();
            InitializeComponent();
        }

        private void buildWordList()
        {
            String line = "";
            using (StreamReader s = new StreamReader(puzzle_file))
            {
                line = s.ReadLine();
                while ((line = s.ReadLine()) != null)
                {
                    String[] l = line.Split('|');
                    idc.Add(new id_cells(Int32.Parse(l[0]), Int32.Parse(l[1]), l[2], l[3], l[4], l[5]));
                    clue_window.clue_table.Rows.Add(new String[] { l[3], l[2], l[5] });
                }
            }
        }

        private void crossword_Load(object sender, EventArgs e)
        {
            InitializeBoard();

            clue_window.SetDesktopLocation(this.Location.X + this.Width + 1, this.Location.Y);
            clue_window.StartPosition = FormStartPosition.Manual;

            clue_window.Show();
            clue_window.clue_table.AutoResizeColumns();
        }

        private void InitializeBoard()
        {
            board.BackgroundColor = Color.Black;
            board.DefaultCellStyle.BackColor = Color.Black;

            for (int i = 0; i < 21; i++)
                board.Rows.Add();

            foreach (DataGridViewColumn c in board.Columns)
                c.Width = board.Width / board.Columns.Count;

            foreach (DataGridViewRow r in board.Rows)
                r.Height = board.Height / board.Rows.Count;

            for (int row = 0; row < board.Rows.Count; row++)
            {
                for (int col = 0; col < board.Columns.Count; col++)
                    board[col, row].ReadOnly = true;
            }

            foreach (id_cells i in idc)
            {
                int start_col = i.X;
                int start_row = i.Y;
                char[] word = i.word.ToCharArray();

                for (int j = 0; j < word.Length; j++)
                {
                    if (i.direction.ToUpper() == "ACROSS")
                        formatCell(start_row, start_col + j, word[j].ToString());
                    if (i.direction.ToUpper() == "DOWN")
                        formatCell(start_row + j, start_col, word[j].ToString());
                }
            }
        }

        private void formatCell(int row, int col, String letter)
        {
            DataGridViewCell c = board[col, row];
            c.Style.BackColor = Color.White;
            c.ReadOnly = false;
            c.Style.SelectionBackColor = Color.Cyan;
            c.Tag = letter;
        }

        private void crossword_LocationChanged(object sender, EventArgs e)
        {
            clue_window.SetDesktopLocation(this.Location.X + this.Width + 1, this.Location.Y);
        }

        private void board_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                board[e.ColumnIndex, e.RowIndex].Value = board[e.ColumnIndex, e.RowIndex].Value.ToString().ToUpper();
            }
            catch { }

            try
            {
                if (board[e.ColumnIndex, e.RowIndex].Value.ToString().Length > 1) board[e.ColumnIndex, e.RowIndex].Value = board[e.ColumnIndex, e.RowIndex].Value.ToString().Substring(0, 1);
            }
            catch { }

            try
            {
                if (board[e.ColumnIndex, e.RowIndex].Value.ToString().ToUpper().Equals(board[e.ColumnIndex, e.RowIndex].Tag.ToString().ToUpper()))
                    board[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.DarkGreen;
                else
                    board[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Red;
            }
            catch { }
        }

        private void board_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            String number = "";

            if (idc.Any(c => (number = c.number) != "" && c.X == e.ColumnIndex && c.Y == e.RowIndex))
            {
                Rectangle r = new Rectangle(e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Width, e.CellBounds.Height);
                e.Graphics.FillRectangle(Brushes.White, r);
                Font f = new Font(e.CellStyle.Font.FontFamily, 7);
                e.Graphics.DrawString(number, f, Brushes.Black, r);
                e.PaintContent(e.ClipBounds);
                e.Handled = true;
            }
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

        private void openPuzzleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Puzzle | .pzl";
            if (ofd.ShowDialog().Equals(DialogResult.OK))
            {
                puzzle_file = ofd.FileName;

                board.Rows.Clear();
                clue_window.clue_table.Rows.Clear();
                idc.Clear();

                buildWordList();
                InitializeBoard();
            }
        }

        private void exitToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public class id_cells
    {
        public int X;
        public int Y;
        public String direction;
        public String number;
        public String word;
        public String clue;

        public id_cells(int x, int y, String d, String n, String w, String c)
        {
            this.X = x;
            this.Y = y;
            this.direction = d;
            this.number = n;
            this.word = w;
            this.clue = c;
        }
    }
}
