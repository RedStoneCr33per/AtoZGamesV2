namespace Sciencetific_Calc
{
    partial class alarmClockMessage
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.snoozeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(259, 189);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(35, 226);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // snoozeBtn
            // 
            this.snoozeBtn.Location = new System.Drawing.Point(169, 226);
            this.snoozeBtn.Name = "snoozeBtn";
            this.snoozeBtn.Size = new System.Drawing.Size(75, 23);
            this.snoozeBtn.TabIndex = 2;
            this.snoozeBtn.Text = "Snooze";
            this.snoozeBtn.UseVisualStyleBackColor = true;
            this.snoozeBtn.Click += new System.EventHandler(this.snoozeBtn_Click);
            // 
            // alarmClockMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.snoozeBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.richTextBox1);
            this.Name = "alarmClockMessage";
            this.Text = "alarmClockMessage";
            this.Load += new System.EventHandler(this.alarmClockMessage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button snoozeBtn;
    }
}