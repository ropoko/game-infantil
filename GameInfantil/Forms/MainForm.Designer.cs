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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonCredits = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonChooseGame
            // 
            this.ButtonChooseGame.BackColor = System.Drawing.Color.Coral;
            this.ButtonChooseGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonChooseGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonChooseGame.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonChooseGame.Location = new System.Drawing.Point(33, 378);
            this.ButtonChooseGame.Name = "ButtonChooseGame";
            this.ButtonChooseGame.Size = new System.Drawing.Size(178, 45);
            this.ButtonChooseGame.TabIndex = 0;
            this.ButtonChooseGame.Text = "Escolher Jogo";
            this.ButtonChooseGame.UseVisualStyleBackColor = false;
            this.ButtonChooseGame.Click += new System.EventHandler(this.ButtonChooseGame_Click);
            // 
            // ButtonHowToPlay
            // 
            this.ButtonHowToPlay.BackColor = System.Drawing.Color.Coral;
            this.ButtonHowToPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHowToPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonHowToPlay.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonHowToPlay.Location = new System.Drawing.Point(234, 378);
            this.ButtonHowToPlay.Name = "ButtonHowToPlay";
            this.ButtonHowToPlay.Size = new System.Drawing.Size(178, 45);
            this.ButtonHowToPlay.TabIndex = 1;
            this.ButtonHowToPlay.Text = "Como Jogar?";
            this.ButtonHowToPlay.UseVisualStyleBackColor = false;
            this.ButtonHowToPlay.Click += new System.EventHandler(this.ButtonHowToPlay_Click);
            // 
            // ButtonAbout
            // 
            this.ButtonAbout.BackColor = System.Drawing.Color.Coral;
            this.ButtonAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAbout.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonAbout.Location = new System.Drawing.Point(463, 378);
            this.ButtonAbout.Name = "ButtonAbout";
            this.ButtonAbout.Size = new System.Drawing.Size(147, 45);
            this.ButtonAbout.TabIndex = 2;
            this.ButtonAbout.Text = "Sobre";
            this.ButtonAbout.UseVisualStyleBackColor = false;
            this.ButtonAbout.Click += new System.EventHandler(this.ButtonAbout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(272, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prevenção";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(234, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 58);
            this.label3.TabIndex = 5;
            this.label3.Text = "Queimaduras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(364, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 45);
            this.label2.TabIndex = 6;
            this.label2.Text = "de";
            // 
            // ButtonCredits
            // 
            this.ButtonCredits.BackColor = System.Drawing.Color.Coral;
            this.ButtonCredits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCredits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonCredits.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonCredits.Location = new System.Drawing.Point(616, 378);
            this.ButtonCredits.Name = "ButtonCredits";
            this.ButtonCredits.Size = new System.Drawing.Size(147, 45);
            this.ButtonCredits.TabIndex = 7;
            this.ButtonCredits.Text = "Créditos";
            this.ButtonCredits.UseVisualStyleBackColor = false;
            this.ButtonCredits.Click += new System.EventHandler(this.ButtonCredits_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.ButtonCredits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonAbout);
            this.Controls.Add(this.ButtonHowToPlay);
            this.Controls.Add(this.ButtonChooseGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bem Vindo!";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonChooseGame;
        private Button ButtonHowToPlay;
        private Button ButtonAbout;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button ButtonCredits;
    }
}