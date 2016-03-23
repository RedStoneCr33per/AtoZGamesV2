using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Sciencetific_Calc
{
    public partial class phone : Form
    {
        private SerialPort sp;

        public phone()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sp = new SerialPort();
        }

        private void callBtn_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.Close();
            }

            sp.PortName = "COM10";
            sp.BaudRate = 9600;
            sp.Parity = Parity.None;
            sp.DataBits = 8;
            sp.StopBits = StopBits.One;
            sp.Handshake = Handshake.XOnXOff;
            sp.DtrEnable = true;
            sp.RtsEnable = true;


            sp.Open();

            if (!sp.IsOpen)
            {
                MessageBox.Show("Serial port is not opened");
                return;
            }

            sp.WriteLine("AT" + Environment.NewLine);
            sp.WriteLine("ATD=\"" + "Destination Number" + "\"" + Environment.NewLine);

        }
    }
}
