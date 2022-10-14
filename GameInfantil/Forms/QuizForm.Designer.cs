namespace GameInfantil.Forms
{
    partial class QuizForm
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
            this.LabelQuestion = new System.Windows.Forms.Label();
            this.Option1 = new System.Windows.Forms.RadioButton();
            this.Option2 = new System.Windows.Forms.RadioButton();
            this.Option3 = new System.Windows.Forms.RadioButton();
            this.Option4 = new System.Windows.Forms.RadioButton();
            this.ButtonNextQuestion = new System.Windows.Forms.Button();
            this.ButtonHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonHome)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelQuestion
            // 
            this.LabelQuestion.AutoSize = true;
            this.LabelQuestion.Location = new System.Drawing.Point(147, 68);
            this.LabelQuestion.Name = "LabelQuestion";
            this.LabelQuestion.Size = new System.Drawing.Size(38, 15);
            this.LabelQuestion.TabIndex = 0;
            this.LabelQuestion.Text = "label1";
            // 
            // Option1
            // 
            this.Option1.AutoSize = true;
            this.Option1.Location = new System.Drawing.Point(147, 138);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(94, 19);
            this.Option1.TabIndex = 1;
            this.Option1.TabStop = true;
            this.Option1.Text = "radioButton1";
            this.Option1.UseVisualStyleBackColor = true;
            // 
            // Option2
            // 
            this.Option2.AutoSize = true;
            this.Option2.Location = new System.Drawing.Point(147, 177);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(94, 19);
            this.Option2.TabIndex = 2;
            this.Option2.TabStop = true;
            this.Option2.Text = "radioButton2";
            this.Option2.UseVisualStyleBackColor = true;
            // 
            // Option3
            // 
            this.Option3.AutoSize = true;
            this.Option3.Location = new System.Drawing.Point(147, 219);
            this.Option3.Name = "Option3";
            this.Option3.Size = new System.Drawing.Size(94, 19);
            this.Option3.TabIndex = 3;
            this.Option3.TabStop = true;
            this.Option3.Text = "radioButton3";
            this.Option3.UseVisualStyleBackColor = true;
            // 
            // Option4
            // 
            this.Option4.AutoSize = true;
            this.Option4.Location = new System.Drawing.Point(147, 258);
            this.Option4.Name = "Option4";
            this.Option4.Size = new System.Drawing.Size(94, 19);
            this.Option4.TabIndex = 4;
            this.Option4.TabStop = true;
            this.Option4.Text = "radioButton4";
            this.Option4.UseVisualStyleBackColor = true;
            // 
            // ButtonNextQuestion
            // 
            this.ButtonNextQuestion.Location = new System.Drawing.Point(248, 335);
            this.ButtonNextQuestion.Name = "ButtonNextQuestion";
            this.ButtonNextQuestion.Size = new System.Drawing.Size(135, 41);
            this.ButtonNextQuestion.TabIndex = 5;
            this.ButtonNextQuestion.Text = "Próxima";
            this.ButtonNextQuestion.UseVisualStyleBackColor = true;
            this.ButtonNextQuestion.Click += new System.EventHandler(this.ButtonNextQuestion_Click);
            // 
            // ButtonHome
            // 
            this.ButtonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHome.Location = new System.Drawing.Point(12, 12);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(30, 30);
            this.ButtonHome.TabIndex = 6;
            this.ButtonHome.TabStop = false;
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 406);
            this.Controls.Add(this.ButtonHome);
            this.Controls.Add(this.ButtonNextQuestion);
            this.Controls.Add(this.Option4);
            this.Controls.Add(this.Option3);
            this.Controls.Add(this.Option2);
            this.Controls.Add(this.Option1);
            this.Controls.Add(this.LabelQuestion);
            this.Name = "QuizForm";
            this.Text = "QuizForm";
            this.Load += new System.EventHandler(this.QuizForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelQuestion;
        private RadioButton Option1;
        private RadioButton Option2;
        private RadioButton Option3;
        private RadioButton Option4;
        private Button ButtonNextQuestion;
        private PictureBox ButtonHome;
    }
}