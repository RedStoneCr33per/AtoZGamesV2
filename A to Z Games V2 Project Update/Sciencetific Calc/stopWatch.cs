﻿using System;
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
    public partial class stopWatch : Form
    {
        public stopWatch()
        {
            InitializeComponent();
        }

        int hour, min, sec, ms = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hour = 0;
            min = 0;
            sec = 0;
            ms = 0;
            label1.Text = 0 + ":" + 0 + ":" + 0 + ":" + 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = hour + ":" + min + ":" + sec + ":" + ms.ToString();
            ms++;
            if (ms > 10)
            {
                sec++;
                ms = 0;
            }
            else
            {
                ms++;
            }
            if(sec > 60)
            {
                min++;
                sec = 0;
            }
            if(min > 60)
            {
                hour++;
                min = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
