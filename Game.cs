using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GuessMelody
{
    public partial class fGame : Form
    {
        Random rnd = new Random();
        int musicDuration = GameEngine.musicDuration;
        bool[] answerEnabled = new bool[2];

        public fGame()
        {
            InitializeComponent();
        }

        void MakeMusic()
        {
            if (GameEngine.playList.Count == 0) GameOver();
            else
            {
                SoundPlayer sp = new SoundPlayer("Resources\\beep.wav");
                sp.Play();
                musicDuration = GameEngine.musicDuration;
                int n = rnd.Next(0, GameEngine.playList.Count());
                WMP.URL = GameEngine.playList[n];
                GameEngine.musicName =WMP.URL;
                WMP.Ctlcontrols.play();
                GameEngine.playList.RemoveAt(n);
                lblMusicCounter.Text = GameEngine.playList.Count().ToString();
                answerEnabled[0] = true;
                answerEnabled[1] = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(GameEngine.playList.Count() > 0)
            {
                btnNext.Text = "Next";
                timer1.Start();
                MakeMusic();
            }

            else if (GameEngine.playList.Count() == 0)
            {
                GameOver();
            }


        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            lblMusicDuration.Text = musicDuration.ToString();
            lblMusicCounter.Text = GameEngine.playList.Count().ToString();
            lblPlayer1.Text = GameEngine.playerName1.ToString();
            lblPlayer2.Text = GameEngine.playerName2.ToString();
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = GameEngine.gameDuration;
            Clear();
        }

        void GameOver()
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
            if (Convert.ToInt32(lblPlayerPoint1.Text) > Convert.ToInt32(lblPlayerPoint2.Text))
            {
                lblGameOver.Text = string.Format("{0} WIN! With {1} correct answer.",lblPlayer1.Text, lblPlayerPoint1.Text);
            }
            else if (Convert.ToInt32(lblPlayerPoint2.Text) > Convert.ToInt32(lblPlayerPoint1.Text))
            {
                lblGameOver.Text = string.Format("{0} WIN! With {1} correct answer.", lblPlayer2.Text, lblPlayerPoint2.Text);
            }
            else
            {
                lblGameOver.Text = string.Format("No winner here! Two players have given {0} correct answers.", lblPlayerPoint1.Text);
            }
            lblGameOver.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            musicDuration--;
            lblMusicDuration.Text = musicDuration.ToString();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                GameOver();
                return;
            }

            if (musicDuration == 0 && GameEngine.playList.Count > 0) MakeMusic();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            GamePause();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            GamePlay();
        }

        void GamePause()
        {
            timer1.Stop();
            WMP.Ctlcontrols.pause();
        }

        void GamePlay()
        {
            timer1.Start();
            WMP.Ctlcontrols.play();
        }

        private void fGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (!timer1.Enabled) return;
            if (answerEnabled[0] && e.KeyData == (Keys)GameEngine.answerKey1)
            {
                GamePause();
                fMessage fm = new fMessage();
                fm.lblPlayerName.Text = GameEngine.playerName1;
                answerEnabled[0] = false;
                if (fm.ShowDialog() == DialogResult.Yes)
                {
                    lblPlayerPoint1.Text = Convert.ToString(Convert.ToInt32(lblPlayerPoint1.Text) + 1);
                    MakeMusic();
                }
                GamePlay();
            }

            if (answerEnabled[1] && e.KeyData == (Keys)GameEngine.answerKey2)
            {
                GamePause();
                fMessage fm = new fMessage();
                fm.lblPlayerName.Text = GameEngine.playerName2;
                answerEnabled[1] = false;
                if (fm.ShowDialog() == DialogResult.Yes)
                {
                    lblPlayerPoint2.Text = Convert.ToString(Convert.ToInt32(lblPlayerPoint2.Text) + 1);
                    MakeMusic();
                }
                GamePlay();
            }
        }

        private void WMP_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (GameEngine.randomStart)
            {
                if(WMP.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                {
                    WMP.Ctlcontrols.currentPosition = rnd.Next(0, (int)WMP.currentMedia.duration - (GameEngine.musicDuration + 10));
                }
            }
        }

        private void lblPlayerPoint1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                (sender as Label).Text = Convert.ToString(Convert.ToInt32((sender as Label).Text) + 1);
            }
            if (e.Button == MouseButtons.Right)
            {
                (sender as Label).Text = Convert.ToString(Convert.ToInt32((sender as Label).Text) - 1);
            }
        }

        void Clear()
        {
            lblPlayerPoint1.Text = "0";
            lblPlayerPoint2.Text = "0";
            lblGameOver.Visible = false;
        }

        private void btnClearResult_Click(object sender, EventArgs e)
        {
            Clear();
        }

    }
}
