using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Sciencetific_Calc
{
    public partial class pokemonBattle : Form
    {

        string opponentsName;

        public pokemonBattle()
        {
            InitializeComponent();

            pokemonImages = new Image[3];
            pokemonImages[0] = Properties.Resources.Leafeon;
            pokemonImages[1] = Properties.Resources.Trevenant;
            pokemonImages[2] = Properties.Resources.Shiftry;

            Player = new SoundPlayer("..\\..\\Resources\\Leafeon_cry.wav");
        }

        Image[] pokemonImages;

        int opponentsHP;

        public bool winner = false;

        int PP1 = 15;
        int PP2 = 15;
        int PP3 = 10;
        int PP4 = 10;

        int damage;

        Random rand = new Random();

        private SoundPlayer Player;

        int time = 10;

        int myHP = 239;

        CheckBox[] ch;

        void decideHP()
        {
            if (pictureBox2.Image == pokemonImages[0])
            {
                opponentsHP = 70;
                textBox2.Text = opponentsHP + "/70";
            }
            else if (pictureBox2.Image == pokemonImages[1])
            {
                opponentsHP = 95;
                textBox2.Text = opponentsHP + "/95";
            }
            else if (pictureBox2.Image == pokemonImages[2])
            {
                opponentsHP = 100;
                textBox2.Text = opponentsHP + "/100";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool turn;

        private void pokemonBattle_Load(object sender, EventArgs e)
        {
            button1.Text = "Flamethrower \n" + PP1 + "/15 PP";
            button2.Text = "Thunderbolt \n" + PP2 + "/15 PP";
            button3.Text = "Psychic \n" + PP3 + "/15 PP";

            decideHP();

            turn = true;
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                PP1 = PP1 - 1;
                button1.Text = "Flamethrower \n" + PP1 + "/15 PP";
                if (PP1 == -1)
                {
                    MessageBox.Show("No more PP!");
                    PP1 = PP1 + 1;
                    button1.Text = "Flamethrower \n" + PP1 + "/15 PP";
                }

                if (PP1 != -1)
                {
                    textBox3.Clear();
                    damage = ((((2 * 70 / 5 + 2) * 110 * 90 / 130) / 50) + 2) * 1 * 2 * 100 / 100;
                    opponentsHP = opponentsHP - damage;
                    textBox2.Text = opponentsHP + "/70";
                    if (opponentsHP <= 0)
                    {
                        textBox3.Text = "Mewtwo used Flamethrower! It did " + damage + " damage!";
                        /*MessageBox.Show("You won!");
                        Player.Play();
                        button9.Visible = true;
                        button1.Enabled = false;
                        button2.Enabled = false;
                        button3.Enabled = false;
                        button4.Enabled = false;*/
                        startTimer();

                    }
                    else if(opponentsHP > 0)
                    {
                        textBox3.Text = "Mewtwo used Flamethrower! It did " + damage + " damage!";
                        startTimer();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                PP2 = PP2 - 1;
                button1.Text = "Thunderbolt \n" + PP2 + "/15 PP";
                if (PP2 == -1)
                {
                    MessageBox.Show("No more PP!");
                    PP2 = PP2 + 1;
                    button1.Text = "Thunderbolt \n" + PP2 + "/15 PP";
                }

                if (PP2 != -1)
                {
                    textBox3.Clear();
                    damage = ((((2 * 70 / 5 + 2) * 110 * 90 / 130) / 50) + 2) * 1 * (1/2) * 100 / 100;
                    opponentsHP = opponentsHP - damage;
                    textBox2.Text = opponentsHP + "/70";
                    if (opponentsHP <= 0)
                    {
                        textBox3.Text = "Mewtwo used Thunderbolt! It did " + damage + " damage!";
                        /*MessageBox.Show("You won!");
                        Player.Play();
                        button9.Visible = true;
                        button1.Enabled = false;
                        button2.Enabled = false;
                        button3.Enabled = false;
                        button4.Enabled = false;*/
                        startTimer();

                    }
                    else if (opponentsHP > 0)
                    {
                        textBox3.Text = "Mewtwo used Thunderbolt! It did " + damage + " damage!";
                        startTimer();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                PP3 = PP3 - 1;
                button1.Text = "Psychic \n" + PP3 + "/15 PP";
                if (PP3 == -1)
                {
                    MessageBox.Show("No more PP!");
                    PP3 = PP3 + 1;
                    button1.Text = "Psychic \n" + PP3 + "/15 PP";
                }

                if (PP3 != -1)
                {
                    textBox3.Clear();
                    damage = ((((2 * 70 / 5 + 2) * 110 * 90 / 130) / 50) + 2) * (3/2) * 1 * 100 / 100;
                    opponentsHP = opponentsHP - damage;
                    textBox2.Text = opponentsHP + "/70";
                    if (opponentsHP <= 0)
                    {
                        textBox3.Text = "Mewtwo used Psychic! It did " + damage + " damage!";
                        /*MessageBox.Show("You won!");
                        Player.Play();
                        button9.Visible = true;
                        button1.Enabled = false;
                        button2.Enabled = false;
                        button3.Enabled = false;
                        button4.Enabled = false;*/
                        startTimer();

                    }
                    else if (opponentsHP > 0)
                    {
                        textBox3.Text = "Mewtwo used Psychic! It did " + damage + " damage!";
                        startTimer();
                    }
                }
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                PP4 = PP4 - 1;
                button4.Text = "Protect \n" + PP4 + "/15 PP";
                if (PP4 == -1)
                {
                    MessageBox.Show("No more PP!");
                    PP4 = PP4 + 1;
                    button4.Text = "Protect \n" + PP4 + "/15 PP";
                }

                if (PP4 != -1)
                {
                    textBox3.Clear();
                    if (opponentsHP > 0)
                    {
                        textBox3.Text = "Mewtwo used Protect! It did 0 damage!";
                        startTimer();
                    }
                }
            }
        }

        private void startTimer()
        {
            timer1.Start();
            timer1.Tick += delegate
            {
              label7.Text = time.ToString();
              time--;
              if (time == -1)
              {
                 timer1.Stop();
                 int randMove = rand.Next(0, 4);
                 if (randMove == 1)
                 {
                   textBox3.Clear();
                   int level = Int32.Parse(label5.Text);
                   damage = ((((2 * level / 5 + 2) * 110 * 90 / 90) / 50) + 2) * 1 * 1 * 100 / 100;
                   myHP = myHP - damage;
                   textBox1.Text = myHP + "/239";
                   textBox3.Text = "Leafeon used Leaf Blade! It did " + damage + " damage!";
                 }
                 else if (randMove == 2)
                 {
                   textBox3.Clear();
                   //Double Team

                   /*int level = Int32.Parse(label5.Text);
                   damage = ((((2 * level / 5 + 2) * 110 * 90 / 90) / 50) + 2) * 1 * 1 * 100 / 100;
                   myHP = myHP - damage;*/
                   textBox1.Text = myHP + "/239";
                 }
                 else if (randMove == 3)
                 {
                   textBox3.Clear();
                   int level = Int32.Parse(label5.Text);
                   damage = ((((2 * level / 5 + 2) * 110 * 60 / 90) / 50) + 2) * 1 * 1 * 100 / 100;
                   myHP = myHP - damage;
                   textBox1.Text = myHP + "/239";
                   textBox3.Text = "Leafeon used Magical Leaf! It did " + damage + " damage!";
                 }
                 else if (randMove == 4)
                 {
                   textBox3.Clear();
                   int level = Int32.Parse(label5.Text);
                   damage = ((((2 * level / 5 + 2) * 110 * 40 / 90) / 50) + 2) * 1 * 1 * 100 / 100;
                   myHP = myHP - damage;
                   textBox1.Text = myHP + "/239";
                   textBox3.Text = "Leafeon used Quick Attack! It did " + damage + " damage!";
                 }
               }
            };
            time = 10;
            turn = true;
        }
    }
}
