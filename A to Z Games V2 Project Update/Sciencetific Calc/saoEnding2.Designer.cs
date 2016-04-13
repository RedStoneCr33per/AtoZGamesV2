namespace Sciencetific_Calc
{
    partial class saoEnding2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(saoEnding2));
            this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.saoEndingsNextBtn2 = new System.Windows.Forms.Button();
            this.saoEndingsBackBtn2 = new System.Windows.Forms.Button();
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
            // saoEndingsNextBtn2
            // 
            this.saoEndingsNextBtn2.Location = new System.Drawing.Point(327, 369);
            this.saoEndingsNextBtn2.Name = "saoEndingsNextBtn2";
            this.saoEndingsNextBtn2.Size = new System.Drawing.Size(75, 23);
            this.saoEndingsNextBtn2.TabIndex = 4;
            this.saoEndingsNextBtn2.Text = "Next ->";
            this.saoEndingsNextBtn2.UseVisualStyleBackColor = true;
            this.saoEndingsNextBtn2.Click += new System.EventHandler(this.saoEndingsNextBtn2_Click);
            // 
            // saoEndingsBackBtn2
            // 
            this.saoEndingsBackBtn2.Location = new System.Drawing.Point(209, 369);
            this.saoEndingsBackBtn2.Name = "saoEndingsBackBtn2";
            this.saoEndingsBackBtn2.Size = new System.Drawing.Size(75, 23);
            this.saoEndingsBackBtn2.TabIndex = 3;
            this.saoEndingsBackBtn2.Text = "<- Back";
            this.saoEndingsBackBtn2.UseVisualStyleBackColor = true;
            this.saoEndingsBackBtn2.Click += new System.EventHandler(this.saoEndingsBackBtn2_Click);
            // 
            // saoEnding2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 404);
            this.Controls.Add(this.saoEndingsNextBtn2);
            this.Controls.Add(this.saoEndingsBackBtn2);
            this.Controls.Add(this.axShockwaveFlash1);
            this.Name = "saoEnding2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "saoEnding2";
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;
        private System.Windows.Forms.Button saoEndingsNextBtn2;
        private System.Windows.Forms.Button saoEndingsBackBtn2;
    }
}