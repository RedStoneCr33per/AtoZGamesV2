namespace Sciencetific_Calc
{
    partial class fairyTailMenu
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
            this.fairyTailCharacters = new System.Windows.Forms.Button();
            this.fairyTailOpenings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fairy Tail";
            // 
            // fairyTailCharacters
            // 
            this.fairyTailCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fairyTailCharacters.Location = new System.Drawing.Point(101, 66);
            this.fairyTailCharacters.Name = "fairyTailCharacters";
            this.fairyTailCharacters.Size = new System.Drawing.Size(81, 31);
            this.fairyTailCharacters.TabIndex = 1;
            this.fairyTailCharacters.Text = "Characters";
            this.fairyTailCharacters.UseVisualStyleBackColor = true;
            this.fairyTailCharacters.Click += new System.EventHandler(this.fairyTailCharacters_Click);
            // 
            // fairyTailOpenings
            // 
            this.fairyTailOpenings.Location = new System.Drawing.Point(101, 104);
            this.fairyTailOpenings.Name = "fairyTailOpenings";
            this.fairyTailOpenings.Size = new System.Drawing.Size(81, 38);
            this.fairyTailOpenings.TabIndex = 2;
            this.fairyTailOpenings.Text = "Openings 1-21";
            this.fairyTailOpenings.UseVisualStyleBackColor = true;
            this.fairyTailOpenings.Click += new System.EventHandler(this.fairyTailOpenings_Click);
            // 
            // fairyTailMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.fairyTailOpenings);
            this.Controls.Add(this.fairyTailCharacters);
            this.Controls.Add(this.label1);
            this.Name = "fairyTailMenu";
            this.Text = "fairyTailMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fairyTailCharacters;
        private System.Windows.Forms.Button fairyTailOpenings;
    }
}