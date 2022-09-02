namespace Maze_Game
{
    partial class Scare
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
            this.endGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // endGame
            // 
            this.endGame.Location = new System.Drawing.Point(13, 13);
            this.endGame.Name = "endGame";
            this.endGame.Size = new System.Drawing.Size(75, 23);
            this.endGame.TabIndex = 0;
            this.endGame.Text = "Çıkış";
            this.endGame.UseVisualStyleBackColor = true;
            this.endGame.Click += new System.EventHandler(this.CloseWindowsEvent);
            // 
            // Scare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maze_Game.Properties.Resources.scaryEyes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 537);
            this.Controls.Add(this.endGame);
            this.Name = "Scare";
            this.Text = "Scare";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button endGame;
    }
}