namespace A_to_Z_Quiz
{
    partial class easyQuestion1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(easyQuestion1));
            this.label1 = new System.Windows.Forms.Label();
            this.eAnswerBtn1 = new System.Windows.Forms.Button();
            this.eAnswerBtn2 = new System.Windows.Forms.Button();
            this.eAnswerBtn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Who are the owners of A to Z?";
            // 
            // eAnswerBtn1
            // 
            this.eAnswerBtn1.Location = new System.Drawing.Point(97, 75);
            this.eAnswerBtn1.Name = "eAnswerBtn1";
            this.eAnswerBtn1.Size = new System.Drawing.Size(75, 34);
            this.eAnswerBtn1.TabIndex = 1;
            this.eAnswerBtn1.Text = "Adam and Zachary";
            this.eAnswerBtn1.UseVisualStyleBackColor = true;
            this.eAnswerBtn1.Click += new System.EventHandler(this.eAnswerBtn1_Click);
            // 
            // eAnswerBtn2
            // 
            this.eAnswerBtn2.Location = new System.Drawing.Point(97, 128);
            this.eAnswerBtn2.Name = "eAnswerBtn2";
            this.eAnswerBtn2.Size = new System.Drawing.Size(75, 37);
            this.eAnswerBtn2.TabIndex = 2;
            this.eAnswerBtn2.Text = "Apple and Zucchini";
            this.eAnswerBtn2.UseVisualStyleBackColor = true;
            this.eAnswerBtn2.Click += new System.EventHandler(this.eAnswerBtn2_Click);
            // 
            // eAnswerBtn3
            // 
            this.eAnswerBtn3.Location = new System.Drawing.Point(97, 185);
            this.eAnswerBtn3.Name = "eAnswerBtn3";
            this.eAnswerBtn3.Size = new System.Drawing.Size(75, 34);
            this.eAnswerBtn3.TabIndex = 3;
            this.eAnswerBtn3.Text = "Alex and Zoey";
            this.eAnswerBtn3.UseVisualStyleBackColor = true;
            this.eAnswerBtn3.Click += new System.EventHandler(this.eAnswerBtn3_Click);
            // 
            // easyQuestion1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.eAnswerBtn3);
            this.Controls.Add(this.eAnswerBtn2);
            this.Controls.Add(this.eAnswerBtn1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "easyQuestion1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "easyQuestion1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eAnswerBtn1;
        private System.Windows.Forms.Button eAnswerBtn2;
        private System.Windows.Forms.Button eAnswerBtn3;
    }
}