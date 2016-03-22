namespace A_to_Z_Quiz
{
    partial class mQuestion1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mQuestion1));
            this.label1 = new System.Windows.Forms.Label();
            this.mAnswerBtn1 = new System.Windows.Forms.Button();
            this.mAnswerBtn2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mAnswerBtn3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. What  is Goku\'s most powerful attack?";
            // 
            // mAnswerBtn1
            // 
            this.mAnswerBtn1.Location = new System.Drawing.Point(56, 216);
            this.mAnswerBtn1.Name = "mAnswerBtn1";
            this.mAnswerBtn1.Size = new System.Drawing.Size(83, 34);
            this.mAnswerBtn1.TabIndex = 2;
            this.mAnswerBtn1.Text = "Kamehameha";
            this.mAnswerBtn1.UseVisualStyleBackColor = true;
            this.mAnswerBtn1.Click += new System.EventHandler(this.mAnswerBtn1_Click);
            // 
            // mAnswerBtn2
            // 
            this.mAnswerBtn2.Location = new System.Drawing.Point(257, 216);
            this.mAnswerBtn2.Name = "mAnswerBtn2";
            this.mAnswerBtn2.Size = new System.Drawing.Size(84, 34);
            this.mAnswerBtn2.TabIndex = 4;
            this.mAnswerBtn2.Text = "Spirt Bomb";
            this.mAnswerBtn2.UseVisualStyleBackColor = true;
            this.mAnswerBtn2.Click += new System.EventHandler(this.mAnswerBtn2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::A_to_Z_Quiz.Properties.Resources.images7;
            this.pictureBox3.Location = new System.Drawing.Point(423, 72);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(181, 129);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::A_to_Z_Quiz.Properties.Resources.download__6_;
            this.pictureBox2.Location = new System.Drawing.Point(214, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::A_to_Z_Quiz.Properties.Resources.download__5_;
            this.pictureBox1.Location = new System.Drawing.Point(24, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // mAnswerBtn3
            // 
            this.mAnswerBtn3.Location = new System.Drawing.Point(479, 216);
            this.mAnswerBtn3.Name = "mAnswerBtn3";
            this.mAnswerBtn3.Size = new System.Drawing.Size(87, 34);
            this.mAnswerBtn3.TabIndex = 6;
            this.mAnswerBtn3.Text = "Destructo Disc";
            this.mAnswerBtn3.UseVisualStyleBackColor = true;
            this.mAnswerBtn3.Click += new System.EventHandler(this.mAnswerBtn3_Click);
            // 
            // mQuestion1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(628, 262);
            this.Controls.Add(this.mAnswerBtn3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.mAnswerBtn2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.mAnswerBtn1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mQuestion1";
            this.Text = "mQuestion1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button mAnswerBtn1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button mAnswerBtn2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button mAnswerBtn3;
    }
}