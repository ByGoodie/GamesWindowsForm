namespace TetrisWindowsForm
{
    partial class TetrisGame
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
            this.next_pnl = new System.Windows.Forms.Panel();
            this.score_lbl = new System.Windows.Forms.Label();
            this.board_pnl = new System.Windows.Forms.Panel();
            this.FallTimer = new System.Windows.Forms.Timer(this.components);
            this.next_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // next_pnl
            // 
            this.next_pnl.Controls.Add(this.score_lbl);
            this.next_pnl.Location = new System.Drawing.Point(0, 0);
            this.next_pnl.Name = "next_pnl";
            this.next_pnl.Size = new System.Drawing.Size(321, 231);
            this.next_pnl.TabIndex = 0;
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.score_lbl.Location = new System.Drawing.Point(13, 26);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(93, 26);
            this.score_lbl.TabIndex = 0;
            this.score_lbl.Text = "Score: 0";
            // 
            // board_pnl
            // 
            this.board_pnl.Location = new System.Drawing.Point(322, -3);
            this.board_pnl.Name = "board_pnl";
            this.board_pnl.Size = new System.Drawing.Size(1000, 1000);
            this.board_pnl.TabIndex = 1;
            // 
            // FallTimer
            // 
            this.FallTimer.Enabled = true;
            this.FallTimer.Interval = 1000;
            this.FallTimer.Tick += new System.EventHandler(this.FallTimer_Tick);
            // 
            // TetrisGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(781, 645);
            this.Controls.Add(this.board_pnl);
            this.Controls.Add(this.next_pnl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TetrisGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TetrisGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TetrisGame_FormClosed);
            this.Load += new System.EventHandler(this.TetrisGame_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TetrisGame_KeyPress);
            this.next_pnl.ResumeLayout(false);
            this.next_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel next_pnl;
        private System.Windows.Forms.Panel board_pnl;
        private System.Windows.Forms.Timer FallTimer;
        private System.Windows.Forms.Label score_lbl;
    }
}