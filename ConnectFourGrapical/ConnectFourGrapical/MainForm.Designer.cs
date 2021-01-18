namespace ConnectFourGrapical
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lPlayer = new System.Windows.Forms.ToolStripStatusLabel();
            this.pWin = new System.Windows.Forms.Panel();
            this.lWinner = new System.Windows.Forms.Label();
            this.pBoard = new ConnectFourGrapical.BoardPanel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pWin.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lPlayer});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lPlayer
            // 
            this.lPlayer.Name = "lPlayer";
            this.lPlayer.Size = new System.Drawing.Size(86, 17);
            this.lPlayer.Text = "Player: Player 1";
            // 
            // pWin
            // 
            this.pWin.Controls.Add(this.lWinner);
            this.pWin.Location = new System.Drawing.Point(0, 147);
            this.pWin.Name = "pWin";
            this.pWin.Size = new System.Drawing.Size(800, 96);
            this.pWin.TabIndex = 0;
            this.pWin.Visible = false;
            // 
            // lWinner
            // 
            this.lWinner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lWinner.Location = new System.Drawing.Point(0, 0);
            this.lWinner.Name = "lWinner";
            this.lWinner.Size = new System.Drawing.Size(800, 96);
            this.lWinner.TabIndex = 1;
            this.lWinner.Text = "lWinner";
            this.lWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lWinner.Click += new System.EventHandler(this.lWinner_Click);
            // 
            // pBoard
            // 
            this.pBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBoard.Board = null;
            this.pBoard.Location = new System.Drawing.Point(12, 35);
            this.pBoard.Name = "pBoard";
            this.pBoard.Size = new System.Drawing.Size(776, 381);
            this.pBoard.TabIndex = 0;
            this.pBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pBoard_MouseClick);
            this.pBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pBoard_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pWin);
            this.Controls.Add(this.pBoard);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pWin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lPlayer;
        private BoardPanel pBoard;
        private System.Windows.Forms.Panel pWin;
        private System.Windows.Forms.Label lWinner;
    }
}

