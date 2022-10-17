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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseGameForm));
            this.ButtonQuizGame = new System.Windows.Forms.Button();
            this.ButtonMemoryGame = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonQuizGame
            // 
            this.ButtonQuizGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonQuizGame.BackColor = System.Drawing.Color.Coral;
            this.ButtonQuizGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonQuizGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonQuizGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonQuizGame.Font = new System.Drawing.Font("Tahoma", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ButtonQuizGame.Location = new System.Drawing.Point(-2, 1);
            this.ButtonQuizGame.Name = "ButtonQuizGame";
            this.ButtonQuizGame.Size = new System.Drawing.Size(389, 420);
            this.ButtonQuizGame.TabIndex = 0;
            this.ButtonQuizGame.Text = "Quiz";
            this.ButtonQuizGame.UseVisualStyleBackColor = false;
            this.ButtonQuizGame.Click += new System.EventHandler(this.ButtonQuizGame_Click);
            // 
            // ButtonMemoryGame
            // 
            this.ButtonMemoryGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMemoryGame.BackColor = System.Drawing.Color.GreenYellow;
            this.ButtonMemoryGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMemoryGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonMemoryGame.Font = new System.Drawing.Font("Tahoma", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ButtonMemoryGame.Location = new System.Drawing.Point(385, 1);
            this.ButtonMemoryGame.Name = "ButtonMemoryGame";
            this.ButtonMemoryGame.Size = new System.Drawing.Size(401, 420);
            this.ButtonMemoryGame.TabIndex = 1;
            this.ButtonMemoryGame.Text = "Jogo da Memória";
            this.ButtonMemoryGame.UseVisualStyleBackColor = false;
            this.ButtonMemoryGame.Click += new System.EventHandler(this.ButtonMemoryGame_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 44);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChooseGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 418);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonMemoryGame);
            this.Controls.Add(this.ButtonQuizGame);
            this.Name = "ChooseGameForm";
            this.Text = "ChooseGameForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button ButtonQuizGame;
        private Button ButtonMemoryGame;
        private Button button1;
    }
}