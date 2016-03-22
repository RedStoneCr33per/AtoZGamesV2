namespace A_to_Z_Quiz
{
    partial class hQuestion1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hQuestion1));
            this.label1 = new System.Windows.Forms.Label();
            this.hAnswerBtn1 = new System.Windows.Forms.Button();
            this.hAnswerBtn2 = new System.Windows.Forms.Button();
            this.hAnswerBtn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. What anime is this theme song from?";
            // 
            // hAnswerBtn1
            // 
            this.hAnswerBtn1.Location = new System.Drawing.Point(101, 81);
            this.hAnswerBtn1.Name = "hAnswerBtn1";
            this.hAnswerBtn1.Size = new System.Drawing.Size(75, 23);
            this.hAnswerBtn1.TabIndex = 1;
            this.hAnswerBtn1.Text = "Naruto";
            this.hAnswerBtn1.UseVisualStyleBackColor = true;
            // 
            // hAnswerBtn2
            // 
            this.hAnswerBtn2.Location = new System.Drawing.Point(101, 120);
            this.hAnswerBtn2.Name = "hAnswerBtn2";
            this.hAnswerBtn2.Size = new System.Drawing.Size(75, 23);
            this.hAnswerBtn2.TabIndex = 2;
            this.hAnswerBtn2.Text = "Bleach";
            this.hAnswerBtn2.UseVisualStyleBackColor = true;
            // 
            // hAnswerBtn3
            // 
            this.hAnswerBtn3.Location = new System.Drawing.Point(101, 167);
            this.hAnswerBtn3.Name = "hAnswerBtn3";
            this.hAnswerBtn3.Size = new System.Drawing.Size(75, 23);
            this.hAnswerBtn3.TabIndex = 3;
            this.hAnswerBtn3.Text = "Fairy Tail";
            this.hAnswerBtn3.UseVisualStyleBackColor = true;
            // 
            // hQuestion1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.hAnswerBtn3);
            this.Controls.Add(this.hAnswerBtn2);
            this.Controls.Add(this.hAnswerBtn1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "hQuestion1";
            this.Text = "hQuestion1";
            this.Load += new System.EventHandler(this.hQuestion1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hAnswerBtn1;
        private System.Windows.Forms.Button hAnswerBtn2;
        private System.Windows.Forms.Button hAnswerBtn3;
    }
}