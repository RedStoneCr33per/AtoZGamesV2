namespace Sciencetific_Calc
{
    partial class slotMachineSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.musicOnBtn = new System.Windows.Forms.Button();
            this.musicOffBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pericles", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Music:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "----------------------------------";
            // 
            // musicOnBtn
            // 
            this.musicOnBtn.Location = new System.Drawing.Point(91, 78);
            this.musicOnBtn.Name = "musicOnBtn";
            this.musicOnBtn.Size = new System.Drawing.Size(49, 23);
            this.musicOnBtn.TabIndex = 4;
            this.musicOnBtn.Text = "On";
            this.musicOnBtn.UseVisualStyleBackColor = true;
            this.musicOnBtn.Click += new System.EventHandler(this.musicOnBtn_Click);
            // 
            // musicOffBtn
            // 
            this.musicOffBtn.Location = new System.Drawing.Point(146, 79);
            this.musicOffBtn.Name = "musicOffBtn";
            this.musicOffBtn.Size = new System.Drawing.Size(49, 23);
            this.musicOffBtn.TabIndex = 5;
            this.musicOffBtn.Text = "Off";
            this.musicOffBtn.UseVisualStyleBackColor = true;
            this.musicOffBtn.Click += new System.EventHandler(this.musicOffBtn_Click);
            // 
            // slotMachineSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 261);
            this.Controls.Add(this.musicOffBtn);
            this.Controls.Add(this.musicOnBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "slotMachineSettings";
            this.Text = "slotMachineSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button musicOnBtn;
        private System.Windows.Forms.Button musicOffBtn;
    }
}