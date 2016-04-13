using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

namespace Sciencetific_Calc
{
    public partial class Chat_Client_APP : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;

        static String chatName;

        public Chat_Client_APP()
        {
            InitializeComponent();
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            textLocalIp.Text = GetLocalIP();
            textFriendsIp.Text = GetLocalIP();
        }

        private String GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.1";

        }

       private void MessageCallBack(IAsyncResult aResult)
        {
          try
          {
            int size = sck.EndReceiveFrom(aResult, ref epRemote);
            if(size>0)
              {
                byte[] receivedData = new byte[1464];

                receivedData = (byte[])aResult.AsyncState;

                ASCIIEncoding eEncoding = new ASCIIEncoding();
                String receivedMessage = eEncoding.GetString(receivedData);
                listMessage.Items.Add("Friend: " +receivedMessage);
              }
                
              byte[] buffer = new byte[1500];
              sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
          }
          catch(Exception exp)
            {
              MessageBox.Show(exp.ToString());
            }
       }

       private void button2_Click(object sender, EventArgs e)
       {
           try
           {
               System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
               byte[] msg = new byte[1500];
               msg = enc.GetBytes(textMessage.Text);

               sck.Send(msg);
               listMessage.Items.Add("You: " + textMessage.Text);
               textMessage.Clear();
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString());
           }
       }

       private void button1_Click(object sender, EventArgs e)
       {
         try
         {
             epLocal = new IPEndPoint(IPAddress.Parse(textLocalIp.Text), Convert.ToInt32(textLocalPort.Text));
             sck.Bind(epLocal);

             epRemote = new IPEndPoint(IPAddress.Parse(textFriendsIp.Text), Convert.ToInt32(textFriendsPort.Text));
             sck.Connect(epRemote);

             byte[] buffer = new byte[1500];
             sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

             button1.Text = "Connected";
             button1.Enabled = false;
             button2.Enabled = true;
             textMessage.Focus();
         }
         catch(Exception ex)
         {
             MessageBox.Show(ex.ToString());
         }
       }

       private void regularToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Hide();
           Form1 popup = new Form1();
           DialogResult dialogresult = popup.ShowDialog();
       }

       private void sciencetificToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Hide();
           Form2 popup = new Form2();
           DialogResult dialogresult = popup.ShowDialog();
       }

       private void exitToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Application.Exit();
       }

       private void paintToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Hide();
           paint popup = new paint();
           DialogResult dialogresult = popup.ShowDialog();
       }

       private void snakeGameToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Hide();
           Snake popup = new Snake();
           DialogResult dialogresult = popup.ShowDialog();
       }

       private void internetTvToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Hide();
           Internet_Tv popup = new Internet_Tv();
           DialogResult dialogresult = popup.ShowDialog();
       }

       private void digitalClockToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Hide();
           DigitalClock popup = new DigitalClock();
           DialogResult dialogresult = popup.ShowDialog();
       }

       private void analongClockToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Hide();
           AnalogClock popup = new AnalogClock();
           DialogResult dialogresult = popup.ShowDialog();
       }

       private void pDFReaderToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Hide();
           Mypdf popup = new Mypdf();
           DialogResult dialogresult = popup.ShowDialog();
       }

       private void audioFileReaderToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Hide();
           Audio_File_Player popup = new Audio_File_Player();
           DialogResult dialogresult = popup.ShowDialog();
       }

       private void getIPToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Hide();
           Get_IP_Address popup = new Get_IP_Address();
           DialogResult dialogresult = popup.ShowDialog();
       }

       private void mP3PlayerToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Hide();
           MP3_Player popup = new MP3_Player();
           DialogResult dialogresult = popup.ShowDialog();
       }

       private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Hide();
           Mynotepad popup = new Mynotepad();
           DialogResult dialogresult = popup.ShowDialog();
       }

       private void chatClientToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Hide();
           Chat_Client_APP popup = new Chat_Client_APP();
           DialogResult dialogresult = popup.ShowDialog();
       }

       private void singlePlayerToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Hide();
           DiceGame popup = new DiceGame();
           DialogResult dialogresult = popup.ShowDialog();
       }

       private void speakToTextToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Hide();
           Speaker popup = new Speaker();
           DialogResult dialogresult = popup.ShowDialog();
       }

       private void flappyBirdToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Hide();
           Flappy_Bird popup = new Flappy_Bird();
           DialogResult dialogresult = popup.ShowDialog();
       }

       private void keyboardToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Hide();
           onscreenKeyboard popup = new onscreenKeyboard();
           DialogResult dialogresult = popup.ShowDialog();
       }

       private void animeMangaMenuToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Hide();
           animeAndMangaMenu popup = new animeAndMangaMenu();
           DialogResult dialogresult = popup.ShowDialog();
       }

       private void twoPlayerToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Hide();
           diceGameTwoPlayer popup = new diceGameTwoPlayer();
           DialogResult dialogresult = popup.ShowDialog();
       }

       private void crosswordToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Hide();
           crossword popup = new crossword();
           DialogResult dialogresult = popup.ShowDialog();
       }

       private void ticTacToeToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Hide();
           ticTacToe popup = new ticTacToe();
           DialogResult dialogresult = popup.ShowDialog();
       }

       private void pingPongToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Hide();
           pingPong popup = new pingPong();
           DialogResult dialogresult = popup.ShowDialog();
       }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog bg = new ColorDialog();
            if (bg.ShowDialog() == DialogResult.OK)
            {
                listMessage.BackColor = bg.Color;
                textMessage.BackColor = bg.Color;
            }
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fc = new ColorDialog();
            if (fc.ShowDialog() == DialogResult.OK)
            {
                listMessage.ForeColor = fc.Color;
                textMessage.ForeColor = fc.Color;
            }
        }

        public static void setPlayerNames(String cN)
        {
            chatName = cN;
        }

        private void setNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chatSetName popup = new chatSetName();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
       {
           Application.Exit();
       }
    }
}
