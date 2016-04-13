﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
using System.IO;

namespace Sciencetific_Calc
{
    public partial class webBrowser : Form
    {

        public webBrowser()
        {
            InitializeComponent();
        }

        SpeechSynthesizer sSynth = new SpeechSynthesizer();
        PromptBuilder pBuilder = new PromptBuilder();
        SpeechRecognitionEngine sRecognize = new SpeechRecognitionEngine();

        history historyForm = new history();
        favorites favoritesForm = new favorites();

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            textBox1.Enabled = false;
            NavigateToPage();
        }

        public void NavigateTo(string site)
        {
            webBrowser1.Navigate(site);
        }
        private void NavigateToPage()
        {
            toolStripStatusLabel1.Text = "Navigation has started";
            webBrowser1.Navigate(textBox1.Text);
            StreamWriter historyFile = File.AppendText("write.txt");
            historyFile.WriteLine(textBox1.Text);
            historyFile.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                NavigateToPage();
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            button1.Enabled = true;
            textBox1.Enabled = true;
            toolStripStatusLabel1.Text = "Navigation complete";
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (e.CurrentProgress > 0 && e.MaximumProgress > 0)
            {
                toolStripProgressBar1.ProgressBar.Value = (int)(e.CurrentProgress * 100 / e.MaximumProgress);
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

        private void aToZGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("A to Z Quiz.exe");
        }

        private void carRacingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            carRacing popup = new carRacing();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by: Adam Alexander and Zachary Krause");
        }

        private void webStartSpeakBtn_Click(object sender, EventArgs e)
        {
            webStartSpeakBtn.Enabled = false;
            webStopSpeakBtn.Enabled = true;
            Choices sList = new Choices();
            sList.Add(new string[] { "google", "youtube", "twitter", "capital area career center", ".com"});
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
            if (e.Result.Text == "goolge")
            {
                webBrowser1.Navigate("https://www.google.com/");
            }
            else if (e.Result.Text == "youtube")
            {
                webBrowser1.Navigate("https://www.youtube.com/");
            }
            else if (e.Result.Text == "capital area career center")
            {
                webBrowser1.Navigate("http://www.inghamisd.org/cacc/");
            }
            else
            {
                textBox1.Text = textBox1.Text + " " + e.Result.Text.ToString();
            }
        }

        private void webStopSpeakBtn_Click(object sender, EventArgs e)
        {
            sRecognize.RecognizeAsyncStop();
            webStartSpeakBtn.Enabled = true;
            webStopSpeakBtn.Enabled = false;
        }

        private void homePicBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/");
        }

        private void refreshPicBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void backPicBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void forwardPicBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            historyForm.WriteHistory();
            DialogResult dialogresult = historyForm.ShowDialog();
        }

        private void favoritesBtn_Click(object sender, EventArgs e)
        {
            favoritesForm.WriteFavorites();
            DialogResult dialogresult = favoritesForm.ShowDialog();
        }

        private void addFavoritesBtn_Click(object sender, EventArgs e)
        {
            StreamWriter favoritesFile = File.AppendText("favoriters.txt");
            favoritesFile.WriteLine(textBox1.Text);
            favoritesFile.Close();
        }

        private void stopPicBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
            toolStripStatusLabel1.Text = "Stopped";
        }

        private void setStartPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter startPageFile = File.AppendText("favoriters.txt");
            startPageFile.WriteLine(textBox1.Text);
            startPageFile.Close();
        }

        private void webBrowser_Load(object sender, EventArgs e)
        {
            StreamReader startPageFile = new StreamReader("write.txt");

            string line;

            while (!startPageFile.EndOfStream)
            {
                line = startPageFile.ReadLine();
                webBrowser1.Navigate(line);
                textBox1.Text = line;
            }
            startPageFile.Close();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("");
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.GetText();
        }

        private void webBrowser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.H)
            {
                DialogResult dialogresult = historyForm.ShowDialog();
            }

            if (e.KeyChar == (char)ConsoleKey.F)
            {
                DialogResult dialogresult = favoritesForm.ShowDialog();
            }
        }
    }
}