namespace Sciencetific_Calc
{
    partial class Snake
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
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraProgramsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sciencetificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snakeGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internetTvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitalClockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analongClockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFReaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioFileReaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mP3PlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speakToTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diceGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singlePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.Color.Gray;
            this.pbCanvas.Location = new System.Drawing.Point(13, 13);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(342, 381);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(480, 13);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 37);
            this.lblScore.TabIndex = 2;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(50, 40);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(102, 37);
            this.lblGameOver.TabIndex = 3;
            this.lblGameOver.Text = "label2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(594, 24);
            this.menuStrip1.TabIndex = 67;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extraProgramsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // extraProgramsToolStripMenuItem
            // 
            this.extraProgramsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem,
            this.paintToolStripMenuItem,
            this.snakeGameToolStripMenuItem,
            this.internetTvToolStripMenuItem,
            this.clocksToolStripMenuItem,
            this.pDFReaderToolStripMenuItem,
            this.audioFileReaderToolStripMenuItem,
            this.getIPToolStripMenuItem,
            this.mP3PlayerToolStripMenuItem,
            this.notepadToolStripMenuItem,
            this.speakToTextToolStripMenuItem,
            this.chatClientToolStripMenuItem,
            this.diceGameToolStripMenuItem});
            this.extraProgramsToolStripMenuItem.Name = "extraProgramsToolStripMenuItem";
            this.extraProgramsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.extraProgramsToolStripMenuItem.Text = "Extra Programs";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regularToolStripMenuItem,
            this.sciencetificToolStripMenuItem});
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            // 
            // regularToolStripMenuItem
            // 
            this.regularToolStripMenuItem.Name = "regularToolStripMenuItem";
            this.regularToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.regularToolStripMenuItem.Text = "Regular";
            // 
            // sciencetificToolStripMenuItem
            // 
            this.sciencetificToolStripMenuItem.Name = "sciencetificToolStripMenuItem";
            this.sciencetificToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.sciencetificToolStripMenuItem.Text = "Sciencetific";
            // 
            // paintToolStripMenuItem
            // 
            this.paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            this.paintToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.paintToolStripMenuItem.Text = "Paint";
            // 
            // snakeGameToolStripMenuItem
            // 
            this.snakeGameToolStripMenuItem.Name = "snakeGameToolStripMenuItem";
            this.snakeGameToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.snakeGameToolStripMenuItem.Text = "Snake Game";
            // 
            // internetTvToolStripMenuItem
            // 
            this.internetTvToolStripMenuItem.Name = "internetTvToolStripMenuItem";
            this.internetTvToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.internetTvToolStripMenuItem.Text = "Internet Tv";
            // 
            // clocksToolStripMenuItem
            // 
            this.clocksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.digitalClockToolStripMenuItem,
            this.analongClockToolStripMenuItem});
            this.clocksToolStripMenuItem.Name = "clocksToolStripMenuItem";
            this.clocksToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.clocksToolStripMenuItem.Text = "Clocks";
            // 
            // digitalClockToolStripMenuItem
            // 
            this.digitalClockToolStripMenuItem.Name = "digitalClockToolStripMenuItem";
            this.digitalClockToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.digitalClockToolStripMenuItem.Text = "Digital Clock";
            // 
            // analongClockToolStripMenuItem
            // 
            this.analongClockToolStripMenuItem.Name = "analongClockToolStripMenuItem";
            this.analongClockToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.analongClockToolStripMenuItem.Text = "Analong Clock";
            // 
            // pDFReaderToolStripMenuItem
            // 
            this.pDFReaderToolStripMenuItem.Name = "pDFReaderToolStripMenuItem";
            this.pDFReaderToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.pDFReaderToolStripMenuItem.Text = "PDF Reader";
            // 
            // audioFileReaderToolStripMenuItem
            // 
            this.audioFileReaderToolStripMenuItem.Name = "audioFileReaderToolStripMenuItem";
            this.audioFileReaderToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.audioFileReaderToolStripMenuItem.Text = "Audio File Reader";
            // 
            // getIPToolStripMenuItem
            // 
            this.getIPToolStripMenuItem.Name = "getIPToolStripMenuItem";
            this.getIPToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.getIPToolStripMenuItem.Text = "Get IP";
            // 
            // mP3PlayerToolStripMenuItem
            // 
            this.mP3PlayerToolStripMenuItem.Name = "mP3PlayerToolStripMenuItem";
            this.mP3PlayerToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.mP3PlayerToolStripMenuItem.Text = "MP3 Player";
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.notepadToolStripMenuItem.Text = "Notepad";
            // 
            // speakToTextToolStripMenuItem
            // 
            this.speakToTextToolStripMenuItem.Name = "speakToTextToolStripMenuItem";
            this.speakToTextToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.speakToTextToolStripMenuItem.Text = "Speak to Text";
            // 
            // chatClientToolStripMenuItem
            // 
            this.chatClientToolStripMenuItem.Name = "chatClientToolStripMenuItem";
            this.chatClientToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.chatClientToolStripMenuItem.Text = "Chat Client";
            // 
            // diceGameToolStripMenuItem
            // 
            this.diceGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singlePlayerToolStripMenuItem,
            this.twoPlayerToolStripMenuItem});
            this.diceGameToolStripMenuItem.Name = "diceGameToolStripMenuItem";
            this.diceGameToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.diceGameToolStripMenuItem.Text = "Dice Game";
            // 
            // singlePlayerToolStripMenuItem
            // 
            this.singlePlayerToolStripMenuItem.Name = "singlePlayerToolStripMenuItem";
            this.singlePlayerToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.singlePlayerToolStripMenuItem.Text = "Single Player";
            // 
            // twoPlayerToolStripMenuItem
            // 
            this.twoPlayerToolStripMenuItem.Name = "twoPlayerToolStripMenuItem";
            this.twoPlayerToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.twoPlayerToolStripMenuItem.Text = "Two Player";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Snake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 419);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCanvas);
            this.Name = "Snake";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Snake_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Snake_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraProgramsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snakeGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internetTvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digitalClockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analongClockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFReaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem audioFileReaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mP3PlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speakToTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diceGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singlePlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twoPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sciencetificToolStripMenuItem;
    }
}