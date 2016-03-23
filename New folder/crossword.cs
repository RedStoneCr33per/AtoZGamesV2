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
                while((line = s.ReadLine()) != null)
                {
                    String [] l = line.Split('|');
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
                        formatCell(start_row + 1, start_col, word[j].ToString());
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
                if (board[e.ColumnIndex, e.RowIndex].Value.ToString().Equals(board[e.ColumnIndex, e.RowIndex].Value.ToString().ToUpper()))
                    board[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.DarkGreen;
                else
                    board[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Red;
            }
            catch { }
        }

        private void openPuzzleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Puzzle Files|*.pzl";
            if (ofd.ShowDialog().Equals(DialogResult.OK))
            {

            }
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
            int X = x;
            int Y = y;
            String direction = d;
            String number = n;
            String word = w;
            String clue = c;
        }
    }
}
