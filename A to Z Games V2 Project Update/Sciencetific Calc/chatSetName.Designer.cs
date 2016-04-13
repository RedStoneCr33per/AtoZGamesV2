namespace Sciencetific_Calc
{
    partial class chatSetName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chatSetName));
            this.label1 = new System.Windows.Forms.Label();
            this.chatName = new System.Windows.Forms.TextBox();
            this.setChatName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player One Name:";
            // 
            // chatName
            // 
            this.chatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatName.Location = new System.Drawing.Point(154, 22);
            this.chatName.Name = "chatName";
            this.chatName.Size = new System.Drawing.Size(243, 26);
            this.chatName.TabIndex = 3;
            // 
            // setChatName
            // 
            this.setChatName.Location = new System.Drawing.Point(169, 54);
            this.setChatName.Name = "setChatName";
            this.setChatName.Size = new System.Drawing.Size(75, 23);
            this.setChatName.TabIndex = 4;
            this.setChatName.Text = "Set";
            this.setChatName.UseVisualStyleBackColor = true;
            this.setChatName.Click += new System.EventHandler(this.setChatName_Click);
            // 
            // chatSetName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(413, 80);
            this.Controls.Add(this.setChatName);
            this.Controls.Add(this.chatName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "chatSetName";
            this.Text = "chatSetName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox chatName;
        private System.Windows.Forms.Button setChatName;
    }
}