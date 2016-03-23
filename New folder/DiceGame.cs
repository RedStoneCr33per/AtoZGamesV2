﻿#region Using Statments
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace Sciencetific_Calc
{
    public partial class DiceGame : Form
    {
        #region Decleration

        Image[] diceImages;
        int[] dice;
        int[] diceResults;
        Random rand;

        #region Initialization
        public DiceGame()
        {
            InitializeComponent();
        }

        private void DiceGame_Load(object sender, EventArgs e)
        {
            diceImages = new Image[7];
            diceImages[0] = Properties.Resources.dice_blank;
            diceImages[1] = Properties.Resources.dice_1;
            diceImages[2] = Properties.Resources.dice_2;
            diceImages[3] = Properties.Resources.dice_3;
            diceImages[4] = Properties.Resources.dice_4;
            diceImages[5] = Properties.Resources.dice_5;
            diceImages[6] = Properties.Resources.dice_6;

            dice = new int[5] { 0, 0, 0, 0, 0 };

            diceResults = new int[6] { 0, 0, 0, 0, 0, 0 };

            rand = new Random();
        }
        #endregion

        #region Private Methods

        private void btn_rollDice_Click(object sender, EventArgs e)
        {
            RollDice();

            GetResults();

            ResetResults();
        }

        private void RollDice()
        {
            for(int i=0; i < dice.Length; i++)
            { 
                dice[i] = rand.Next(1, 6 + 1);

                switch (dice[i])
                {
                    case 1:
                        diceResults[0]++;
                        break;
                    case 2:
                        diceResults[1]++;
                        break;
                    case 3:
                        diceResults[2]++;
                        break;
                    case 4:
                        diceResults[3]++;
                        break;
                    case 5:
                        diceResults[4]++;
                        break;
                    case 6:
                        diceResults[5]++;
                        break;
                }
            }

            lbl_dice1.Image = diceImages[dice[0]];
            lbl_dice2.Image = diceImages[dice[1]];
            lbl_dice3.Image = diceImages[dice[2]];
            lbl_dice4.Image = diceImages[dice[3]];
            lbl_dice5.Image = diceImages[dice[4]];

        }
        #endregion

        private void GetResults()
        {
            bool fiveKind = false, fourKind = false, highStraight = false,
                lowStraight = false, fullHouse = false, threeKind = false,
                twoPair = false, onePair = false, haveSix = false, haveFive = true,
                haveFour = false, haveThree = false, haveTwo = false, haveOne = false;

            for(int i=0; i<diceResults.Length;i++)
            {
                if (diceResults[i] == 5)
                    fiveKind = true;
                else if (diceResults[i] == 4)
                    fourKind = true;
                else if (diceResults[1] == 1  &&
                    diceResults[2] == 1 &&
                    diceResults[3]  == 1 &&
                    diceResults[4] == 1 &&
                    diceResults[5] == 1)
                    highStraight = true;
                else if (diceResults[0] == 1 &&
                    diceResults[1] == 1 &&
                    diceResults[2] == 1 &&
                    diceResults[3] == 1 &&
                    diceResults[4] == 1)
                    lowStraight = true;
                else if(diceResults[i] == 3)
                {
                    threeKind = true;

                    for(int j = 0; j<diceResults.Length;j++)
                    {
                        if (diceResults[j] == 2)
                            fullHouse = true;
                    }
                }
                else if(diceResults[i] == 2)
                {
                    onePair = true;

                    for(int j = i + 1; j < diceResults.Length; j++)
                    {
                        if(diceResults[j] == 2)
                            twoPair = true;
                    }
                }
            }
            for(int i=0; i<dice.Length; i++)
            { 
                switch (dice[i])
                {
                    case 6:
                        haveSix = true;
                        break;
                    case 5:
                        haveFive = true;
                        break;
                    case 4:
                        haveFour = true;
                        break;
                    case 3:
                        haveThree = true;
                        break;
                    case 2:
                        haveTwo = true;
                        break;
                    case 1:
                        haveOne = true;
                        break;
                }
            }

            if (fiveKind)
                lbl_displayResults.Text = "Five of a Kind";
            else if (fourKind)
                lbl_displayResults.Text = "Four of a Kind";
            else if (highStraight)
                lbl_displayResults.Text = "High Straight";
            else if (lowStraight)
                lbl_displayResults.Text = "Low Straight";
            else if (fullHouse)
                lbl_displayResults.Text = "Full House";
            else if (threeKind)
                lbl_displayResults.Text = "Three of a Kind";
            else if (twoPair)
                lbl_displayResults.Text = "Two Pair";
            else if (haveSix)
                lbl_displayResults.Text = "Six High";
            else if (haveFive)
                lbl_displayResults.Text = "Five High";
            else if (haveFour)
                lbl_displayResults.Text = "Four High";
            else if (haveThree)
                lbl_displayResults.Text = "Three High";
            else if (haveTwo)
                lbl_displayResults.Text = "Two High";
            else if (haveOne)
                lbl_displayResults.Text = "One High";
        }

        private void ResetResults()
        {
            for (int i = 0; i < diceResults.Length; i++)
        diceResults[i] = 0;
        }

        #endregion
    }
}