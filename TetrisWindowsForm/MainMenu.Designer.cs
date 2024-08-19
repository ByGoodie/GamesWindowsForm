namespace TetrisWindowsForm
{
    partial class MainMenu
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
            this.logo_img = new System.Windows.Forms.PictureBox();
            this.tetris_btn = new System.Windows.Forms.Button();
            this.score_lbl = new System.Windows.Forms.Label();
            this.battleship_btn = new System.Windows.Forms.Button();
            this.player1_tb = new System.Windows.Forms.TextBox();
            this.player2_tb = new System.Windows.Forms.TextBox();
            this.battleships_start_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).BeginInit();
            this.SuspendLayout();
            // 
            // logo_img
            // 
            this.logo_img.Image = global::TetrisWindowsForm.Properties.Resources.Logo;
            this.logo_img.Location = new System.Drawing.Point(580, 39);
            this.logo_img.Name = "logo_img";
            this.logo_img.Size = new System.Drawing.Size(186, 233);
            this.logo_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_img.TabIndex = 1;
            this.logo_img.TabStop = false;
            // 
            // tetris_btn
            // 
            this.tetris_btn.BackColor = System.Drawing.Color.Red;
            this.tetris_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.tetris_btn.FlatAppearance.BorderSize = 0;
            this.tetris_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tetris_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tetris_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tetris_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tetris_btn.Location = new System.Drawing.Point(580, 307);
            this.tetris_btn.Name = "tetris_btn";
            this.tetris_btn.Size = new System.Drawing.Size(213, 72);
            this.tetris_btn.TabIndex = 0;
            this.tetris_btn.Text = "TETRIS";
            this.tetris_btn.UseVisualStyleBackColor = false;
            this.tetris_btn.Click += new System.EventHandler(this.tetris_btn_Click);
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.score_lbl.ForeColor = System.Drawing.Color.White;
            this.score_lbl.Location = new System.Drawing.Point(614, 507);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(136, 37);
            this.score_lbl.TabIndex = 2;
            this.score_lbl.Text = "Score: 0";
            // 
            // battleship_btn
            // 
            this.battleship_btn.BackColor = System.Drawing.Color.Red;
            this.battleship_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.battleship_btn.FlatAppearance.BorderSize = 0;
            this.battleship_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.battleship_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.battleship_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.battleship_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.battleship_btn.Location = new System.Drawing.Point(558, 385);
            this.battleship_btn.Name = "battleship_btn";
            this.battleship_btn.Size = new System.Drawing.Size(266, 72);
            this.battleship_btn.TabIndex = 3;
            this.battleship_btn.Text = "Battle Ship";
            this.battleship_btn.UseVisualStyleBackColor = false;
            this.battleship_btn.Click += new System.EventHandler(this.battleship_btn_Click);
            // 
            // player1_tb
            // 
            this.player1_tb.Location = new System.Drawing.Point(830, 385);
            this.player1_tb.Name = "player1_tb";
            this.player1_tb.Size = new System.Drawing.Size(124, 20);
            this.player1_tb.TabIndex = 4;
            this.player1_tb.Text = "player1";
            // 
            // player2_tb
            // 
            this.player2_tb.Location = new System.Drawing.Point(830, 437);
            this.player2_tb.Name = "player2_tb";
            this.player2_tb.Size = new System.Drawing.Size(124, 20);
            this.player2_tb.TabIndex = 5;
            this.player2_tb.Text = "player2";
            // 
            // battleships_start_btn
            // 
            this.battleships_start_btn.BackColor = System.Drawing.Color.SlateGray;
            this.battleships_start_btn.FlatAppearance.BorderSize = 0;
            this.battleships_start_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.battleships_start_btn.Location = new System.Drawing.Point(830, 408);
            this.battleships_start_btn.Name = "battleships_start_btn";
            this.battleships_start_btn.Size = new System.Drawing.Size(75, 23);
            this.battleships_start_btn.TabIndex = 6;
            this.battleships_start_btn.Text = "START";
            this.battleships_start_btn.UseVisualStyleBackColor = false;
            this.battleships_start_btn.Click += new System.EventHandler(this.battleships_start_btn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1464, 630);
            this.Controls.Add(this.battleships_start_btn);
            this.Controls.Add(this.player2_tb);
            this.Controls.Add(this.player1_tb);
            this.Controls.Add(this.battleship_btn);
            this.Controls.Add(this.score_lbl);
            this.Controls.Add(this.logo_img);
            this.Controls.Add(this.tetris_btn);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.MainMenu_Activated);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Enter += new System.EventHandler(this.MainMenu_Enter);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainMenu_KeyPress);
            this.Resize += new System.EventHandler(this.MainMenu_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tetris_btn;
        private System.Windows.Forms.PictureBox logo_img;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.Button battleship_btn;
        private System.Windows.Forms.TextBox player1_tb;
        private System.Windows.Forms.TextBox player2_tb;
        private System.Windows.Forms.Button battleships_start_btn;
    }
}

