using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sciencetific_Calc
{
    public partial class alarmClock : Form
    {
        string selectedTime;
        string selectedSnooze;
        string selectedRingtone;
        string selectedMessage;

        bool alarmSet = false;

        string snoozeTime;
        bool snoozeSet = false;

        string wavPath = @"H:\Sciencetific Calc Project\Sciencetific Calc\Sciencetific Calc\bin\Debug\Ringtones\";
        SoundPlayer soundPlayer;

        alarmClockMessage ringForm;

        public alarmClock()
        {
            InitializeComponent();

            soundPlayer = new SoundPlayer();
            ringForm = new alarmClockMessage(this);
        }

        private void alarmClock_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtTime.Text = DateTime.Now.ToString("h:mm tt");

            if (alarmSet)
            {
                if(txtTime.Text == selectedTime)
                {
                    alarmSet = false;

                    soundPlayer.Play();
                    ringForm.ShowDialog();
                }
            }
            else if (snoozeSet)
            {
                if(txtTime.Text == snoozeTime)
                {
                    snoozeSet = false;
                    soundPlayer.Play();
                    ringForm.ShowDialog();
                }
            }

            UpdateData();
        }

        private void UpdateData()
        {
            for(int i = 1; i <= 12; i++)
            {
                cmbHour.Items.Add(i.ToString());
            }

            for (int i = 1; i <= 59; i++)
            {
                if(i < 10)
                {
                    cmbMinute.Items.Add("0" + i.ToString());
                }
                else
                {
                    cmbMinute.Items.Add(i.ToString());
                }
            }

            cmbAMPM.Items.Add("AM");
            cmbAMPM.Items.Add("PM");

            cmbSnooze.Items.Add("1");
            cmbSnooze.Items.Add("5");
            cmbSnooze.Items.Add("10");
            cmbSnooze.Items.Add("15");

            string[] wavFiles = Directory.GetFiles(wavPath, "*.wav");

            foreach(string wavFile in wavFiles)
            {
                string wavName = wavFile.Replace(wavPath, string.Empty);
                listRingtones.Items.Add(wavName);
            }
        }

        private void alarmSetBtn_Click(object sender, EventArgs e)
        {
            selectedTime = cmbHour.Text + ":" + cmbMinute.Text + " " + cmbAMPM.Text;
            selectedSnooze = cmbSnooze.Text;
            selectedRingtone = listRingtones.Text;
            selectedMessage = richtxtMessage.Text;

            soundPlayer.SoundLocation = wavPath + selectedRingtone + ".wav";

            ringForm.Message(selectedMessage);

            groupBox1.Enabled = false;
            alarmSet = true;
        }

        public void Snooze()
        {
            try
            {
                soundPlayer.Stop();
            }
            catch { }

            DateTime dateTime = DateTime.Now;
            TimeSpan timeSpan = new TimeSpan(0, Convert.ToInt32(selectedSnooze), 0);
            snoozeTime = dateTime.Add(timeSpan).ToString("h:mm tt");

            snoozeSet = true;
        }

        public void Resume()
        {
            try
            {
                soundPlayer.Stop();
            }
            catch { }

            groupBox1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtTime.Text = DateTime.Now.ToString("h:mm tt");

            if (alarmSet)
            {
                if (txtTime.Text == selectedTime)
                {
                    alarmSet = false;

                    soundPlayer.Play();
                    ringForm.ShowDialog();
                }
            }
            else if (snoozeSet)
            {
                if (txtTime.Text == snoozeTime)
                {
                    snoozeSet = false;
                    soundPlayer.Play();
                    ringForm.ShowDialog();
                }
            }
        }
    }
}
