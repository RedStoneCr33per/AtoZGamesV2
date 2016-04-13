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
    public partial class alarmClockMessage : Form
    {
        static alarmClock alarm;
        string _message;

        public alarmClockMessage(alarmClock aC)
        {
            InitializeComponent();

            alarm = aC;
        }

        public void Message(string message)
        {
            _message = message;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            alarm.Resume();
        }

        private void snoozeBtn_Click(object sender, EventArgs e)
        {
            alarm.Snooze();
            this.Close();
        }

        private void alarmClockMessage_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = _message;
        }
    }
}
