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
    public partial class onscreenKeyboard : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams; 
                param.ExStyle = 0x08000000;
                return param;
            }
        }

        public onscreenKeyboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
              SendKeys.Send("Q");
            }
            else
            {
                SendKeys.Send("q");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("W");
            }
            else
            {
                SendKeys.Send("w");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("E");
            }
            else
            {
                SendKeys.Send("e");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("R");
            }
            else
            {
                SendKeys.Send("r");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("T");
            }
            else
            {
                SendKeys.Send("t");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("Y");
            }
            else
            {
                SendKeys.Send("y");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("U");
            }
            else
            {
                SendKeys.Send("u");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("I");
            }
            else
            {
                SendKeys.Send("i");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("O");
            }
            else
            {
                SendKeys.Send("o");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("P");
            }
            else
            {
                SendKeys.Send("p");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("{");
            }
            else
            {
                SendKeys.Send("[");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("}");
            }
            else
            {
                SendKeys.Send("]");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("|");
            }
            else
            {
                SendKeys.Send("#");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("A");
            }
            else
            {
                SendKeys.Send("a");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("S");
            }
            else
            {
                SendKeys.Send("s");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("D");
            }
            else
            {
                SendKeys.Send("d");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("F");
            }
            else
            {
                SendKeys.Send("f");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("G");
            }
            else
            {
                SendKeys.Send("g");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("H");
            }
            else
            {
                SendKeys.Send("h");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("J");
            }
            else
            {
                SendKeys.Send("j");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("K");
            }
            else
            {
                SendKeys.Send("k");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("L");
            }
            else
            {
                SendKeys.Send("l");
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send(":");
            }
            else
            {
                SendKeys.Send(";");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("");
            }
            else
            {
                SendKeys.Send("'");
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("Z");
            }
            else
            {
                SendKeys.Send("z");
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("X");
            }
            else
            {
                SendKeys.Send("x");
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("C");
            }
            else
            {
                SendKeys.Send("c");
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("V");
            }
            else
            {
                SendKeys.Send("v");
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("B");
            }
            else
            {
                SendKeys.Send("b");
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("N");
            }
            else
            {
                SendKeys.Send("n");
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("M");
            }
            else
            {
                SendKeys.Send("m");
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("<");
            }
            else
            {
                SendKeys.Send(",");
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send(">");
            }
            else
            {
                SendKeys.Send(".");
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("?");
            }
            else
            {
                SendKeys.Send("/");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("~");
            }
            else
            {
                SendKeys.Send("`");
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("!");
            }
            else
            {
                SendKeys.Send("1");
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("@");
            }
            else
            {
                SendKeys.Send("2");
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("#");
            }
            else
            {
                SendKeys.Send("3");
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("$");
            }
            else
            {
                SendKeys.Send("4");
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("%");
            }
            else
            {
                SendKeys.Send("5");
            }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("^");
            }
            else
            {
                SendKeys.Send("6");
            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("&");
            }
            else
            {
                SendKeys.Send("7");
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("*");
            }
            else
            {
                SendKeys.Send("8");
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("(");
            }
            else
            {
                SendKeys.Send("9");
            }
        }

        private void button64_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send(")");
            }
            else
            {
                SendKeys.Send("0");
            }
        }

        private void button65_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("_");
            }
            else
            {
                SendKeys.Send("-");
            }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("+");
            }
            else
            {
                SendKeys.Send("=");
            }
        }

        private void button79_Click(object sender, EventArgs e)
        {

        }

        private void button80_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{f1}");
        }

        private void button81_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{f2}");
        }

        private void button82_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{f3}");
        }

        private void button83_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{f4}");
        }

        private void button84_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{f5}");
        }

        private void button85_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{f6}");
        }

        private void button86_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{f7}");
        }

        private void button87_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{f8}");
        }

        private void button88_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{f9}");
        }

        private void button89_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{f10}");
        }

        private void button90_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{f11}");
        }

        private void button91_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{f12}");
        }

        private void button92_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PRTSC}");
        }

        private void button67_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");
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

        private void button93_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DELETE}");
        }

        private void button94_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{HOME}");
        }

        private void button95_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{END}");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            int space = 0;
            space++;

            if (space == 1)
            {
                SendKeys.Send(" ");
            }
        }
    }
}
