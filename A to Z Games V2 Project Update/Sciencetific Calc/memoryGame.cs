using Sciencetific_Calc.Properties;
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
    public partial class memoryGame : Form
    {
        private bool _allowClick = true;
        private PictureBox _firstGuess;
        private readonly Random _random = new Random();
        private readonly Timer _clickTimer = new Timer();
        int ticks = 30;
        readonly Timer timer = new Timer { Interval = 1000 };

        public memoryGame()
        {
            InitializeComponent();
            SetRandomImages();
            HideImages();
            StartGameTimer();
            _clickTimer.Interval = 1000;
            _clickTimer.Tick += _clickTimer_Tick;
        }

        private PictureBox[] PictureBoxs
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }

        private IEnumerable<Image> Images
        {
            get
            {
                return new Image[]
                {
                    Resources.chibi_nagisa,
                    Resources.chibi_asuna,
                    Resources.chibi_fuu,
                    Resources.chibi_hinata,
                    Resources.chibi_kyou,
                    Resources.chibi_levy,
                    Resources.chibi_sinon,
                    Resources.chibi_wendy
                };
            }
        }

        private void StartGameTimer()
        {
            timer.Start();
            timer.Tick += delegate
            {
                ticks--;
                if (ticks == -1)
                {
                    timer.Stop();
                    MessageBox.Show("Times up.", "Memory Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                var time = TimeSpan.FromSeconds(ticks);
                lblTime.Text = "00:" + time.ToString("ss");
            };
        }

        private void ResetImages()
        {
            foreach(var pic in PictureBoxs)
            {
                pic.Tag = null;
                pic.Visible = true;
            }
            HideImages();
            SetRandomImages();
            ticks = 30;
            timer.Start();
        }

        private void HideImages()
        {
            foreach (var pic in PictureBoxs)
            {
                pic.Image = Resources.question_mark;
            }
        }

        private PictureBox GetFreeSpot()
        {
            int num;
            do
            {
                num = _random.Next(0, PictureBoxs.Count());
            }
            while (PictureBoxs[num].Tag != null);
            return PictureBoxs[num];
        }

        private void SetRandomImages()
        {
            foreach(var image in Images)
            {
                GetFreeSpot().Tag = image;
                GetFreeSpot().Tag = image;
            }
        }

        private void ClickImage(object sender, EventArgs e)
        {
            if (!_allowClick) return;
            var pic = (PictureBox)sender;
            if(_firstGuess == null)
            {
                _firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }
            pic.Image = (Image)pic.Tag;
            if(pic.Image == _firstGuess.Image && pic != _firstGuess)
            {
                pic.Visible = _firstGuess.Visible = false;
                {
                    _firstGuess = pic;
                }
                HideImages();
            }
            else
            {
                _allowClick = false;
                _clickTimer.Start();
            }
            _firstGuess = null;
            if (PictureBoxs.Any(p => p.Visible)) return;
            MessageBox.Show("You Won.", "Memory Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetImages();
        }

        private void _clickTimer_Tick(object sender, EventArgs e)
        {
            HideImages();
            _allowClick = true;
            _clickTimer.Stop();
        }
    }
}
