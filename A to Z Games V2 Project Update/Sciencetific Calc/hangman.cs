﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Sciencetific_Calc
{
    public partial class hangman : Form
    {
        public hangman()
        {
            InitializeComponent();
        }

        string word = "";
        List<Label> labels = new List<Label>();
        int amount = 0;

        enum BodyParts
        {
            Head,
            Left_Eye,
            Right_Eye,
            Mouth,
            Right_Arm,
            Left_Arm,
            Body,
            Right_Leg,
            Left_Leg
        }

        void DrawHangPost()
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Brown, 10);
            g.DrawLine(p, new Point(130, 218), new Point(130, 5));
            g.DrawLine(p, new Point(135, 5), new Point(65, 5));
            g.DrawLine(p, new Point(60, 0), new Point(60, 50));
            DrawBodyParts(BodyParts.Head);
            DrawBodyParts(BodyParts.Left_Eye);
            DrawBodyParts(BodyParts.Right_Eye);
            DrawBodyParts(BodyParts.Mouth);
            DrawBodyParts(BodyParts.Body);
            DrawBodyParts(BodyParts.Left_Arm);
            DrawBodyParts(BodyParts.Right_Arm);
            DrawBodyParts(BodyParts.Left_Leg);
            DrawBodyParts(BodyParts.Right_Leg);
        }

        void DrawBodyParts(BodyParts bp)
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Blue, 2);
            if (bp == BodyParts.Head)
                g.DrawEllipse(p, 40, 50, 40, 40);
            else if (bp == BodyParts.Left_Eye)
            {
                SolidBrush s = new SolidBrush(Color.Black);
                g.FillEllipse(s, 50, 60, 5, 5);
            }
            else if (bp == BodyParts.Right_Eye)
            {
                SolidBrush s = new SolidBrush(Color.Black);
                g.FillEllipse(s, 63, 60, 5, 5);
            }
            else if (bp == BodyParts.Mouth)
                g.DrawArc(p, 50, 60, 20, 20, 45, 90);
            else if (bp == BodyParts.Body)
                g.DrawLine(p, new Point(60, 90), new Point(60, 170));
            else if (bp == BodyParts.Left_Arm)
                g.DrawLine(p, new Point(60, 100), new Point(30, 85));
            else if (bp == BodyParts.Right_Arm)
                g.DrawLine(p, new Point(60, 100), new Point(90, 85));
            else if (bp == BodyParts.Left_Leg)
                g.DrawLine(p, new Point(60, 170), new Point(30, 190));
            else if (bp == BodyParts.Right_Leg)
                g.DrawLine(p, new Point(60, 170), new Point(90, 190));
        }

        void MakeLabels()
        {
            word = GetRandomWord();
            char[] chars = word.ToCharArray();
            int between = 330 / chars.Length - 1;
            for (int i = 0; i < chars.Length - 1; i++)
            {
                labels.Add(new Label());
                labels[i].Location = new Point((i * between) + 10, 80);
                labels[i].Text = "_";
                labels[i].Parent = groupBox2;
                labels[i].BringToFront();
                labels[i].CreateControl();
            }
            label1.Text = "Word Legnth: " + (chars.Length - 1).ToString();
        }

        string GetRandomWord()
        {
            WebClient wc = new WebClient();
            string wordList = wc.DownloadString("https://raw.githubusercontent.com/Tom25/Hangman/master/wordlist.txt");
            string[] words = wordList.Split('\n');
            Random ran = new Random();
            return words[ran.Next(0, words.Length - 1)];
        }

        private void hangman_Shown(object sender, EventArgs e)
        {
            DrawHangPost();
            MakeLabels();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char letter = textBox1.Text.ToLower().ToCharArray()[0];
            if (!char.IsLetter(letter))
            {
                MessageBox.Show("You can only sumbit letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (word.Contains(letter))
            {
                char[] letters = word.ToCharArray();
                for(int i = 0; i < letters.Length; i++)
                {
                    if (letters[i] == letter)
                    {
                        labels[i].Text = letter.ToString();
                        textBox1.Clear();
                    }
                }
                foreach (Label l in labels)
                    if (l.Text == "_") return;
                MessageBox.Show("You won", "Congrats!");
                ResetGame();
            }
            else
            {
                MessageBox.Show("The letter you guess isn't in the word!", "Sorry");
                textBox1.Clear();
                label2.Text += " " + letter.ToString() + ",";
                DrawBodyParts((BodyParts)amount);
                amount++;
                if(amount == 8)
                {
                    MessageBox.Show("Sorry, but you lost! The word was " + word);
                    ResetGame();
                }
            }
        }

        void ResetGame()
        {
            Graphics g = panel1.CreateGraphics();
            g.Clear(panel1.BackColor);
            GetRandomWord();
            MakeLabels();
            DrawHangPost();
            label2.Text = "Missed: ";
            label1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == word)
            {
                MessageBox.Show("You won!", "Congrats!");
                ResetGame();
            }
            else
            {
                MessageBox.Show("The word you guess is wrong", "Sorry");
                textBox2.Clear();
                DrawBodyParts((BodyParts)amount);
                amount++;
                if (amount == 9)
                {
                    MessageBox.Show("Sorry, but you lost! The word was " + word);
                    ResetGame();
                }
            }
        }
    }
}
