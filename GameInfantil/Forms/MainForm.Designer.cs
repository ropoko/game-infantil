namespace GameInfantil
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ButtonChooseGame = new System.Windows.Forms.Button();
            this.ButtonHowToPlay = new System.Windows.Forms.Button();
            this.ButtonAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonChooseGame
            // 
            this.ButtonChooseGame.Location = new System.Drawing.Point(33, 378);
            this.ButtonChooseGame.Name = "ButtonChooseGame";
            this.ButtonChooseGame.Size = new System.Drawing.Size(178, 45);
            this.ButtonChooseGame.TabIndex = 0;
            this.ButtonChooseGame.Text = "Escolher Jogo";
            this.ButtonChooseGame.UseVisualStyleBackColor = true;
            this.ButtonChooseGame.Click += new System.EventHandler(this.ButtonChooseGame_Click);
            // 
            // ButtonHowToPlay
            // 
            this.ButtonHowToPlay.Location = new System.Drawing.Point(234, 378);
            this.ButtonHowToPlay.Name = "ButtonHowToPlay";
            this.ButtonHowToPlay.Size = new System.Drawing.Size(178, 45);
            this.ButtonHowToPlay.TabIndex = 1;
            this.ButtonHowToPlay.Text = "Como Jogar?";
            this.ButtonHowToPlay.UseVisualStyleBackColor = true;
            this.ButtonHowToPlay.Click += new System.EventHandler(this.ButtonHowToPlay_Click);
            // 
            // ButtonAbout
            // 
            this.ButtonAbout.Location = new System.Drawing.Point(463, 378);
            this.ButtonAbout.Name = "ButtonAbout";
            this.ButtonAbout.Size = new System.Drawing.Size(178, 45);
            this.ButtonAbout.TabIndex = 2;
            this.ButtonAbout.Text = "Sobre";
            this.ButtonAbout.UseVisualStyleBackColor = true;
            this.ButtonAbout.Click += new System.EventHandler(this.ButtonAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.ButtonAbout);
            this.Controls.Add(this.ButtonHowToPlay);
            this.Controls.Add(this.ButtonChooseGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Bem Vindo!";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button ButtonChooseGame;
        private Button ButtonHowToPlay;
        private Button ButtonAbout;
    }
}