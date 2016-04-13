namespace Sciencetific_Calc
{
    partial class saoEnding1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(saoEnding1));
            this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.saoEndingsBackBtn1 = new System.Windows.Forms.Button();
            this.saoEndingsNextBtn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).BeginInit();
            this.SuspendLayout();
            // 
            // axShockwaveFlash1
            // 
            this.axShockwaveFlash1.Enabled = true;
            this.axShockwaveFlash1.Location = new System.Drawing.Point(12, 32);
            this.axShockwaveFlash1.Name = "axShockwaveFlash1";
            this.axShockwaveFlash1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash1.OcxState")));
            this.axShockwaveFlash1.Size = new System.Drawing.Size(587, 326);
            this.axShockwaveFlash1.TabIndex = 0;
            // 
            // saoEndingsBackBtn1
            // 
            this.saoEndingsBackBtn1.Location = new System.Drawing.Point(202, 369);
            this.saoEndingsBackBtn1.Name = "saoEndingsBackBtn1";
            this.saoEndingsBackBtn1.Size = new System.Drawing.Size(75, 23);
            this.saoEndingsBackBtn1.TabIndex = 1;
            this.saoEndingsBackBtn1.Text = "<- Back";
            this.saoEndingsBackBtn1.UseVisualStyleBackColor = true;
            this.saoEndingsBackBtn1.Click += new System.EventHandler(this.saoEndingsBackBtn1_Click);
            // 
            // saoEndingsNextBtn1
            // 
            this.saoEndingsNextBtn1.Location = new System.Drawing.Point(320, 369);
            this.saoEndingsNextBtn1.Name = "saoEndingsNextBtn1";
            this.saoEndingsNextBtn1.Size = new System.Drawing.Size(75, 23);
            this.saoEndingsNextBtn1.TabIndex = 2;
            this.saoEndingsNextBtn1.Text = "Next ->";
            this.saoEndingsNextBtn1.UseVisualStyleBackColor = true;
            this.saoEndingsNextBtn1.Click += new System.EventHandler(this.saoEndingsNextBtn1_Click);
            // 
            // saoEnding1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 404);
            this.Controls.Add(this.saoEndingsNextBtn1);
            this.Controls.Add(this.saoEndingsBackBtn1);
            this.Controls.Add(this.axShockwaveFlash1);
            this.Name = "saoEnding1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "saoEnding1";
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;
        private System.Windows.Forms.Button saoEndingsBackBtn1;
        private System.Windows.Forms.Button saoEndingsNextBtn1;
    }
}