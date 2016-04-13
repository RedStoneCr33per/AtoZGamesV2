using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sciencetific_Calc
{
    public partial class history : Form
    {
        public history()
        {
            InitializeComponent();
        }

        public void WriteHistory()
        {
            StreamReader historyFile = new StreamReader("write.txt");

            string line;

            while (!historyFile.EndOfStream)
            {
                line = historyFile.ReadLine();
                listBox1.Items.Add(line);
            }
            historyFile.Close();
        }

        private void clearHistoryBtn_Click(object sender, EventArgs e)
        {
            StreamWriter clearHistory;

            clearHistory = File.CreateText("write.txt");

            clearHistory.Close();
            listBox1.Items.Clear();
        }

        private void exitHistoryBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
