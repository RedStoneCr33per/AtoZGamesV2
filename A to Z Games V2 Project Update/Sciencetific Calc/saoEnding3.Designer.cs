namespace Sciencetific_Calc
{
    partial class saoEnding3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(saoEnding3));
            this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.saoEndingsNextBtn3 = new System.Windows.Forms.Button();
            this.saoEndingsBackBtn3 = new System.Windows.Forms.Button();
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
            // saoEndingsNextBtn3
            // 
            this.saoEndingsNextBtn3.Location = new System.Drawing.Point(329, 369);
            this.saoEndingsNextBtn3.Name = "saoEndingsNextBtn3";
            this.saoEndingsNextBtn3.Size = new System.Drawing.Size(75, 23);
            this.saoEndingsNextBtn3.TabIndex = 6;
            this.saoEndingsNextBtn3.Text = "Next ->";
            this.saoEndingsNextBtn3.UseVisualStyleBackColor = true;
            this.saoEndingsNextBtn3.Click += new System.EventHandler(this.saoEndingsNextBtn3_Click);
            // 
            // saoEndingsBackBtn3
            // 
            this.saoEndingsBackBtn3.Location = new System.Drawing.Point(211, 369);
            this.saoEndingsBackBtn3.Name = "saoEndingsBackBtn3";
            this.saoEndingsBackBtn3.Size = new System.Drawing.Size(75, 23);
            this.saoEndingsBackBtn3.TabIndex = 5;
            this.saoEndingsBackBtn3.Text = "<- Back";
            this.saoEndingsBackBtn3.UseVisualStyleBackColor = true;
            this.saoEndingsBackBtn3.Click += new System.EventHandler(this.saoEndingsBackBtn3_Click);
            // 
            // saoEnding3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 404);
            this.Controls.Add(this.saoEndingsNextBtn3);
            this.Controls.Add(this.saoEndingsBackBtn3);
            this.Controls.Add(this.axShockwaveFlash1);
            this.Name = "saoEnding3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "saoEnding3";
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;
        private System.Windows.Forms.Button saoEndingsNextBtn3;
        private System.Windows.Forms.Button saoEndingsBackBtn3;
    }
}