namespace GameInfantil.Forms
{
    partial class ChooseGameForm
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
            this.ButtonQuizGame = new System.Windows.Forms.Button();
            this.ButtonMemoryGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonQuizGame
            // 
            this.ButtonQuizGame.Location = new System.Drawing.Point(81, 118);
            this.ButtonQuizGame.Name = "ButtonQuizGame";
            this.ButtonQuizGame.Size = new System.Drawing.Size(261, 145);
            this.ButtonQuizGame.TabIndex = 0;
            this.ButtonQuizGame.Text = "Quiz";
            this.ButtonQuizGame.UseVisualStyleBackColor = true;
            this.ButtonQuizGame.Click += new System.EventHandler(this.ButtonQuizGame_Click);
            // 
            // ButtonMemoryGame
            // 
            this.ButtonMemoryGame.Location = new System.Drawing.Point(432, 118);
            this.ButtonMemoryGame.Name = "ButtonMemoryGame";
            this.ButtonMemoryGame.Size = new System.Drawing.Size(261, 145);
            this.ButtonMemoryGame.TabIndex = 1;
            this.ButtonMemoryGame.Text = "Jogo da Memória";
            this.ButtonMemoryGame.UseVisualStyleBackColor = true;
            this.ButtonMemoryGame.Click += new System.EventHandler(this.ButtonMemoryGame_Click);
            // 
            // ChooseGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 418);
            this.Controls.Add(this.ButtonMemoryGame);
            this.Controls.Add(this.ButtonQuizGame);
            this.Name = "ChooseGameForm";
            this.Text = "ChooseGameForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button ButtonQuizGame;
        private Button ButtonMemoryGame;
    }
}