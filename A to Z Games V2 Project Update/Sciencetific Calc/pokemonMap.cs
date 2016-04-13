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
    public partial class pokemonMap : Form
    {
        public pokemonMap()
        {
            InitializeComponent();

            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pokemonMap_KeyDown);
        }

        pokemonBattle P;

        int x;
        int y;

        Random rand = new Random();

        Image[] pokemonImages;

        pokemonBattle pB = new pokemonBattle();

        //int opponentsHP;

        private void pokemonMap_KeyDown(object sender, KeyEventArgs e)
        {
            collision();
            checkWinner();
            if (show != true)
            {
                x = pictureBox9.Location.X;
                y = pictureBox9.Location.Y;
                if (e.KeyCode == Keys.Right) x += 1;
                else if (e.KeyCode == Keys.Left) x -= 1;
                else if (e.KeyCode == Keys.Up) y -= 1;
                else if (e.KeyCode == Keys.Down) y += 1;

                pictureBox9.Location = new Point(x, y);
            }
        }

        bool show = false;
        int i = 0;

        void collision()
        {
            int randNumber = rand.Next(0, 4);
            int lvlNumber = rand.Next(20, 36);

            if (pictureBox9.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                if (i == 0)
                {
                    show = true;
                    pictureBox9.Location = new Point(x + 1, y);
                    i = 1;
                }
                else
                {
                    show = false;
                    i = 0;
                }
            }
            else if (pictureBox9.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                if (i == 0)
                {
                    show = true;
                    MessageBox.Show("Stop");
                    i = 1;
                }
                else
                {
                    show = false;
                    i = 0;
                }
            }
            else if (pictureBox9.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                if (i == 0)
                {
                    show = true;
                    MessageBox.Show("Stop");
                    i = 1;
                }
                else
                {
                    show = false;
                    i = 0;
                }
            }
            else if (pictureBox9.Bounds.IntersectsWith(pictureBox10.Bounds))
            {
                if (i == 0)
                {
                    show = true;
                    MessageBox.Show("Stop");
                    i = 1;
                }
                else
                {
                    show = false;
                    i = 0;
                }
            }
            else if (pictureBox9.Bounds.IntersectsWith(pictureBox11.Bounds))
            {
                if (i == 0)
                {
                    show = true;
                    MessageBox.Show("Stop");
                    i = 1;
                }
                else
                {
                    show = false;
                    i = 0;
                }
            }
            else if (pictureBox9.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                if (i == 0)
                {
                    show = true;
                    MessageBox.Show("Stop");
                    i = 1;
                }
                else
                {
                    show = false;
                    i = 0;
                }
            }
            else if (pictureBox9.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                if (i == 0)
                {
                    show = true;
                    MessageBox.Show("Stop");
                    i = 1;
                }
                else
                {
                    show = false;
                    i = 0;
                }
            }
            else if (pictureBox9.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                if (i == 0)
                {
                    show = true;
                    MessageBox.Show("Stop");
                    i = 1;
                }
                else
                {
                    show = false;
                    i = 0;
                }
            }
            else if (pictureBox9.Bounds.IntersectsWith(pictureBox7.Bounds))
            {
                if (i == 0)
                {
                    show = true;
                    MessageBox.Show("Stop");
                    i = 1;
                }
                else
                {
                    show = false;
                    i = 0;
                }
            }
            else if (pictureBox9.Bounds.IntersectsWith(pictureBox13.Bounds))
            {
                if (pictureBox13.Visible == true)
                {
                    try
                    {
                        if (randNumber == 1)
                        {
                            pB.pictureBox2.Image = pokemonImages[0];
                            pB.button5.Text = "Leaf Blade \n 15/15 PP";
                            pB.button6.Text = "Double Team \n 15/15 PP";
                            pB.button7.Text = "Magical Leaf \n 20/20 PP";
                            pB.button8.Text = "Quick Attack \n 30/30 PP";
                            pB.label5.Text = lvlNumber.ToString();
                            pB.textBox2.Text = "70/70";
                        }
                        else if (randNumber == 2)
                        {
                            pB.pictureBox2.Image = pokemonImages[1];
                            pB.button5.Text = "Shadow Claw";
                            pB.button6.Text = "Posion Jab";
                            pB.button7.Text = "Rock Slide";
                            pB.button8.Text = "Will-O-Wisp";
                            pB.label5.Text = lvlNumber.ToString();
                            pB.textBox2.Text = "95/95";
                        }
                        else if (randNumber == 3)
                        {
                            pB.pictureBox2.Image = pokemonImages[2];
                            pB.button5.Text = "Razor Winds";
                            pB.button6.Text = "Protect";
                            pB.button7.Text = "Leaf Tornado";
                            pB.button8.Text = "Brick Break";
                            pB.label5.Text = lvlNumber.ToString();
                            pB.textBox2.Text = "100/100";
                        }
                    }
                    catch (NullReferenceException ex)
                    {
                        MessageBox.Show("Processor Usage" + ex.Message);
                    }

                    if (i == 0)
                    {
                        show = true;
                        DialogResult dialogresult = pB.ShowDialog();
                        i = 1;
                    }
                    else
                    {
                        show = false;
                        i = 0;
                    }
                }
                else
                {
                    show = false;
                }
                pictureBox13.Visible = false;
            }
            else if (pictureBox9.Bounds.IntersectsWith(pictureBox8.Bounds))
            {              
                try
                {
                    if (pB.pictureBox2.Image == pokemonImages[0])
                    {
                        int randNumber2 = rand.Next(1, 4);
                        int lvlNumber2 = rand.Next(20, 36);

                        if (randNumber2 == 2)
                        {
                            pB.pictureBox2.Image = pokemonImages[1];
                            pB.button5.Text = "Shadow Claw";
                            pB.button6.Text = "Posion Jab";
                            pB.button7.Text = "Rock Slide";
                            pB.button8.Text = "Will-O-Wisp";
                            pB.label5.Text = lvlNumber2.ToString();
                            pB.textBox2.Text = "95/95";
                        }
                        else if (randNumber2 == 3)
                        {
                            pB.pictureBox2.Image = pokemonImages[2];
                            pB.button5.Text = "Razor Winds";
                            pB.button6.Text = "Protect";
                            pB.button7.Text = "Leaf Tornado";
                            pB.button8.Text = "Brick Break";
                            pB.label5.Text = lvlNumber2.ToString();
                            pB.textBox2.Text = "100/100";
                        }
                    }
                    else if (pB.pictureBox2.Image == pokemonImages[1])
                    {
                        int randNumber2 = rand.Next(0, 4);
                        int lvlNumber2 = rand.Next(20, 36);

                        if (randNumber2 == 1)
                        {
                            pB.pictureBox2.Image = pokemonImages[0];
                            pB.button5.Text = "Leaf Blade \n 15/15 PP";
                            pB.button6.Text = "Double Team \n 15/15 PP";
                            pB.button7.Text = "Magical Leaf \n 20/20 PP";
                            pB.button8.Text = "Quick Attack \n 30/30 PP";
                            pB.label5.Text = lvlNumber.ToString();
                            pB.textBox2.Text = "70/70";
                        }
                        else if (randNumber2 == 3)
                        {
                            pB.pictureBox2.Image = pokemonImages[2];
                            pB.button5.Text = "Razor Winds";
                            pB.button6.Text = "Protect";
                            pB.button7.Text = "Leaf Tornado";
                            pB.button8.Text = "Brick Break";
                            pB.label5.Text = lvlNumber2.ToString();
                            pB.textBox2.Text = "100/100";
                        }
                        else
                        {
                            randNumber2 = rand.Next(0, 4);
                        }
                    }
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("Processor Usage" + ex.Message);
                }

                if (i == 0)
                {
                    show = true;
                    DialogResult dialogresult = pB.ShowDialog();
                    i = 1;
                }
                else
                {
                    show = false;
                    i = 0;
                }
            }
            else if (pictureBox9.Bounds.IntersectsWith(pictureBox14.Bounds))
            {

                try
                {
                    if (randNumber == 1)
                    {
                        pB.pictureBox2.Image = pokemonImages[0];
                        pB.button5.Text = "Leaf Blade \n 15/15 PP";
                        pB.button6.Text = "Double Team \n 15/15 PP";
                        pB.button7.Text = "Magical Leaf \n 20/20 PP";
                        pB.button8.Text = "Quick Attack \n 30/30 PP";
                        pB.label5.Text = lvlNumber.ToString();
                        pB.textBox2.Text = "70/70";
                    }
                    else if (randNumber == 2)
                    {
                        pB.pictureBox2.Image = pokemonImages[1];
                        pB.button5.Text = "Shadow Claw";
                        pB.button6.Text = "Posion Jab";
                        pB.button7.Text = "Rock Slide";
                        pB.button8.Text = "Will-O-Wisp";
                        pB.label5.Text = lvlNumber.ToString();
                        pB.textBox2.Text = "95/95";
                    }
                    else if (randNumber == 3)
                    {
                        pB.pictureBox2.Image = pokemonImages[2];
                        pB.button5.Text = "Razor Winds";
                        pB.button6.Text = "Protect";
                        pB.button7.Text = "Leaf Tornado";
                        pB.button8.Text = "Brick Break";
                        pB.label5.Text = lvlNumber.ToString();
                        pB.textBox2.Text = "100/100";
                    }
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("Processor Usage" + ex.Message);
                }

                if (i == 0)
                {
                    show = true;
                    DialogResult dialogresult = pB.ShowDialog();
                    i = 1;
                }
                else
                {
                    show = false;
                    i = 0;
                }
            }
            else if (pictureBox9.Bounds.IntersectsWith(pictureBox17.Bounds))
            {
                if (i == 0)
                {
                    show = true;
                    MessageBox.Show("You beat the grass stage!");
                    i = 1;
                }
                else
                {
                    show = false;
                    i = 0;
                }  
            }
        }

        public void checkWinner()
        {
            if(pB.winner == true && pB.pictureBox2.Image == pokemonImages[0])
            {
                pictureBox23.Visible = true;
            }
        }

        private void pokemonMap_Load(object sender, EventArgs e)
        {
            pokemonImages = new Image[3];
            pokemonImages[0] = Properties.Resources.Leafeon;
            pokemonImages[1] = Properties.Resources.Trevenant;
            pokemonImages[2] = Properties.Resources.Shiftry;
        }
    }
}
