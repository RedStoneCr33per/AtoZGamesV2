namespace Sciencetific_Calc
{
    partial class animeAndMangaMenu
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
            this.fairyTail = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.swordArtOnlineBtn = new System.Windows.Forms.Button();
            this.bleachMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anime/Manga Menu";
            // 
            // fairyTail
            // 
            this.fairyTail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fairyTail.Location = new System.Drawing.Point(27, 111);
            this.fairyTail.Name = "fairyTail";
            this.fairyTail.Size = new System.Drawing.Size(83, 32);
            this.fairyTail.TabIndex = 1;
            this.fairyTail.Text = "Fairy Tail";
            this.fairyTail.UseVisualStyleBackColor = true;
            this.fairyTail.Click += new System.EventHandler(this.fairyTail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Animes";
            // 
            // swordArtOnlineBtn
            // 
            this.swordArtOnlineBtn.Location = new System.Drawing.Point(27, 150);
            this.swordArtOnlineBtn.Name = "swordArtOnlineBtn";
            this.swordArtOnlineBtn.Size = new System.Drawing.Size(83, 35);
            this.swordArtOnlineBtn.TabIndex = 3;
            this.swordArtOnlineBtn.Text = "Sword Art Online";
            this.swordArtOnlineBtn.UseVisualStyleBackColor = true;
            this.swordArtOnlineBtn.Click += new System.EventHandler(this.swordArtOnlineBtn_Click);
            // 
            // bleachMenu
            // 
            this.bleachMenu.Location = new System.Drawing.Point(27, 192);
            this.bleachMenu.Name = "bleachMenu";
            this.bleachMenu.Size = new System.Drawing.Size(83, 36);
            this.bleachMenu.TabIndex = 4;
            this.bleachMenu.Text = "Bleach";
            this.bleachMenu.UseVisualStyleBackColor = true;
            this.bleachMenu.Click += new System.EventHandler(this.bleachMenu_Click);
            // 
            // animeAndMangaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sciencetific_Calc.Properties.Resources.natsu;
            this.ClientSize = new System.Drawing.Size(506, 379);
            this.Controls.Add(this.bleachMenu);
            this.Controls.Add(this.swordArtOnlineBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fairyTail);
            this.Controls.Add(this.label1);
            this.Name = "animeAndMangaMenu";
            this.Text = "animeAndMangaMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fairyTail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button swordArtOnlineBtn;
        private System.Windows.Forms.Button bleachMenu;
    }
}