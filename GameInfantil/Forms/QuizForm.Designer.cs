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
            this.label1 = new System.Windows.Forms.Label();
            this.LabelPoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonHome)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelQuestion
            // 
            this.LabelQuestion.AutoSize = true;
            this.LabelQuestion.BackColor = System.Drawing.Color.Transparent;
            this.LabelQuestion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelQuestion.Location = new System.Drawing.Point(99, 127);
            this.LabelQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelQuestion.Name = "LabelQuestion";
            this.LabelQuestion.Size = new System.Drawing.Size(83, 32);
            this.LabelQuestion.TabIndex = 0;
            this.LabelQuestion.Text = "label1";
            // 
            // Option1
            // 
            this.Option1.AutoSize = true;
            this.Option1.BackColor = System.Drawing.Color.Transparent;
            this.Option1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Option1.Location = new System.Drawing.Point(266, 223);
            this.Option1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(172, 35);
            this.Option1.TabIndex = 1;
            this.Option1.TabStop = true;
            this.Option1.Text = "radioButton1";
            this.Option1.UseVisualStyleBackColor = false;
            // 
            // Option2
            // 
            this.Option2.AutoSize = true;
            this.Option2.BackColor = System.Drawing.Color.Transparent;
            this.Option2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Option2.Location = new System.Drawing.Point(266, 288);
            this.Option2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(172, 35);
            this.Option2.TabIndex = 2;
            this.Option2.TabStop = true;
            this.Option2.Text = "radioButton2";
            this.Option2.UseVisualStyleBackColor = false;
            // 
            // Option3
            // 
            this.Option3.AutoSize = true;
            this.Option3.BackColor = System.Drawing.Color.Transparent;
            this.Option3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Option3.Location = new System.Drawing.Point(266, 358);
            this.Option3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Option3.Name = "Option3";
            this.Option3.Size = new System.Drawing.Size(172, 35);
            this.Option3.TabIndex = 3;
            this.Option3.TabStop = true;
            this.Option3.Text = "radioButton3";
            this.Option3.UseVisualStyleBackColor = false;
            // 
            // Option4
            // 
            this.Option4.AutoSize = true;
            this.Option4.BackColor = System.Drawing.Color.Transparent;
            this.Option4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Option4.Location = new System.Drawing.Point(266, 423);
            this.Option4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Option4.Name = "Option4";
            this.Option4.Size = new System.Drawing.Size(172, 35);
            this.Option4.TabIndex = 4;
            this.Option4.TabStop = true;
            this.Option4.Text = "radioButton4";
            this.Option4.UseVisualStyleBackColor = false;
            // 
            // ButtonNextQuestion
            // 
            this.ButtonNextQuestion.BackColor = System.Drawing.Color.Coral;
            this.ButtonNextQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNextQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonNextQuestion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonNextQuestion.Location = new System.Drawing.Point(330, 550);
            this.ButtonNextQuestion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonNextQuestion.Name = "ButtonNextQuestion";
            this.ButtonNextQuestion.Size = new System.Drawing.Size(217, 72);
            this.ButtonNextQuestion.TabIndex = 5;
            this.ButtonNextQuestion.Text = "Próxima";
            this.ButtonNextQuestion.UseVisualStyleBackColor = false;
            this.ButtonNextQuestion.Click += new System.EventHandler(this.ButtonNextQuestion_Click);
            // 
            // ButtonHome
            // 
            this.ButtonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHome.Location = new System.Drawing.Point(17, 20);
            this.ButtonHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(53, 49);
            this.ButtonHome.TabIndex = 6;
            this.ButtonHome.TabStop = false;
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(763, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pontos:";
            // 
            // LabelPoints
            // 
            this.LabelPoints.AutoSize = true;
            this.LabelPoints.BackColor = System.Drawing.Color.Transparent;
            this.LabelPoints.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelPoints.Location = new System.Drawing.Point(864, 20);
            this.LabelPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPoints.Name = "LabelPoints";
            this.LabelPoints.Size = new System.Drawing.Size(79, 32);
            this.LabelPoints.TabIndex = 8;
            this.LabelPoints.Text = "label2";
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(977, 677);
            this.Controls.Add(this.LabelPoints);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonHome);
            this.Controls.Add(this.ButtonNextQuestion);
            this.Controls.Add(this.Option4);
            this.Controls.Add(this.Option3);
            this.Controls.Add(this.Option2);
            this.Controls.Add(this.Option1);
            this.Controls.Add(this.LabelQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "QuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private Label label1;
        private Label LabelPoints;
    }
}