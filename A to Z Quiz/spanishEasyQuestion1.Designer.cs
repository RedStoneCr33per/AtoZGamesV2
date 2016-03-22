namespace A_to_Z_Quiz
{
    partial class spanishEasyQuestion1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(spanishEasyQuestion1));
            this.label1 = new System.Windows.Forms.Label();
            this.spanishAnswerBtn1 = new System.Windows.Forms.Button();
            this.spanishAnswerBtn2 = new System.Windows.Forms.Button();
            this.spanishAnswerBtn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Quiénes son los dueños de la A a la Z?";
            // 
            // spanishAnswerBtn1
            // 
            this.spanishAnswerBtn1.Location = new System.Drawing.Point(92, 75);
            this.spanishAnswerBtn1.Name = "spanishAnswerBtn1";
            this.spanishAnswerBtn1.Size = new System.Drawing.Size(75, 43);
            this.spanishAnswerBtn1.TabIndex = 1;
            this.spanishAnswerBtn1.Text = "Adán y Zachary";
            this.spanishAnswerBtn1.UseVisualStyleBackColor = true;
            this.spanishAnswerBtn1.Click += new System.EventHandler(this.spanishAnswerBtn1_Click);
            // 
            // spanishAnswerBtn2
            // 
            this.spanishAnswerBtn2.Location = new System.Drawing.Point(92, 124);
            this.spanishAnswerBtn2.Name = "spanishAnswerBtn2";
            this.spanishAnswerBtn2.Size = new System.Drawing.Size(75, 45);
            this.spanishAnswerBtn2.TabIndex = 2;
            this.spanishAnswerBtn2.Text = "manzana y calabacín";
            this.spanishAnswerBtn2.UseVisualStyleBackColor = true;
            this.spanishAnswerBtn2.Click += new System.EventHandler(this.spanishAnswerBtn2_Click);
            // 
            // spanishAnswerBtn3
            // 
            this.spanishAnswerBtn3.Location = new System.Drawing.Point(92, 175);
            this.spanishAnswerBtn3.Name = "spanishAnswerBtn3";
            this.spanishAnswerBtn3.Size = new System.Drawing.Size(75, 47);
            this.spanishAnswerBtn3.TabIndex = 3;
            this.spanishAnswerBtn3.Text = "Alex y Zoey";
            this.spanishAnswerBtn3.UseVisualStyleBackColor = true;
            this.spanishAnswerBtn3.Click += new System.EventHandler(this.spanishAnswerBtn3_Click);
            // 
            // spanishEasyQuestion1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.spanishAnswerBtn3);
            this.Controls.Add(this.spanishAnswerBtn2);
            this.Controls.Add(this.spanishAnswerBtn1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "spanishEasyQuestion1";
            this.Text = "spanishEasyQuestion1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button spanishAnswerBtn1;
        private System.Windows.Forms.Button spanishAnswerBtn2;
        private System.Windows.Forms.Button spanishAnswerBtn3;
    }
}