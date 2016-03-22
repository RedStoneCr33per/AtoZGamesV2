namespace A_to_Z_Quiz
{
    partial class easyQuestion3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(easyQuestion3));
            this.label1 = new System.Windows.Forms.Label();
            this.eAnswerBtn7 = new System.Windows.Forms.Button();
            this.eAnswerBtn9 = new System.Windows.Forms.Button();
            this.eAnswerBtn8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "3. Which one of these is not a Pokemon?";
            // 
            // eAnswerBtn7
            // 
            this.eAnswerBtn7.Location = new System.Drawing.Point(91, 68);
            this.eAnswerBtn7.Name = "eAnswerBtn7";
            this.eAnswerBtn7.Size = new System.Drawing.Size(82, 28);
            this.eAnswerBtn7.TabIndex = 1;
            this.eAnswerBtn7.Text = "Mewtwo";
            this.eAnswerBtn7.UseVisualStyleBackColor = true;
            this.eAnswerBtn7.Click += new System.EventHandler(this.eAnswerBtn7_Click);
            // 
            // eAnswerBtn9
            // 
            this.eAnswerBtn9.Location = new System.Drawing.Point(91, 172);
            this.eAnswerBtn9.Name = "eAnswerBtn9";
            this.eAnswerBtn9.Size = new System.Drawing.Size(82, 29);
            this.eAnswerBtn9.TabIndex = 2;
            this.eAnswerBtn9.Text = "Pikachu";
            this.eAnswerBtn9.UseVisualStyleBackColor = true;
            this.eAnswerBtn9.Click += new System.EventHandler(this.eAnswerBtn9_Click);
            // 
            // eAnswerBtn8
            // 
            this.eAnswerBtn8.Location = new System.Drawing.Point(91, 118);
            this.eAnswerBtn8.Name = "eAnswerBtn8";
            this.eAnswerBtn8.Size = new System.Drawing.Size(82, 30);
            this.eAnswerBtn8.TabIndex = 3;
            this.eAnswerBtn8.Text = "AbraKadabra";
            this.eAnswerBtn8.UseVisualStyleBackColor = true;
            this.eAnswerBtn8.Click += new System.EventHandler(this.eAnswerBtn8_Click);
            // 
            // easyQuestion3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.eAnswerBtn8);
            this.Controls.Add(this.eAnswerBtn9);
            this.Controls.Add(this.eAnswerBtn7);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "easyQuestion3";
            this.Text = "easyQuestion3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eAnswerBtn7;
        private System.Windows.Forms.Button eAnswerBtn9;
        private System.Windows.Forms.Button eAnswerBtn8;
    }
}