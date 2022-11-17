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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinishForm));
            this.LabelFinishMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelScore = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelFinishMessage
            // 
            this.LabelFinishMessage.AutoSize = true;
            this.LabelFinishMessage.BackColor = System.Drawing.Color.Transparent;
            this.LabelFinishMessage.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelFinishMessage.Location = new System.Drawing.Point(106, 108);
            this.LabelFinishMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelFinishMessage.Name = "LabelFinishMessage";
            this.LabelFinishMessage.Size = new System.Drawing.Size(201, 68);
            this.LabelFinishMessage.TabIndex = 0;
            this.LabelFinishMessage.Text = "label1";
            this.LabelFinishMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(261, 287);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(601, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sua pontuação é de:";
            // 
            // LabelScore
            // 
            this.LabelScore.AutoSize = true;
            this.LabelScore.BackColor = System.Drawing.Color.Transparent;
            this.LabelScore.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelScore.ForeColor = System.Drawing.Color.Red;
            this.LabelScore.Location = new System.Drawing.Point(407, 448);
            this.LabelScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(201, 68);
            this.LabelScore.TabIndex = 2;
            this.LabelScore.Text = "label2";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(17, 665);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 65);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FinishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LabelScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelFinishMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
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
        private Button button1;
    }
}