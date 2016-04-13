﻿namespace Sciencetific_Calc
{
    partial class pingPong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pingPong));
            this.playground = new System.Windows.Forms.Panel();
            this.points_1bl = new System.Windows.Forms.Label();
            this.score_1bl = new System.Windows.Forms.Label();
            this.gameover_1bl = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.racket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.Controls.Add(this.points_1bl);
            this.playground.Controls.Add(this.score_1bl);
            this.playground.Controls.Add(this.gameover_1bl);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.racket);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(755, 400);
            this.playground.TabIndex = 0;
            // 
            // points_1bl
            // 
            this.points_1bl.AutoSize = true;
            this.points_1bl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points_1bl.Location = new System.Drawing.Point(164, 19);
            this.points_1bl.Name = "points_1bl";
            this.points_1bl.Size = new System.Drawing.Size(51, 55);
            this.points_1bl.TabIndex = 7;
            this.points_1bl.Text = "0";
            // 
            // score_1bl
            // 
            this.score_1bl.AutoSize = true;
            this.score_1bl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_1bl.Location = new System.Drawing.Point(12, 19);
            this.score_1bl.Name = "score_1bl";
            this.score_1bl.Size = new System.Drawing.Size(163, 55);
            this.score_1bl.TabIndex = 6;
            this.score_1bl.Text = "Score:";
            // 
            // gameover_1bl
            // 
            this.gameover_1bl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameover_1bl.AutoSize = true;
            this.gameover_1bl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameover_1bl.Location = new System.Drawing.Point(220, 98);
            this.gameover_1bl.Name = "gameover_1bl";
            this.gameover_1bl.Size = new System.Drawing.Size(307, 220);
            this.gameover_1bl.TabIndex = 5;
            this.gameover_1bl.Text = "Game Over\r\n\r\nF1 - Restart\r\nEsc - Escape";
            this.gameover_1bl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.Location = new System.Drawing.Point(88, 98);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.Black;
            this.racket.Location = new System.Drawing.Point(268, 368);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(200, 20);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pingPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 400);
            this.Controls.Add(this.playground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pingPong";
            this.Text = "pingPong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pingPong_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label points_1bl;
        private System.Windows.Forms.Label score_1bl;
        private System.Windows.Forms.Label gameover_1bl;
    }
}