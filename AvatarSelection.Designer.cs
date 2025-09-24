namespace Chess
{
    partial class AvatarSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvatarSelection));
            this.label1 = new System.Windows.Forms.Label();
            this.ApplyButtons = new System.Windows.Forms.Button();
            this.PREVIEW = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.LeftArrows = new System.Windows.Forms.Button();
            this.RightArrows = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PREVIEW)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orbitron", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select an Avatar";
            // 
            // ApplyButtons
            // 
            this.ApplyButtons.BackColor = System.Drawing.Color.White;
            this.ApplyButtons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApplyButtons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyButtons.Font = new System.Drawing.Font("Orbitron", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyButtons.ForeColor = System.Drawing.Color.Black;
            this.ApplyButtons.Location = new System.Drawing.Point(109, 200);
            this.ApplyButtons.Name = "ApplyButtons";
            this.ApplyButtons.Size = new System.Drawing.Size(84, 40);
            this.ApplyButtons.TabIndex = 8;
            this.ApplyButtons.Text = "Apply";
            this.ApplyButtons.UseVisualStyleBackColor = false;
            // 
            // PREVIEW
            // 
            this.PREVIEW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PREVIEW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PREVIEW.ImageRotate = 0F;
            this.PREVIEW.Location = new System.Drawing.Point(96, 75);
            this.PREVIEW.Name = "PREVIEW";
            this.PREVIEW.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PREVIEW.Size = new System.Drawing.Size(110, 110);
            this.PREVIEW.TabIndex = 11;
            this.PREVIEW.TabStop = false;
            // 
            // LeftArrows
            // 
            this.LeftArrows.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LeftArrows.BackgroundImage")));
            this.LeftArrows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftArrows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftArrows.Location = new System.Drawing.Point(30, 104);
            this.LeftArrows.Name = "LeftArrows";
            this.LeftArrows.Size = new System.Drawing.Size(60, 57);
            this.LeftArrows.TabIndex = 10;
            this.LeftArrows.UseVisualStyleBackColor = true;
            // 
            // RightArrows
            // 
            this.RightArrows.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RightArrows.BackgroundImage")));
            this.RightArrows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RightArrows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RightArrows.Location = new System.Drawing.Point(212, 104);
            this.RightArrows.Name = "RightArrows";
            this.RightArrows.Size = new System.Drawing.Size(60, 57);
            this.RightArrows.TabIndex = 6;
            this.RightArrows.UseVisualStyleBackColor = true;
            // 
            // AvatarSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(317, 305);
            this.Controls.Add(this.PREVIEW);
            this.Controls.Add(this.LeftArrows);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApplyButtons);
            this.Controls.Add(this.RightArrows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AvatarSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AvatarSelection";
            ((System.ComponentModel.ISupportInitialize)(this.PREVIEW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LeftArrows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ApplyButtons;
        private System.Windows.Forms.Button RightArrows;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PREVIEW;
    }
}