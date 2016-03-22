namespace A_to_Z_Quiz
{
    partial class chooseLanguageEasy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chooseLanguageEasy));
            this.label1 = new System.Windows.Forms.Label();
            this.englishBtn1 = new System.Windows.Forms.Button();
            this.spanishBtn1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please choose the language in which you would like to take the quiz";
            // 
            // englishBtn1
            // 
            this.englishBtn1.Location = new System.Drawing.Point(120, 67);
            this.englishBtn1.Name = "englishBtn1";
            this.englishBtn1.Size = new System.Drawing.Size(75, 23);
            this.englishBtn1.TabIndex = 1;
            this.englishBtn1.Text = "English";
            this.englishBtn1.UseVisualStyleBackColor = true;
            this.englishBtn1.Click += new System.EventHandler(this.englishBtn1_Click);
            // 
            // spanishBtn1
            // 
            this.spanishBtn1.Location = new System.Drawing.Point(120, 114);
            this.spanishBtn1.Name = "spanishBtn1";
            this.spanishBtn1.Size = new System.Drawing.Size(75, 23);
            this.spanishBtn1.TabIndex = 2;
            this.spanishBtn1.Text = "Spanish";
            this.spanishBtn1.UseVisualStyleBackColor = true;
            this.spanishBtn1.Click += new System.EventHandler(this.spanishBtn1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(120, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // chooseLanguageEasy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(335, 262);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.spanishBtn1);
            this.Controls.Add(this.englishBtn1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "chooseLanguageEasy";
            this.Text = "chooseLanguageEasy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button englishBtn1;
        private System.Windows.Forms.Button spanishBtn1;
        private System.Windows.Forms.Button button3;

    }
}