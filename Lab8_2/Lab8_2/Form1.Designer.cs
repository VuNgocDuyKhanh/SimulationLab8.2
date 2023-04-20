namespace Lab8_2
{
    partial class Form1
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
            this.Question = new System.Windows.Forms.TextBox();
            this.ShakeBtn = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.Location = new System.Drawing.Point(12, 12);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(776, 22);
            this.Question.TabIndex = 0;
            // 
            // ShakeBtn
            // 
            this.ShakeBtn.Location = new System.Drawing.Point(12, 40);
            this.ShakeBtn.Name = "ShakeBtn";
            this.ShakeBtn.Size = new System.Drawing.Size(157, 23);
            this.ShakeBtn.TabIndex = 1;
            this.ShakeBtn.Text = "Shake The Magic 8 Ball";
            this.ShakeBtn.UseVisualStyleBackColor = true;
            this.ShakeBtn.Click += new System.EventHandler(this.ShakeBtn_Click);
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(12, 69);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(776, 22);
            this.Answer.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.ShakeBtn);
            this.Controls.Add(this.Question);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Question;
        private System.Windows.Forms.Button ShakeBtn;
        private System.Windows.Forms.TextBox Answer;
    }
}

