namespace GuessMelody
{
    partial class fMessage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMessage));
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblAnswerTime = new System.Windows.Forms.Label();
            this.timer_Message = new System.Windows.Forms.Timer(this.components);
            this.lblMusicName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnYes
            // 
            this.btnYes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnYes.Location = new System.Drawing.Point(101, 278);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(183, 96);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = false;
            // 
            // btnNo
            // 
            this.btnNo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNo.Location = new System.Drawing.Point(347, 278);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(183, 96);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPlayerName.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayerName.Location = new System.Drawing.Point(186, 9);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(258, 69);
            this.lblPlayerName.TabIndex = 2;
            this.lblPlayerName.Text = "Player";
            this.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAnswerTime
            // 
            this.lblAnswerTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAnswerTime.AutoSize = true;
            this.lblAnswerTime.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnswerTime.Location = new System.Drawing.Point(281, 134);
            this.lblAnswerTime.Name = "lblAnswerTime";
            this.lblAnswerTime.Size = new System.Drawing.Size(68, 69);
            this.lblAnswerTime.TabIndex = 3;
            this.lblAnswerTime.Text = "5";
            // 
            // timer_Message
            // 
            this.timer_Message.Interval = 1000;
            this.timer_Message.Tick += new System.EventHandler(this.timer_Message_Tick);
            // 
            // lblMusicName
            // 
            this.lblMusicName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMusicName.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMusicName.Location = new System.Drawing.Point(-11, 253);
            this.lblMusicName.Name = "lblMusicName";
            this.lblMusicName.Size = new System.Drawing.Size(653, 22);
            this.lblMusicName.TabIndex = 4;
            this.lblMusicName.Text = "Click to show answer";
            this.lblMusicName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMusicName.Click += new System.EventHandler(this.lblMusicName_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(217, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "Right?";
            // 
            // fMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 386);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMusicName);
            this.Controls.Add(this.lblAnswerTime);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Answer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fMessage_FormClosed);
            this.Load += new System.EventHandler(this.fMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        public System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblAnswerTime;
        private System.Windows.Forms.Timer timer_Message;
        private System.Windows.Forms.Label lblMusicName;
        private System.Windows.Forms.Label label1;
    }
}