namespace ConnectFourGrapical
{
    partial class NewGame
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
            this.lPlayer1 = new System.Windows.Forms.Label();
            this.lPlayer2 = new System.Windows.Forms.Label();
            this.lRows = new System.Windows.Forms.Label();
            this.lColumns = new System.Windows.Forms.Label();
            this.tPlayer2 = new System.Windows.Forms.TextBox();
            this.tPlayer1 = new System.Windows.Forms.TextBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.tRows = new System.Windows.Forms.NumericUpDown();
            this.tColumns = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.tRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tColumns)).BeginInit();
            this.SuspendLayout();
            // 
            // lPlayer1
            // 
            this.lPlayer1.AutoSize = true;
            this.lPlayer1.Location = new System.Drawing.Point(6, 15);
            this.lPlayer1.Name = "lPlayer1";
            this.lPlayer1.Size = new System.Drawing.Size(79, 13);
            this.lPlayer1.TabIndex = 0;
            this.lPlayer1.Text = "Player 1 Name:";
            // 
            // lPlayer2
            // 
            this.lPlayer2.AutoSize = true;
            this.lPlayer2.Location = new System.Drawing.Point(6, 41);
            this.lPlayer2.Name = "lPlayer2";
            this.lPlayer2.Size = new System.Drawing.Size(79, 13);
            this.lPlayer2.TabIndex = 0;
            this.lPlayer2.Text = "Player 2 Name:";
            // 
            // lRows
            // 
            this.lRows.AutoSize = true;
            this.lRows.Location = new System.Drawing.Point(6, 68);
            this.lRows.Name = "lRows";
            this.lRows.Size = new System.Drawing.Size(77, 13);
            this.lRows.TabIndex = 0;
            this.lRows.Text = "Number Rows:";
            // 
            // lColumns
            // 
            this.lColumns.AutoSize = true;
            this.lColumns.Location = new System.Drawing.Point(6, 94);
            this.lColumns.Name = "lColumns";
            this.lColumns.Size = new System.Drawing.Size(90, 13);
            this.lColumns.TabIndex = 0;
            this.lColumns.Text = "Number Columns:";
            // 
            // tPlayer2
            // 
            this.tPlayer2.Location = new System.Drawing.Point(108, 38);
            this.tPlayer2.Name = "tPlayer2";
            this.tPlayer2.Size = new System.Drawing.Size(146, 20);
            this.tPlayer2.TabIndex = 2;
            this.tPlayer2.Text = "Player 2";
            // 
            // tPlayer1
            // 
            this.tPlayer1.Location = new System.Drawing.Point(108, 12);
            this.tPlayer1.Name = "tPlayer1";
            this.tPlayer1.Size = new System.Drawing.Size(146, 20);
            this.tPlayer1.TabIndex = 1;
            this.tPlayer1.Text = "Player 1";
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(140, 117);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(57, 23);
            this.bCancel.TabIndex = 5;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(203, 117);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(51, 23);
            this.bStart.TabIndex = 6;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // tRows
            // 
            this.tRows.Location = new System.Drawing.Point(108, 65);
            this.tRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tRows.Name = "tRows";
            this.tRows.Size = new System.Drawing.Size(146, 20);
            this.tRows.TabIndex = 3;
            this.tRows.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // tColumns
            // 
            this.tColumns.Location = new System.Drawing.Point(108, 94);
            this.tColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tColumns.Name = "tColumns";
            this.tColumns.Size = new System.Drawing.Size(146, 20);
            this.tColumns.TabIndex = 4;
            this.tColumns.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 149);
            this.Controls.Add(this.tColumns);
            this.Controls.Add(this.tRows);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.tPlayer1);
            this.Controls.Add(this.tPlayer2);
            this.Controls.Add(this.lColumns);
            this.Controls.Add(this.lRows);
            this.Controls.Add(this.lPlayer2);
            this.Controls.Add(this.lPlayer1);
            this.Name = "NewGame";
            this.Text = "New Game";
            ((System.ComponentModel.ISupportInitialize)(this.tRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tColumns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lPlayer1;
        private System.Windows.Forms.Label lPlayer2;
        private System.Windows.Forms.Label lRows;
        private System.Windows.Forms.Label lColumns;
        private System.Windows.Forms.TextBox tPlayer2;
        private System.Windows.Forms.TextBox tPlayer1;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.NumericUpDown tRows;
        private System.Windows.Forms.NumericUpDown tColumns;
    }
}