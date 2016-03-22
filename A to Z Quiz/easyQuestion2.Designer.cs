namespace A_to_Z_Quiz
{
    partial class easyQuestion2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(easyQuestion2));
            this.label1 = new System.Windows.Forms.Label();
            this.eQuestionBtn4 = new System.Windows.Forms.Button();
            this.eQuestionBtn5 = new System.Windows.Forms.Button();
            this.eQuestionBtn6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "2. What did A to Z start as?";
            // 
            // eQuestionBtn4
            // 
            this.eQuestionBtn4.Location = new System.Drawing.Point(99, 64);
            this.eQuestionBtn4.Name = "eQuestionBtn4";
            this.eQuestionBtn4.Size = new System.Drawing.Size(75, 40);
            this.eQuestionBtn4.TabIndex = 1;
            this.eQuestionBtn4.Text = "Video game";
            this.eQuestionBtn4.UseVisualStyleBackColor = true;
            this.eQuestionBtn4.Click += new System.EventHandler(this.eQuestionBtn4_Click);
            // 
            // eQuestionBtn5
            // 
            this.eQuestionBtn5.Location = new System.Drawing.Point(99, 129);
            this.eQuestionBtn5.Name = "eQuestionBtn5";
            this.eQuestionBtn5.Size = new System.Drawing.Size(75, 40);
            this.eQuestionBtn5.TabIndex = 2;
            this.eQuestionBtn5.Text = "BPA website";
            this.eQuestionBtn5.UseVisualStyleBackColor = true;
            this.eQuestionBtn5.Click += new System.EventHandler(this.eQuestionBtn5_Click);
            // 
            // eQuestionBtn6
            // 
            this.eQuestionBtn6.Location = new System.Drawing.Point(99, 190);
            this.eQuestionBtn6.Name = "eQuestionBtn6";
            this.eQuestionBtn6.Size = new System.Drawing.Size(75, 38);
            this.eQuestionBtn6.TabIndex = 3;
            this.eQuestionBtn6.Text = "Comic";
            this.eQuestionBtn6.UseVisualStyleBackColor = true;
            this.eQuestionBtn6.Click += new System.EventHandler(this.eQuestionBtn6_Click);
            // 
            // easyQuestion2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.eQuestionBtn6);
            this.Controls.Add(this.eQuestionBtn5);
            this.Controls.Add(this.eQuestionBtn4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "easyQuestion2";
            this.Text = "easyQuestion2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eQuestionBtn4;
        private System.Windows.Forms.Button eQuestionBtn5;
        private System.Windows.Forms.Button eQuestionBtn6;
    }
}