namespace GameInfantil.Forms
{
    partial class FinishForm
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
            this.LabelFinishMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelFinishMessage
            // 
            this.LabelFinishMessage.AutoSize = true;
            this.LabelFinishMessage.BackColor = System.Drawing.Color.Transparent;
            this.LabelFinishMessage.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelFinishMessage.Location = new System.Drawing.Point(74, 65);
            this.LabelFinishMessage.Name = "LabelFinishMessage";
            this.LabelFinishMessage.Size = new System.Drawing.Size(133, 45);
            this.LabelFinishMessage.TabIndex = 0;
            this.LabelFinishMessage.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(183, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sua pontuação é de:";
            // 
            // LabelScore
            // 
            this.LabelScore.AutoSize = true;
            this.LabelScore.BackColor = System.Drawing.Color.Transparent;
            this.LabelScore.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelScore.Location = new System.Drawing.Point(285, 269);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(133, 45);
            this.LabelScore.TabIndex = 2;
            this.LabelScore.Text = "label2";
            // 
            // FinishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelFinishMessage);
            this.Name = "FinishForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinishForm";
            this.Load += new System.EventHandler(this.FinishForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelFinishMessage;
        private Label label1;
        private Label LabelScore;
    }
}