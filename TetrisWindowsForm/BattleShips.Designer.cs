namespace TetrisWindowsForm
{
    partial class BattleShips
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
            this.player1_pnl = new System.Windows.Forms.Panel();
            this.player2_pnl = new System.Windows.Forms.Panel();
            this.done_btn = new System.Windows.Forms.Button();
            this.turn_lbl = new System.Windows.Forms.Label();
            this.winner_lbl = new System.Windows.Forms.Label();
            this.player1_lbl = new System.Windows.Forms.Label();
            this.player2_lbl = new System.Windows.Forms.Label();
            this.player1_pnl.SuspendLayout();
            this.player2_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // player1_pnl
            // 
            this.player1_pnl.Controls.Add(this.player1_lbl);
            this.player1_pnl.Location = new System.Drawing.Point(0, 0);
            this.player1_pnl.Name = "player1_pnl";
            this.player1_pnl.Size = new System.Drawing.Size(200, 100);
            this.player1_pnl.TabIndex = 0;
            // 
            // player2_pnl
            // 
            this.player2_pnl.Controls.Add(this.player2_lbl);
            this.player2_pnl.Location = new System.Drawing.Point(0, 361);
            this.player2_pnl.Name = "player2_pnl";
            this.player2_pnl.Size = new System.Drawing.Size(200, 100);
            this.player2_pnl.TabIndex = 1;
            // 
            // done_btn
            // 
            this.done_btn.BackColor = System.Drawing.Color.Red;
            this.done_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.done_btn.FlatAppearance.BorderSize = 0;
            this.done_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.done_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.done_btn.Location = new System.Drawing.Point(23, 230);
            this.done_btn.Margin = new System.Windows.Forms.Padding(2);
            this.done_btn.Name = "done_btn";
            this.done_btn.Size = new System.Drawing.Size(101, 44);
            this.done_btn.TabIndex = 0;
            this.done_btn.Text = "DONE";
            this.done_btn.UseVisualStyleBackColor = false;
            this.done_btn.Click += new System.EventHandler(this.done_btn_Click);
            // 
            // turn_lbl
            // 
            this.turn_lbl.AutoSize = true;
            this.turn_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turn_lbl.Location = new System.Drawing.Point(407, 242);
            this.turn_lbl.Name = "turn_lbl";
            this.turn_lbl.Size = new System.Drawing.Size(74, 25);
            this.turn_lbl.TabIndex = 2;
            this.turn_lbl.Text = ".. Turn";
            // 
            // winner_lbl
            // 
            this.winner_lbl.AutoSize = true;
            this.winner_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.winner_lbl.Location = new System.Drawing.Point(515, 240);
            this.winner_lbl.Name = "winner_lbl";
            this.winner_lbl.Size = new System.Drawing.Size(53, 20);
            this.winner_lbl.TabIndex = 3;
            this.winner_lbl.Text = ".. Turn";
            // 
            // player1_lbl
            // 
            this.player1_lbl.AutoSize = true;
            this.player1_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.player1_lbl.Location = new System.Drawing.Point(90, 13);
            this.player1_lbl.Name = "player1_lbl";
            this.player1_lbl.Size = new System.Drawing.Size(83, 25);
            this.player1_lbl.TabIndex = 0;
            this.player1_lbl.Text = "player1";
            // 
            // player2_lbl
            // 
            this.player2_lbl.AutoSize = true;
            this.player2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.player2_lbl.Location = new System.Drawing.Point(114, 24);
            this.player2_lbl.Name = "player2_lbl";
            this.player2_lbl.Size = new System.Drawing.Size(83, 25);
            this.player2_lbl.TabIndex = 1;
            this.player2_lbl.Text = "player2";
            // 
            // BattleShips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 642);
            this.Controls.Add(this.winner_lbl);
            this.Controls.Add(this.turn_lbl);
            this.Controls.Add(this.done_btn);
            this.Controls.Add(this.player2_pnl);
            this.Controls.Add(this.player1_pnl);
            this.Name = "BattleShips";
            this.Text = "BattleShips";
            this.Load += new System.EventHandler(this.BattleShips_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BattleShips_KeyPress);
            this.player1_pnl.ResumeLayout(false);
            this.player1_pnl.PerformLayout();
            this.player2_pnl.ResumeLayout(false);
            this.player2_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel player1_pnl;
        private System.Windows.Forms.Panel player2_pnl;
        private System.Windows.Forms.Button done_btn;
        private System.Windows.Forms.Label turn_lbl;
        private System.Windows.Forms.Label winner_lbl;
        private System.Windows.Forms.Label player1_lbl;
        private System.Windows.Forms.Label player2_lbl;
    }
}