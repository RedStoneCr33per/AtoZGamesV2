using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
using System.Diagnostics;

namespace Sciencetific_Calc
{
    public partial class Speaker : Form
    {
        public Speaker()
        {
            InitializeComponent();
        }

        int question = 0; 

        SpeechSynthesizer sSynth = new SpeechSynthesizer();
        PromptBuilder pBuilder = new PromptBuilder();
        SpeechRecognitionEngine sRecognize = new SpeechRecognitionEngine();

        private void Speaker_Load(object sender, EventArgs e)
        {
            sSynth.Speak("Welcome To Jarvis");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText(textBox1.Text);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = true;
            Choices sList = new Choices();
            sList.Add(new string[] { "hello", "test", "it works", "how", "are", "you", "today", "i", "am", "fine", "exit", "close", "quit", "so", "open chrome", "seven", "zip a file", "onscreenkeyboard",
            "notepad", "plus", "google", "what is the current time", "play car game", "a to z browser", "youtube", "a to z stops bullying", "jarvis", ",today", "going", "good", "bad", "snake", "calculator",
            "sciencetific", "animme", "and", "manga", "menu", "snake", "hangman", "memory", "shuffle", "text", "pdf", "reader", "stop", "watch", "mazes", "slot", "machine", "ping", "pong", "paint", "mp3", "player",
            "get", "ip"});
            
            Grammar gr = new Grammar(new GrammarBuilder(sList));
            try
            {
                sRecognize.RequestRecognizerUpdate();
                sRecognize.LoadGrammar(gr);
                sRecognize.SpeechRecognized += sRecognize_SpeechRecognized;
                sRecognize.SetInputToDefaultAudioDevice();
                sRecognize.RecognizeAsync(RecognizeMode.Multiple);
                sRecognize.Recognize();
            }

            catch
            {
                return;
            }
        }

            private void sRecognize_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
            {
                if (e.Result.Text == "open chrome")
                {
                    Process.Start("chrome.exe");
                }
                else if (e.Result.Text == "zip a file")
                {
                    Process.Start("7zFM.exe");
                }
                else if (e.Result.Text == "notepad plus plus")
                {
                    Process.Start("notepad++.exe");
                }
                else if (e.Result.Text == "notepad")
                {
                    Process.Start("notepad.exe");
                }
                else if (e.Result.Text == "youtube")
                {
                    Process.Start("chrome.exe", "https://www.youtube.com/");
                }
                else if (e.Result.Text == "a to z stops bullying")
                {
                    Process.Start("chrome.exe", "http://programming.fairfieldlodge125.org/");
                }
                
                else if (e.Result.Text == "onscreenkeyboard")
                {
                    onscreenKeyboard popup = new onscreenKeyboard();
                    DialogResult dialogresult = popup.ShowDialog();
                }
                else if (e.Result.Text == "what is the current time")
                {
                    DigitalClock popup = new DigitalClock();
                    DialogResult dialogresult = popup.ShowDialog();
                }
                else if (e.Result.Text == "play car game")
                {
                    carRacing popup = new carRacing();
                    DialogResult dialogresult = popup.ShowDialog();
                }
                else if (e.Result.Text == "play snake game")
                {
                    Snake popup = new Snake();
                    DialogResult dialogresult = popup.ShowDialog();
                }
                else if (e.Result.Text == "calculator")
                {
                    Form1 popup = new Form1();
                    DialogResult dialogresult = popup.ShowDialog();
                }
                else if (e.Result.Text == "sciencetific calculator")
                {
                    Form2 popup = new Form2();
                    DialogResult dialogresult = popup.ShowDialog();
                }
                else if (e.Result.Text == "anime and manga menu")
                {
                    animeAndMangaMenu popup = new animeAndMangaMenu();
                    DialogResult dialogresult = popup.ShowDialog();
                }
                else if (e.Result.Text == "a to z browser")
                {
                    webBrowser popup = new webBrowser();
                    DialogResult dialogresult = popup.ShowDialog();
                }
                else if (e.Result.Text == "play hangman")
                {
                    hangman popup = new hangman();
                    DialogResult dialogresult = popup.ShowDialog();
                }
                else if (e.Result.Text == "play memory game")
                {
                    memoryGame popup = new memoryGame();
                    DialogResult dialogresult = popup.ShowDialog();
                }
                else if (e.Result.Text == "get ip")
                {
                    Get_IP_Address popup = new Get_IP_Address();
                    DialogResult dialogresult = popup.ShowDialog();
                }
                else if (e.Result.Text == "play shuffle text")
                {
                    shuffleText popup = new shuffleText();
                    DialogResult dialogresult = popup.ShowDialog();
                }
                else if (e.Result.Text == "pdf reader")
                {
                    Mypdf popup = new Mypdf();
                    DialogResult dialogresult = popup.ShowDialog();
                }
                else if (e.Result.Text == "stop watch")
                {
                    stopWatch popup = new stopWatch();
                    DialogResult dialogresult = popup.ShowDialog();
                }
                else if (e.Result.Text == "mazes")
                {
                    atozMazeLevel1 popup = new atozMazeLevel1();
                    DialogResult dialogresult = popup.ShowDialog();
                }
                else if (e.Result.Text == "slot machine")
                {
                    slotMachine popup = new slotMachine();
                    DialogResult dialogresult = popup.ShowDialog();
                }
                else if (e.Result.Text == "mp3 player")
                {
                    MP3_Player popup = new MP3_Player();
                    DialogResult dialogresult = popup.ShowDialog();
                }
                else if (e.Result.Text == "exit")
                {
                    Application.Exit();
                }
                else if (e.Result.Text == "how are you today" || question > 0)
                {
                    if (question == 0)
                    {
                        sSynth.Speak("Good" + "What about you?");
                        question++;
                    }
                    else if (question == 1)
                    {
                        textBox1.Text = textBox1.Text + "h ";
                        if (e.Result.Text == "good")
                        {
                            sSynth.Speak("That's nice to hear");
                            textBox1.Text = textBox1.Text + "h ";
                        }
                        else if (e.Result.Text == "Bad")
                        {
                            sSynth.Speak("That's sad to hear");
                        }
                    }
                }
                textBox1.Text = textBox1.Text + " " + e.Result.Text.ToString();
                textBox1.Text = textBox1.Text + " " + question.ToString();
            }

        private void button3_Click(object sender, EventArgs e)
        {
            sRecognize.RecognizeAsyncStop();
            button2.Enabled = true;
            button3.Enabled = false;
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by: Adam Alexander and Zachary Krause");
        }

        private void googleJarvisPicBtn_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe");
        }

        private void musicJarvisPicBtn_Click(object sender, EventArgs e)
        {
            Process.Start(@"c:\test");
        }

        private void youtubeJarvisPicBtn_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://www.youtube.com/");
        }

        private void firefoxJarvisPicBtn_Click(object sender, EventArgs e)
        {
            Process.Start("firefox.exe");
        }

        private void fileExplorerJarvisPicBtn_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe");
        }

        private void myComputeJarvisPicBtn_Click(object sender, EventArgs e)
        {
            Process.Start("computer.exe");
        }

        private void internetExplorerJarvisPicBtn_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore.exe");
        }

        private void atozgamesJarvisPicBtn_Click(object sender, EventArgs e)
        {
            Process.Start("A to Z Quiz.exe");
        }

        private void gmailJarvisPicBtn_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://mail.google.com/");
        }

        private void musicFolderPicBtn_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Public\Music");
        }

        private void downloadJarvisPicBtn_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Public\Downloads");
        }

        private void pictureJarvisPicBtn_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Public\Pictures");
        }
    }
  }

