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

namespace GuessMelody
{
    public partial class fSettings : Form
    {
        void SetOld()
        {
            cbSubfolders.Checked = GameEngine.subFolders;
            cbGameDuration.Text = GameEngine.gameDuration.ToString();
            cbMusicDuration.Text = GameEngine.musicDuration.ToString();
            cbRandomStart.Checked = GameEngine.randomStart;
            tbPlayerName1.Text = GameEngine.playerName1;
            tbPlayerName2.Text = GameEngine.playerName2;
            cbAnswerPlayer1.Text = GameEngine.answerKey1.ToString();
            cbAnswerPlayer2.Text = GameEngine.answerKey2.ToString();

        }

        void SetNew()
        {
            GameEngine.subFolders = cbSubfolders.Checked;
            GameEngine.gameDuration = Convert.ToInt32(cbGameDuration.Text);
            GameEngine.musicDuration = Convert.ToInt32(cbMusicDuration.Text);
            GameEngine.randomStart = cbRandomStart.Checked;
            GameEngine.playerName1 = tbPlayerName1.Text;
            GameEngine.playerName2 = tbPlayerName2.Text;
            GameEngine.answerKey1 = Convert.ToChar(cbAnswerPlayer1.Text);
            GameEngine.answerKey2 = Convert.ToChar(cbAnswerPlayer2.Text);
            GameEngine.WriteSettings();
        }

        public fSettings()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetOld();
            this.Hide();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SetNew();
            GameEngine.WriteSettings();
            this.Hide();
        }

        private void btnChoseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] musicList = Directory.GetFiles(fbd.SelectedPath,"*.mp3", cbSubfolders.Checked?SearchOption.AllDirectories:SearchOption.TopDirectoryOnly);
                GameEngine.lastFolder = fbd.SelectedPath;
                lbMusicList.Items.Clear();
                lbMusicList.Items.AddRange(musicList);
                GameEngine.playList.Clear();
                GameEngine.playList.AddRange(musicList);
                GameEngine.buttonHighlight = false;
                btnChoseFolder.BackColor = SystemColors.Control;
                btnChoseFolder.BackColor = SystemColors.Control;
                fMain btnMagic = (fMain)Application.OpenForms["fMain"];
                btnMagic.btnStart.BackColor = Color.SlateBlue;
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbMusicList.Items.Clear();
            GameEngine.playList.Clear();
            GameEngine.lastFolder = "";
            GameEngine.buttonHighlight = true;

        }

        private void fSettings_Load(object sender, EventArgs e)
        {
            SetOld();
            lbMusicList.Items.Clear();
            lbMusicList.Items.AddRange(GameEngine.playList.ToArray());
        }

        private void fSettings_Activated(object sender, EventArgs e)
        {
            if (GameEngine.buttonHighlight)
            {
                btnChoseFolder.BackColor = Color.Red;
            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            cbGameDuration.Text = "120";
            cbMusicDuration.Text = "10";
            cbRandomStart.Checked = true;
            cbSubfolders.Checked = false;
            GameEngine.musicName = "";
            tbPlayerName1.Text = "Jack";
            tbPlayerName2.Text = "Suzie";
            cbAnswerPlayer1.Text = "A";
            cbAnswerPlayer2.Text = "L";
        }
    }
}
