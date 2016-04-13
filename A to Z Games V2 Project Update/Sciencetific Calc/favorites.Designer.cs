namespace Sciencetific_Calc
{
    partial class favorites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(favorites));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.exitFavoritesBtn = new System.Windows.Forms.Button();
            this.clearFavoritesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(259, 212);
            this.listBox1.TabIndex = 1;
            // 
            // exitFavoritesBtn
            // 
            this.exitFavoritesBtn.Location = new System.Drawing.Point(152, 230);
            this.exitFavoritesBtn.Name = "exitFavoritesBtn";
            this.exitFavoritesBtn.Size = new System.Drawing.Size(75, 23);
            this.exitFavoritesBtn.TabIndex = 4;
            this.exitFavoritesBtn.Text = "Exit";
            this.exitFavoritesBtn.UseVisualStyleBackColor = true;
            // 
            // clearFavoritesBtn
            // 
            this.clearFavoritesBtn.Location = new System.Drawing.Point(54, 230);
            this.clearFavoritesBtn.Name = "clearFavoritesBtn";
            this.clearFavoritesBtn.Size = new System.Drawing.Size(75, 23);
            this.clearFavoritesBtn.TabIndex = 3;
            this.clearFavoritesBtn.Text = "Clear";
            this.clearFavoritesBtn.UseVisualStyleBackColor = true;
            // 
            // favorites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.exitFavoritesBtn);
            this.Controls.Add(this.clearFavoritesBtn);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 299);
            this.MinimumSize = new System.Drawing.Size(300, 299);
            this.Name = "favorites";
            this.Text = "favorites";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button exitFavoritesBtn;
        private System.Windows.Forms.Button clearFavoritesBtn;
    }
}