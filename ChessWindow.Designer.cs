namespace Chess
{
    partial class Chess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chess));
            this.RestartButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Undo = new System.Windows.Forms.PictureBox();
            this.GameState = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WhiteTimer = new System.Windows.Forms.Label();
            this.TimeButton = new System.Windows.Forms.Button();
            this.BlackTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SeeA1 = new Guna.UI2.WinForms.Guna2Button();
            this.SeeA2 = new Guna.UI2.WinForms.Guna2Button();
            this.Music = new System.Windows.Forms.PictureBox();
            this.Music2 = new System.Windows.Forms.PictureBox();
            this.Player2Avatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Player1Avatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Sounds = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Undo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Music)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Music2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sounds)).BeginInit();
            this.SuspendLayout();
            // 
            // RestartButton
            // 
            this.RestartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RestartButton.Font = new System.Drawing.Font("Orbitron", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartButton.Location = new System.Drawing.Point(741, 270);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(65, 23);
            this.RestartButton.TabIndex = 0;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Chess.Properties.Resources.CantRedo;
            this.pictureBox2.Location = new System.Drawing.Point(780, 226);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Undo
            // 
            this.Undo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Undo.Image = global::Chess.Properties.Resources.undoArrrow;
            this.Undo.Location = new System.Drawing.Point(733, 226);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(32, 26);
            this.Undo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Undo.TabIndex = 3;
            this.Undo.TabStop = false;
            // 
            // GameState
            // 
            this.GameState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameState.AutoSize = true;
            this.GameState.BackColor = System.Drawing.Color.Transparent;
            this.GameState.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameState.ForeColor = System.Drawing.Color.OliveDrab;
            this.GameState.Location = new System.Drawing.Point(706, 441);
            this.GameState.Name = "GameState";
            this.GameState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GameState.Size = new System.Drawing.Size(94, 20);
            this.GameState.TabIndex = 2;
            this.GameState.Text = "NORMAL";
            this.GameState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GameState.Click += new System.EventHandler(this.GameState_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Orbitron", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(728, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "White";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Orbitron", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(728, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Black";
            // 
            // WhiteTimer
            // 
            this.WhiteTimer.AutoSize = true;
            this.WhiteTimer.BackColor = System.Drawing.Color.PapayaWhip;
            this.WhiteTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhiteTimer.Location = new System.Drawing.Point(776, 349);
            this.WhiteTimer.Name = "WhiteTimer";
            this.WhiteTimer.Size = new System.Drawing.Size(55, 22);
            this.WhiteTimer.TabIndex = 2;
            this.WhiteTimer.Text = "00:00";
            // 
            // TimeButton
            // 
            this.TimeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TimeButton.Font = new System.Drawing.Font("Orbitron", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeButton.Location = new System.Drawing.Point(752, 374);
            this.TimeButton.Name = "TimeButton";
            this.TimeButton.Size = new System.Drawing.Size(56, 23);
            this.TimeButton.TabIndex = 1;
            this.TimeButton.Text = "Start";
            this.TimeButton.UseVisualStyleBackColor = true;
            // 
            // BlackTimer
            // 
            this.BlackTimer.AutoSize = true;
            this.BlackTimer.BackColor = System.Drawing.Color.PapayaWhip;
            this.BlackTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlackTimer.Location = new System.Drawing.Point(776, 306);
            this.BlackTimer.Name = "BlackTimer";
            this.BlackTimer.Size = new System.Drawing.Size(55, 22);
            this.BlackTimer.TabIndex = 0;
            this.BlackTimer.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            // 
            // SeeA1
            // 
            this.SeeA1.BorderColor = System.Drawing.Color.DimGray;
            this.SeeA1.BorderRadius = 10;
            this.SeeA1.BorderThickness = 1;
            this.SeeA1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SeeA1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SeeA1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SeeA1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SeeA1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SeeA1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SeeA1.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeeA1.ForeColor = System.Drawing.Color.White;
            this.SeeA1.Location = new System.Drawing.Point(719, 640);
            this.SeeA1.Name = "SeeA1";
            this.SeeA1.Size = new System.Drawing.Size(112, 27);
            this.SeeA1.TabIndex = 6;
            this.SeeA1.Text = "PLAYER2";
            this.SeeA1.Click += new System.EventHandler(this.SeeA1_Click);
            // 
            // SeeA2
            // 
            this.SeeA2.BorderColor = System.Drawing.Color.DimGray;
            this.SeeA2.BorderRadius = 10;
            this.SeeA2.BorderThickness = 1;
            this.SeeA2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SeeA2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SeeA2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SeeA2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SeeA2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SeeA2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SeeA2.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeeA2.ForeColor = System.Drawing.Color.White;
            this.SeeA2.Location = new System.Drawing.Point(720, 128);
            this.SeeA2.Name = "SeeA2";
            this.SeeA2.Size = new System.Drawing.Size(111, 27);
            this.SeeA2.TabIndex = 9;
            this.SeeA2.Text = "PLAYER1";
            this.SeeA2.Click += new System.EventHandler(this.SeeA2_Click);
            // 
            // Music
            // 
            this.Music.BackColor = System.Drawing.Color.Transparent;
            this.Music.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Music.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Music.Image = global::Chess.Properties.Resources.mute;
            this.Music.Location = new System.Drawing.Point(764, 170);
            this.Music.Name = "Music";
            this.Music.Size = new System.Drawing.Size(36, 38);
            this.Music.TabIndex = 12;
            this.Music.TabStop = false;
            this.Music.Visible = false;
            this.Music.Click += new System.EventHandler(this.Music_Click);
            // 
            // Music2
            // 
            this.Music2.BackColor = System.Drawing.Color.Transparent;
            this.Music2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Music2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Music2.Image = global::Chess.Properties.Resources.speaker;
            this.Music2.Location = new System.Drawing.Point(764, 170);
            this.Music2.Name = "Music2";
            this.Music2.Size = new System.Drawing.Size(36, 38);
            this.Music2.TabIndex = 10;
            this.Music2.TabStop = false;
            this.Music2.Click += new System.EventHandler(this.Music2_Click);
            // 
            // Player2Avatar
            // 
            this.Player2Avatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Player2Avatar.ImageRotate = 0F;
            this.Player2Avatar.Location = new System.Drawing.Point(721, 524);
            this.Player2Avatar.Name = "Player2Avatar";
            this.Player2Avatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Player2Avatar.Size = new System.Drawing.Size(110, 110);
            this.Player2Avatar.TabIndex = 8;
            this.Player2Avatar.TabStop = false;
            this.Player2Avatar.Click += new System.EventHandler(this.Player2Avatar_Click);
            // 
            // Player1Avatar
            // 
            this.Player1Avatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Player1Avatar.ImageRotate = 0F;
            this.Player1Avatar.Location = new System.Drawing.Point(721, 12);
            this.Player1Avatar.Name = "Player1Avatar";
            this.Player1Avatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Player1Avatar.Size = new System.Drawing.Size(110, 110);
            this.Player1Avatar.TabIndex = 7;
            this.Player1Avatar.TabStop = false;
            this.Player1Avatar.Click += new System.EventHandler(this.Player1Avatar_Click);
            // 
            // Sounds
            // 
            this.Sounds.Enabled = true;
            this.Sounds.Location = new System.Drawing.Point(721, 161);
            this.Sounds.Name = "Sounds";
            this.Sounds.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Sounds.OcxState")));
            this.Sounds.Size = new System.Drawing.Size(75, 23);
            this.Sounds.TabIndex = 11;
            this.Sounds.Visible = false;
            // 
            // Chess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(844, 680);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.GameState);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Music);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Sounds);
            this.Controls.Add(this.WhiteTimer);
            this.Controls.Add(this.TimeButton);
            this.Controls.Add(this.Music2);
            this.Controls.Add(this.BlackTimer);
            this.Controls.Add(this.SeeA2);
            this.Controls.Add(this.Player2Avatar);
            this.Controls.Add(this.Player1Avatar);
            this.Controls.Add(this.SeeA1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Chess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chess";
            this.Load += new System.EventHandler(this.Chess_Load);
            this.ResizeBegin += new System.EventHandler(this.Chess_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Chess_ResizeEnd);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Chess_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Undo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Music)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Music2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sounds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RestartButton;
        public System.Windows.Forms.Label GameState;
        private System.Windows.Forms.Label BlackTimer;
        private System.Windows.Forms.Button TimeButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label WhiteTimer;
        private System.Windows.Forms.PictureBox Undo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button SeeA1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Player1Avatar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Player2Avatar;
        private Guna.UI2.WinForms.Guna2Button SeeA2;
        private System.Windows.Forms.PictureBox Music2;
        private AxWMPLib.AxWindowsMediaPlayer Sounds;
        private System.Windows.Forms.PictureBox Music;
    }
}

