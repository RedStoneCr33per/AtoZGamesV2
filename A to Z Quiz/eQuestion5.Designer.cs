namespace A_to_Z_Quiz
{
    partial class eQuestion5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eQuestion5));
            this.label1 = new System.Windows.Forms.Label();
            this.eAnswerBtn13 = new System.Windows.Forms.Button();
            this.eAnswerBtn14 = new System.Windows.Forms.Button();
            this.eAnswerBtn15 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "5. What is the next Question?";
            // 
            // eAnswerBtn13
            // 
            this.eAnswerBtn13.Location = new System.Drawing.Point(94, 82);
            this.eAnswerBtn13.Name = "eAnswerBtn13";
            this.eAnswerBtn13.Size = new System.Drawing.Size(75, 37);
            this.eAnswerBtn13.TabIndex = 1;
            this.eAnswerBtn13.Text = "Easy Question 6";
            this.eAnswerBtn13.UseVisualStyleBackColor = true;
            this.eAnswerBtn13.Click += new System.EventHandler(this.eAnswerBtn13_Click);
            // 
            // eAnswerBtn14
            // 
            this.eAnswerBtn14.Location = new System.Drawing.Point(94, 136);
            this.eAnswerBtn14.Name = "eAnswerBtn14";
            this.eAnswerBtn14.Size = new System.Drawing.Size(75, 38);
            this.eAnswerBtn14.TabIndex = 2;
            this.eAnswerBtn14.Text = "Medium Question 1";
            this.eAnswerBtn14.UseVisualStyleBackColor = true;
            this.eAnswerBtn14.Click += new System.EventHandler(this.eAnswerBtn14_Click);
            // 
            // eAnswerBtn15
            // 
            this.eAnswerBtn15.Location = new System.Drawing.Point(94, 194);
            this.eAnswerBtn15.Name = "eAnswerBtn15";
            this.eAnswerBtn15.Size = new System.Drawing.Size(75, 40);
            this.eAnswerBtn15.TabIndex = 3;
            this.eAnswerBtn15.Text = "Easy Part 2 Question 1";
            this.eAnswerBtn15.UseVisualStyleBackColor = true;
            this.eAnswerBtn15.Click += new System.EventHandler(this.eAnswerBtn15_Click);
            // 
            // eQuestion5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.eAnswerBtn15);
            this.Controls.Add(this.eAnswerBtn14);
            this.Controls.Add(this.eAnswerBtn13);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "eQuestion5";
            this.Text = "eQuestion5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eAnswerBtn13;
        private System.Windows.Forms.Button eAnswerBtn14;
        private System.Windows.Forms.Button eAnswerBtn15;
    }
}