using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMelody
{
    public partial class fMain : Form
    {
        fSettings fs = new fSettings();
        fGame fg = new fGame();
        public fMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            fs.ShowDialog();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            GameEngine.ReadSettings();
            GameEngine.ReadMusic();
            if (GameEngine.playList.Count == 0)
            {
                btnStart.BackColor = Color.Red;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (GameEngine.playList.Count != 0)
            {
                fg.ShowDialog();
            }

            else
            {
                MessageBox.Show("Not selected music files", "Guess Melody");
                GameEngine.buttonHighlight = true;
                fs.ShowDialog();
            }

        }

        private void fMain_Activated(object sender, EventArgs e)
        {
            if (GameEngine.playList.Count == 0)
            {
                btnStart.BackColor = Color.Red;
            }
        }
    }
}
