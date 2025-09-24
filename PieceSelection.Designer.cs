namespace Chess
{
    partial class PieceSelection
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
            this.ApplyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LeftArrow = new System.Windows.Forms.Button();
            this.Preview = new System.Windows.Forms.PictureBox();
            this.RightArrow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Preview)).BeginInit();
            this.SuspendLayout();
            // 
            // ApplyButton
            // 
            this.ApplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyButton.Font = new System.Drawing.Font("Orbitron", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyButton.Location = new System.Drawing.Point(55, 124);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(71, 26);
            this.ApplyButton.TabIndex = 3;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orbitron", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select a Piece";
            // 
            // LeftArrow
            // 
            this.LeftArrow.BackgroundImage = global::Chess.Properties.Resources.undoArrrow;
            this.LeftArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftArrow.Location = new System.Drawing.Point(21, 74);
            this.LeftArrow.Name = "LeftArrow";
            this.LeftArrow.Size = new System.Drawing.Size(33, 35);
            this.LeftArrow.TabIndex = 5;
            this.LeftArrow.UseVisualStyleBackColor = true;
            // 
            // Preview
            // 
            this.Preview.Location = new System.Drawing.Point(60, 58);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(60, 60);
            this.Preview.TabIndex = 2;
            this.Preview.TabStop = false;
            // 
            // RightArrow
            // 
            this.RightArrow.BackgroundImage = global::Chess.Properties.Resources.redoArrow;
            this.RightArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RightArrow.Location = new System.Drawing.Point(126, 74);
            this.RightArrow.Name = "RightArrow";
            this.RightArrow.Size = new System.Drawing.Size(35, 35);
            this.RightArrow.TabIndex = 1;
            this.RightArrow.UseVisualStyleBackColor = true;
            // 
            // PieceSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 169);
            this.Controls.Add(this.LeftArrow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.Preview);
            this.Controls.Add(this.RightArrow);
            this.MaximumSize = new System.Drawing.Size(191, 216);
            this.MinimumSize = new System.Drawing.Size(191, 216);
            this.Name = "PieceSelection";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RightArrow;
        private System.Windows.Forms.PictureBox Preview;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LeftArrow;
    }
}