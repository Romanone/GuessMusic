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
    public partial class fMessage : Form
    {
        int answerTime = 10;
        public fMessage()
        {
            InitializeComponent();
        }

        private void fMessage_Load(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer("Resources\\AnswerTime.wav");
            sp.Play();
            answerTime = 5;
            timer_Message.Start();

        }

        private void timer_Message_Tick(object sender, EventArgs e)
        {
            answerTime--;
            lblAnswerTime.Text = answerTime.ToString();
            if (answerTime == 0)
            {
                SoundPlayer sp = new SoundPlayer("Resources\\AnswerTimeOut.wav");
                timer_Message.Stop();
                //btnYes.Enabled = false;
                sp.Play();
            }


        }

        private void fMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer_Message.Stop();
        }

        private void lblMusicName_Click(object sender, EventArgs e)
        {
            var mp3file = TagLib.File.Create(GameEngine.musicName);
            if (mp3file.Tag.FirstAlbumArtist == null)
            {
                lblMusicName.Text = mp3file.Tag.FirstArtist + " - " + mp3file.Tag.Title;
            }
            else
            {
                lblMusicName.Text = mp3file.Tag.FirstAlbumArtist + " - " + mp3file.Tag.Title;
            }
        }
    }
}
