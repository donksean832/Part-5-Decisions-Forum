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
            this.BtnHurricane = new System.Windows.Forms.Button();
            this.LblHurricane = new System.Windows.Forms.Label();
            this.TxtHurricane = new System.Windows.Forms.TextBox();
            this.LblHurricaneAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtAge
            // 
            this.TxtAge.Location = new System.Drawing.Point(179, 21);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(199, 22);
            this.TxtAge.TabIndex = 0;
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.Location = new System.Drawing.Point(23, 21);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(105, 17);
            this.LblAge.TabIndex = 1;
            this.LblAge.Text = "Enter Your Age";
            // 
            // LblAnswer
            // 
            this.LblAnswer.AutoSize = true;
            this.LblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LblAnswer.Location = new System.Drawing.Point(192, 71);
            this.LblAnswer.Name = "LblAnswer";
            this.LblAnswer.Size = new System.Drawing.Size(0, 25);
            this.LblAnswer.TabIndex = 2;
            // 
            // BtnAnswer
            // 
            this.BtnAnswer.Location = new System.Drawing.Point(26, 66);
            this.BtnAnswer.Name = "BtnAnswer";
            this.BtnAnswer.Size = new System.Drawing.Size(90, 40);
            this.BtnAnswer.TabIndex = 3;
            this.BtnAnswer.Text = "Answer";
            this.BtnAnswer.UseVisualStyleBackColor = true;
            this.BtnAnswer.Click += new System.EventHandler(this.BtnAnswer_Click);
            // 
            // BtnHurricane
            // 
            this.BtnHurricane.Location = new System.Drawing.Point(26, 243);
            this.BtnHurricane.Name = "BtnHurricane";
            this.BtnHurricane.Size = new System.Drawing.Size(85, 45);
            this.BtnHurricane.TabIndex = 4;
            this.BtnHurricane.Text = "Hurricane Catagory";
            this.BtnHurricane.UseVisualStyleBackColor = true;
            this.BtnHurricane.Click += new System.EventHandler(this.BtnHurricane_Click);
            // 
            // LblHurricane
            // 
            this.LblHurricane.AutoSize = true;
            this.LblHurricane.Location = new System.Drawing.Point(23, 185);
            this.LblHurricane.Name = "LblHurricane";
            this.LblHurricane.Size = new System.Drawing.Size(128, 17);
            this.LblHurricane.TabIndex = 5;
            this.LblHurricane.Text = "Enter windspeed in";
            // 
            // TxtHurricane
            // 
            this.TxtHurricane.Location = new System.Drawing.Point(179, 182);
            this.TxtHurricane.Name = "TxtHurricane";
            this.TxtHurricane.Size = new System.Drawing.Size(199, 22);
            this.TxtHurricane.TabIndex = 6;
            // 
            // LblHurricaneAnswer
            // 
            this.LblHurricaneAnswer.AutoSize = true;
            this.LblHurricaneAnswer.Location = new System.Drawing.Point(194, 257);
            this.LblHurricaneAnswer.Name = "LblHurricaneAnswer";
            this.LblHurricaneAnswer.Size = new System.Drawing.Size(46, 17);
            this.LblHurricaneAnswer.TabIndex = 7;
            this.LblHurricaneAnswer.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblHurricaneAnswer);
            this.Controls.Add(this.TxtHurricane);
            this.Controls.Add(this.LblHurricane);
            this.Controls.Add(this.BtnHurricane);
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
        private System.Windows.Forms.Button BtnHurricane;
        private System.Windows.Forms.Label LblHurricane;
        private System.Windows.Forms.TextBox TxtHurricane;
        private System.Windows.Forms.Label LblHurricaneAnswer;
    }
}

