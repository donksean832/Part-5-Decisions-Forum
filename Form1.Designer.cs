namespace Part_5_Decisions_Forum
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
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.LblAge = new System.Windows.Forms.Label();
            this.LblAnswer = new System.Windows.Forms.Label();
            this.BtnAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtAge
            // 
            this.TxtAge.Location = new System.Drawing.Point(187, 71);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(199, 22);
            this.TxtAge.TabIndex = 0;
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.Location = new System.Drawing.Point(63, 67);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(105, 17);
            this.LblAge.TabIndex = 1;
            this.LblAge.Text = "Enter Your Age";
            // 
            // LblAnswer
            // 
            this.LblAnswer.AutoSize = true;
            this.LblAnswer.Location = new System.Drawing.Point(74, 173);
            this.LblAnswer.Name = "LblAnswer";
            this.LblAnswer.Size = new System.Drawing.Size(11, 17);
            this.LblAnswer.TabIndex = 2;
            this.LblAnswer.Text = "!";
            // 
            // BtnAnswer
            // 
            this.BtnAnswer.Location = new System.Drawing.Point(255, 167);
            this.BtnAnswer.Name = "BtnAnswer";
            this.BtnAnswer.Size = new System.Drawing.Size(183, 58);
            this.BtnAnswer.TabIndex = 3;
            this.BtnAnswer.Text = "Answer";
            this.BtnAnswer.UseVisualStyleBackColor = true;
            this.BtnAnswer.Click += new System.EventHandler(this.BtnAnswer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAnswer);
            this.Controls.Add(this.LblAnswer);
            this.Controls.Add(this.LblAge);
            this.Controls.Add(this.TxtAge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.Label LblAnswer;
        private System.Windows.Forms.Button BtnAnswer;
    }
}

