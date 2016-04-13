namespace Sciencetific_Calc
{
    partial class history
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(history));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.clearHistoryBtn = new System.Windows.Forms.Button();
            this.exitHistoryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(259, 212);
            this.listBox1.TabIndex = 0;
            // 
            // clearHistoryBtn
            // 
            this.clearHistoryBtn.Location = new System.Drawing.Point(51, 231);
            this.clearHistoryBtn.Name = "clearHistoryBtn";
            this.clearHistoryBtn.Size = new System.Drawing.Size(75, 23);
            this.clearHistoryBtn.TabIndex = 1;
            this.clearHistoryBtn.Text = "Clear";
            this.clearHistoryBtn.UseVisualStyleBackColor = true;
            this.clearHistoryBtn.Click += new System.EventHandler(this.clearHistoryBtn_Click);
            // 
            // exitHistoryBtn
            // 
            this.exitHistoryBtn.Location = new System.Drawing.Point(149, 231);
            this.exitHistoryBtn.Name = "exitHistoryBtn";
            this.exitHistoryBtn.Size = new System.Drawing.Size(75, 23);
            this.exitHistoryBtn.TabIndex = 2;
            this.exitHistoryBtn.Text = "Exit";
            this.exitHistoryBtn.UseVisualStyleBackColor = true;
            this.exitHistoryBtn.Click += new System.EventHandler(this.exitHistoryBtn_Click);
            // 
            // history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.exitHistoryBtn);
            this.Controls.Add(this.clearHistoryBtn);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 299);
            this.MinimumSize = new System.Drawing.Size(300, 299);
            this.Name = "history";
            this.Text = "history";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button clearHistoryBtn;
        private System.Windows.Forms.Button exitHistoryBtn;
    }
}