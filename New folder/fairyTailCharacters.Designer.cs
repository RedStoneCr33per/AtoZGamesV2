namespace Sciencetific_Calc
{
    partial class fairyTailCharacters
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
            this.natsuDragneelBio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // natsuDragneelBio
            // 
            this.natsuDragneelBio.Location = new System.Drawing.Point(12, 43);
            this.natsuDragneelBio.Name = "natsuDragneelBio";
            this.natsuDragneelBio.Size = new System.Drawing.Size(84, 36);
            this.natsuDragneelBio.TabIndex = 0;
            this.natsuDragneelBio.Text = "Natsu Dragneel";
            this.natsuDragneelBio.UseVisualStyleBackColor = true;
            this.natsuDragneelBio.Click += new System.EventHandler(this.natsuDragneelBio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fairy Tail Charaters";
            // 
            // fairyTailCharacters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 263);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.natsuDragneelBio);
            this.Name = "fairyTailCharacters";
            this.Text = "fairyTailCharacters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button natsuDragneelBio;
        private System.Windows.Forms.Label label1;
    }
}