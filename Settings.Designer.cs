namespace GuessMelody
{
    partial class fSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSettings));
            this.btnChoseFolder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbSubfolders = new System.Windows.Forms.CheckBox();
            this.lbMusicList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPlayerName2 = new System.Windows.Forms.TextBox();
            this.tbPlayerName1 = new System.Windows.Forms.TextBox();
            this.cbAnswerPlayer2 = new System.Windows.Forms.ComboBox();
            this.cbAnswerPlayer1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRandomStart = new System.Windows.Forms.CheckBox();
            this.cbMusicDuration = new System.Windows.Forms.ComboBox();
            this.cbGameDuration = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDefault = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChoseFolder
            // 
            this.btnChoseFolder.Location = new System.Drawing.Point(12, 243);
            this.btnChoseFolder.Name = "btnChoseFolder";
            this.btnChoseFolder.Size = new System.Drawing.Size(119, 23);
            this.btnChoseFolder.TabIndex = 1;
            this.btnChoseFolder.Text = "Chose folder...";
            this.btnChoseFolder.UseVisualStyleBackColor = true;
            this.btnChoseFolder.Click += new System.EventHandler(this.btnChoseFolder_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(137, 243);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(413, 354);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(559, 354);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(59, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbSubfolders
            // 
            this.cbSubfolders.AutoSize = true;
            this.cbSubfolders.Location = new System.Drawing.Point(490, 243);
            this.cbSubfolders.Name = "cbSubfolders";
            this.cbSubfolders.Size = new System.Drawing.Size(128, 17);
            this.cbSubfolders.TabIndex = 5;
            this.cbSubfolders.Text = "Search in subfolders?";
            this.cbSubfolders.UseVisualStyleBackColor = true;
            // 
            // lbMusicList
            // 
            this.lbMusicList.FormattingEnabled = true;
            this.lbMusicList.HorizontalScrollbar = true;
            this.lbMusicList.Location = new System.Drawing.Point(12, 12);
            this.lbMusicList.Name = "lbMusicList";
            this.lbMusicList.ScrollAlwaysVisible = true;
            this.lbMusicList.Size = new System.Drawing.Size(606, 225);
            this.lbMusicList.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbPlayerName2);
            this.groupBox1.Controls.Add(this.tbPlayerName1);
            this.groupBox1.Controls.Add(this.cbAnswerPlayer2);
            this.groupBox1.Controls.Add(this.cbAnswerPlayer1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbRandomStart);
            this.groupBox1.Controls.Add(this.cbMusicDuration);
            this.groupBox1.Controls.Add(this.cbGameDuration);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 105);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Answer key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Player name";
            // 
            // tbPlayerName2
            // 
            this.tbPlayerName2.Location = new System.Drawing.Point(255, 59);
            this.tbPlayerName2.MaxLength = 8;
            this.tbPlayerName2.Name = "tbPlayerName2";
            this.tbPlayerName2.Size = new System.Drawing.Size(62, 20);
            this.tbPlayerName2.TabIndex = 10;
            this.tbPlayerName2.Text = "Suzie";
            // 
            // tbPlayerName1
            // 
            this.tbPlayerName1.Location = new System.Drawing.Point(255, 33);
            this.tbPlayerName1.MaxLength = 8;
            this.tbPlayerName1.Name = "tbPlayerName1";
            this.tbPlayerName1.Size = new System.Drawing.Size(62, 20);
            this.tbPlayerName1.TabIndex = 9;
            this.tbPlayerName1.Text = "Jack";
            // 
            // cbAnswerPlayer2
            // 
            this.cbAnswerPlayer2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnswerPlayer2.FormattingEnabled = true;
            this.cbAnswerPlayer2.Items.AddRange(new object[] {
            "L",
            "O",
            "P",
            "K"});
            this.cbAnswerPlayer2.Location = new System.Drawing.Point(323, 59);
            this.cbAnswerPlayer2.Name = "cbAnswerPlayer2";
            this.cbAnswerPlayer2.Size = new System.Drawing.Size(62, 21);
            this.cbAnswerPlayer2.TabIndex = 8;
            // 
            // cbAnswerPlayer1
            // 
            this.cbAnswerPlayer1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnswerPlayer1.FormattingEnabled = true;
            this.cbAnswerPlayer1.Items.AddRange(new object[] {
            "A",
            "Q",
            "W",
            "E"});
            this.cbAnswerPlayer1.Location = new System.Drawing.Point(323, 32);
            this.cbAnswerPlayer1.Name = "cbAnswerPlayer1";
            this.cbAnswerPlayer1.Size = new System.Drawing.Size(62, 21);
            this.cbAnswerPlayer1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Player 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Player 1";
            // 
            // cbRandomStart
            // 
            this.cbRandomStart.AutoSize = true;
            this.cbRandomStart.Location = new System.Drawing.Point(9, 81);
            this.cbRandomStart.Name = "cbRandomStart";
            this.cbRandomStart.Size = new System.Drawing.Size(156, 17);
            this.cbRandomStart.TabIndex = 4;
            this.cbRandomStart.Text = "Melody from random place?";
            this.cbRandomStart.UseVisualStyleBackColor = true;
            // 
            // cbMusicDuration
            // 
            this.cbMusicDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMusicDuration.FormattingEnabled = true;
            this.cbMusicDuration.Items.AddRange(new object[] {
            "5",
            "10",
            "15"});
            this.cbMusicDuration.Location = new System.Drawing.Point(93, 54);
            this.cbMusicDuration.Name = "cbMusicDuration";
            this.cbMusicDuration.Size = new System.Drawing.Size(73, 21);
            this.cbMusicDuration.TabIndex = 3;
            // 
            // cbGameDuration
            // 
            this.cbGameDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGameDuration.FormattingEnabled = true;
            this.cbGameDuration.Items.AddRange(new object[] {
            "60",
            "120",
            "180",
            "240",
            "360"});
            this.cbGameDuration.Location = new System.Drawing.Point(93, 27);
            this.cbGameDuration.Name = "cbGameDuration";
            this.cbGameDuration.Size = new System.Drawing.Size(73, 21);
            this.cbGameDuration.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time for answer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game duration";
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(494, 354);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(59, 23);
            this.btnDefault.TabIndex = 13;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // fSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(630, 386);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbMusicList);
            this.Controls.Add(this.cbSubfolders);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnChoseFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Activated += new System.EventHandler(this.fSettings_Activated);
            this.Load += new System.EventHandler(this.fSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnChoseFolder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbSubfolders;
        private System.Windows.Forms.ListBox lbMusicList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbRandomStart;
        private System.Windows.Forms.ComboBox cbMusicDuration;
        private System.Windows.Forms.ComboBox cbGameDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAnswerPlayer2;
        private System.Windows.Forms.ComboBox cbAnswerPlayer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPlayerName2;
        private System.Windows.Forms.TextBox tbPlayerName1;
        private System.Windows.Forms.Button btnDefault;
    }
}