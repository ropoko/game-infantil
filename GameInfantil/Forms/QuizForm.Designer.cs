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
            this.RadioOption1 = new System.Windows.Forms.RadioButton();
            this.RadioOption2 = new System.Windows.Forms.RadioButton();
            this.RadioOption3 = new System.Windows.Forms.RadioButton();
            this.RadioOption4 = new System.Windows.Forms.RadioButton();
            this.ButtonNextQuestion = new System.Windows.Forms.Button();
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
            // RadioOption1
            // 
            this.RadioOption1.AutoSize = true;
            this.RadioOption1.Location = new System.Drawing.Point(147, 138);
            this.RadioOption1.Name = "RadioOption1";
            this.RadioOption1.Size = new System.Drawing.Size(94, 19);
            this.RadioOption1.TabIndex = 1;
            this.RadioOption1.TabStop = true;
            this.RadioOption1.Text = "radioButton1";
            this.RadioOption1.UseVisualStyleBackColor = true;
            // 
            // RadioOption2
            // 
            this.RadioOption2.AutoSize = true;
            this.RadioOption2.Location = new System.Drawing.Point(147, 177);
            this.RadioOption2.Name = "RadioOption2";
            this.RadioOption2.Size = new System.Drawing.Size(94, 19);
            this.RadioOption2.TabIndex = 2;
            this.RadioOption2.TabStop = true;
            this.RadioOption2.Text = "radioButton2";
            this.RadioOption2.UseVisualStyleBackColor = true;
            // 
            // RadioOption3
            // 
            this.RadioOption3.AutoSize = true;
            this.RadioOption3.Location = new System.Drawing.Point(147, 219);
            this.RadioOption3.Name = "RadioOption3";
            this.RadioOption3.Size = new System.Drawing.Size(94, 19);
            this.RadioOption3.TabIndex = 3;
            this.RadioOption3.TabStop = true;
            this.RadioOption3.Text = "radioButton3";
            this.RadioOption3.UseVisualStyleBackColor = true;
            // 
            // RadioOption4
            // 
            this.RadioOption4.AutoSize = true;
            this.RadioOption4.Location = new System.Drawing.Point(147, 258);
            this.RadioOption4.Name = "RadioOption4";
            this.RadioOption4.Size = new System.Drawing.Size(94, 19);
            this.RadioOption4.TabIndex = 4;
            this.RadioOption4.TabStop = true;
            this.RadioOption4.Text = "radioButton4";
            this.RadioOption4.UseVisualStyleBackColor = true;
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
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 406);
            this.Controls.Add(this.ButtonNextQuestion);
            this.Controls.Add(this.RadioOption4);
            this.Controls.Add(this.RadioOption3);
            this.Controls.Add(this.RadioOption2);
            this.Controls.Add(this.RadioOption1);
            this.Controls.Add(this.LabelQuestion);
            this.Name = "QuizForm";
            this.Text = "QuizForm";
            this.Load += new System.EventHandler(this.QuizForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelQuestion;
        private RadioButton RadioOption1;
        private RadioButton RadioOption2;
        private RadioButton RadioOption3;
        private RadioButton RadioOption4;
        private Button ButtonNextQuestion;
    }
}