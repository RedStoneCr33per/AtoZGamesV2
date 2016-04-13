using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.IO;

namespace Sciencetific_Calc
{
    public partial class slotMachine : Form
    {
        Image[] slotImages;
        Random rand = new Random();
        int j = 0;
        int cash = 500;
        int bet = 0;
        int exp = 0;

        private SoundPlayer Player;
        private SoundPlayer lvlPlayer;

        Random expRand = new Random();

        int b = 0;

        public bool music = true;

        public slotMachine()
        {
            InitializeComponent();

            Player = new SoundPlayer("..\\..\\Resources\\Fairy_Tail_Opening_3.wav");
        }

        private void slotMachine_Load(object sender, EventArgs e)
        {
            slotImages = new Image[4];
            slotImages[0] = Properties.Resources.chibi_erza_slot;
            slotImages[1] = Properties.Resources.chibi_mirajane_slot;
            slotImages[2] = Properties.Resources.chibi_lucy_slot;
            slotImages[3] = Properties.Resources.fairy_tail_symbol;

            this.Size = new Size(925, 554);

            playersCash.Text = "$500";

            bonus();
        }

        public void DrawImage(int Picture, PictureBox slot)
        {
            slot.Image = slotImages[Picture];
        }

        private void spinBtn_Click(object sender, EventArgs e)
        {
            if (bet1Amount == true || bet2Amount == true || bet3Amount == true || bet4Amount == true || bet5Amount == true || bet6Amount == true)
            {
                spinBtn.Enabled = false;

                bonus();

                if (music == true)
                {
                    Player.Play();
                }

                cash = cash - bet;

                int i = 50;

                while (i > 0)
                {
                    b1.Image = slotImages[j % 3];
                    b1.Invalidate();
                    b1.Update();
                    b2.Image = slotImages[(j + 1) % 3];
                    b2.Invalidate();
                    b2.Update();
                    b3.Image = slotImages[(j + 2) % 3];
                    b3.Invalidate();
                    b3.Update();
                    Thread.Sleep(100);
                    i--;
                    j++;
                }

                int slot1Final = rand.Next(0, 3);
                int slot2Final = rand.Next(0, 3);
                int slot3Final = rand.Next(0, 3);

                i = 0;
                bool slot1Done = false;
                bool slot2Done = false;
                bool slot3Done = false;
                while (i < 3)
                {
                    if (!slot1Done)
                    {
                        b1.Image = slotImages[j % 3];
                        b1.Invalidate();
                        b1.Update();
                        if ((j % 3) == slot1Final)
                        {
                            slot1Done = true;
                        }
                    }
                    if (!slot2Done)
                    {
                        b2.Image = slotImages[(j + 1) % 3];
                        b2.Invalidate();
                        b2.Update();
                        if (((j) % 3) == slot2Final)
                        {
                            slot2Done = true;
                        }
                    }
                    if (!slot3Done)
                    {
                        b3.Image = slotImages[(j + 2) % 3];
                        b3.Invalidate();
                        b3.Update();
                        if (((j) % 3) == slot3Final)
                        {
                            slot3Done = true;
                        }
                    }
                    Thread.Sleep(100);
                    i++;
                    j++;
                }

                Player.Stop();
                checkForWinner();
                levelGenerator();
                playersCash.Text = "$" + cash.ToString();
                spinBtn.Enabled = true;
            }
        }

        public void checkForWinner()
        {
            int exp1Earned = rand.Next(1, 16);
            int exp2Earned = rand.Next(15, 26);

            if (b1.Image == slotImages[0] && b2.Image == slotImages[0] || b2.Image == slotImages[0] && b3.Image == slotImages[0] || b1.Image == slotImages[0] && b3.Image == slotImages[0])
            {
                cash = cash + 100;
                exp = exp + exp1Earned;
            }

            if (b1.Image == slotImages[1] && b2.Image == slotImages[1] || b2.Image == slotImages[1] && b3.Image == slotImages[1] || b1.Image == slotImages[1] && b3.Image == slotImages[1])
            {
                cash = cash + 75;
                exp = exp + exp1Earned;
            }

            if (b1.Image == slotImages[2] && b2.Image == slotImages[2] || b2.Image == slotImages[2] && b3.Image == slotImages[2] || b1.Image == slotImages[2] && b3.Image == slotImages[2])
            {
                cash = cash + 50;
                exp = exp + exp1Earned;
            }

            if (b1.Image == slotImages[0] && b2.Image == slotImages[0] && b3.Image == slotImages[0])
            {
                cash = cash + 200;
                SoundPlayer erza = new SoundPlayer("..\\..\\Resources\\3_erza_win.wav");
                erza.PlayLooping();
                erza.PlayLooping();
                MessageBox.Show("You Matched 3 Erza's! \n You Won $200");
                erza.Stop();
                exp = exp + exp2Earned;
            }

            if (b1.Image == slotImages[1] && b2.Image == slotImages[1] && b3.Image == slotImages[1])
            {
                cash = cash + 175;
                SoundPlayer p = new SoundPlayer("..\\..\\Resources\\3_mirajane_win.wav");
                p.PlayLooping();
                MessageBox.Show("You Matched 3 Mirajane's! \n You Won $175");
                p.Stop();
                exp = exp + exp2Earned;
            }

            if (b1.Image == slotImages[2] && b2.Image == slotImages[2] && b3.Image == slotImages[2])
            {
                cash = cash + 150;
                SoundPlayer p = new SoundPlayer("..\\..\\Resources\\3_lucy_win.wav");
                p.PlayLooping();
                MessageBox.Show("You Matched 3 Lucy's! \n You Won $150");
                p.Stop();
                exp = exp + exp2Earned;
            }

            if (b1.Image == slotImages[3] && b2.Image == slotImages[3] && b3.Image == slotImages[3])
            {
                cash = cash + 0;
                playersBet.Text = "Free Spin!";
            }

            else
            {
                cash = cash + 0;
                exp = exp + 5;
            }
        }

        bool bet1Amount = false;
        bool bet2Amount = false;
        bool bet3Amount = false;
        bool bet4Amount = false;
        bool bet5Amount = false;
        bool bet6Amount = false;

        private void bet20PicBtn_Click(object sender, EventArgs e)
        {
            bet = 20;
            playersBet.Text = 20.ToString();
            bet1Amount = true;
        }

        private void bet50PicBtn_Click(object sender, EventArgs e)
        {
            bet = 50;
            playersBet.Text = 50.ToString();
            bet2Amount = true;
        }

        private void bet70PicBtn_Click(object sender, EventArgs e)
        {
            bet = 70;
            playersBet.Text = 70.ToString();
            bet3Amount = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter saveSlotFile = File.AppendText("save_slot.txt");
            saveSlotFile.WriteLine(playersCash.Text);
            saveSlotFile.Close();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader saveSlotFile = new StreamReader("save_slot.txt");

            string line;

            while (!saveSlotFile.EndOfStream)
            {
                line = saveSlotFile.ReadLine();
                //playersCash.Items.Add(line);
            }
            saveSlotFile.Close();
        }


        int s = 0;

        private void levelGenerator()
        {
            SoundPlayer lvlPlayer = new SoundPlayer("..\\..\\Resources\\Happy_Aye_Sir.wav");

            if (exp < 100)
            {
                levelLbl.Text = "1";
                expTextBox.Text = exp + " / 100";
            }

            if (exp >= 100)
            {
                levelLbl.Text = "2";
                expTextBox.Text = exp + " / 250";
                this.Size = new Size(925, 637);
                if (s == 0)
                {
                    lvlPlayer.Play();
                    s = 1;
                }
            }

            if (exp >= 250)
            {
                levelLbl.Text = "3";
                expTextBox.Text = exp + " / 425";
                bet90PicBtn.Visible = true;
                if (s == 1)
                {
                    lvlPlayer.Play();
                    s = 2;
                }
            }

            if (exp >= 425)
            {
                levelLbl.Text = "4";
                expTextBox.Text = exp + " / 600";
                bet100PicBtn.Visible = true;
                if (s == 2)
                {
                    lvlPlayer.Play();
                    s = 3;
                }
            }
        }

        private void bet80PicBtn_Click(object sender, EventArgs e)
        {
            bet = 80;
            playersBet.Text = 80.ToString();
            bet4Amount = true;
        }

        private void bet90PicBtn_Click(object sender, EventArgs e)
        {
            bet = 90;
            playersBet.Text = 90.ToString();
            bet5Amount = true;
        }

        private void bet100PicBtn_Click(object sender, EventArgs e)
        {
            bet = 100;
            playersBet.Text = 100.ToString();
            bet6Amount = true;
        }

        void bonus()
        {
            // - = AM / + = PM
            TimeSpan start = new TimeSpan(12, 00, 00);
            TimeSpan end = new TimeSpan(30, 00, 00);
            TimeSpan now = DateTime.Now.TimeOfDay;
            if (now > start && now < end)
            {
                if (b == 0)
                {
                    bonusCashPicBtn.Visible = true;
                    label11.Text = "Collect Bonus Now!";
                }
            }
            else
            {
                bonusCashPicBtn.Visible = false;
            }
        }

        private void bonusCashPicBtn_Click(object sender, EventArgs e)
        {
            b = 1;
            playersCash.Text = "$" + (cash + 100).ToString();
        }

        private void settingsPicBtn_Click(object sender, EventArgs e)
        {
            slotMachineSettings popup = new slotMachineSettings();
            DialogResult dialogresult = popup.ShowDialog();
        }
    }
}
