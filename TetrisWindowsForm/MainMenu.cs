using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisWindowsForm
{
    public partial class MainMenu : Form
    {
        static public int last_score = 0;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            tetris_btn.Location = new Point((this.Width - tetris_btn.Width) / 2, (this.Height - tetris_btn.Height) / 2);
            battleship_btn.Location = new Point((this.Width - battleship_btn.Width) / 2, (int)((this.Height - battleship_btn.Height) / 1.5));
            player1_tb.Location = new Point(battleship_btn.Location.X + battleship_btn.Width + 10, battleship_btn.Location.Y);
            player2_tb.Location = new Point(battleship_btn.Location.X + battleship_btn.Width + 10, battleship_btn.Location.Y + battleship_btn.Height - player2_tb.Height);
            battleships_start_btn.Location = new Point(player1_tb.Location.X, player2_tb.Location.Y - battleships_start_btn.Height - 5);
            logo_img.Location = new Point((this.Width - logo_img.Width) / 2, tetris_btn.Height / 5);
            score_lbl.Location = new Point((this.Width - score_lbl.Width) / 2, this.Height - score_lbl.Height - 20);
            player1_tb.Visible = false;
            player2_tb.Visible = false;
            battleships_start_btn.Visible = false;
        }

        private void MainMenu_Resize(object sender, EventArgs e)
        {
            tetris_btn.Location = new Point((this.Width - tetris_btn.Width) / 2, (this.Height - tetris_btn.Height) / 2);
            battleship_btn.Location = new Point((this.Width - battleship_btn.Width) / 2, (int)((this.Height - battleship_btn.Height) / 1.5));
            player1_tb.Location = new Point(battleship_btn.Location.X + battleship_btn.Width + 10, battleship_btn.Location.Y);
            player2_tb.Location = new Point(battleship_btn.Location.X + battleship_btn.Width + 10, battleship_btn.Location.Y + battleship_btn.Height - player2_tb.Height);
            battleships_start_btn.Location = new Point(player1_tb.Location.X, player2_tb.Location.Y - battleships_start_btn.Height - 5);
            logo_img.Location = new Point((this.Width - logo_img.Width) / 2, tetris_btn.Height / 5);
            score_lbl.Location = new Point((this.Width - score_lbl.Width) / 2, this.Height - score_lbl.Height - 100);
        }

        private void MainMenu_Activated(object sender, EventArgs e)
        {
            score_lbl.Text = "Score: " + last_score.ToString();
            score_lbl.Location = new Point((this.Width - score_lbl.Width) / 2, this.Height - score_lbl.Height - 100);
            player1_tb.Visible = false;
            player2_tb.Visible = false;
            battleships_start_btn.Visible = false;
        }

        private void MainMenu_Enter(object sender, EventArgs e)
        {
            score_lbl.Text = "Score: " + last_score.ToString();
            score_lbl.Location = new Point((this.Width - score_lbl.Width) / 2, this.Height - score_lbl.Height - 100);
            player1_tb.Visible = false;
            player2_tb.Visible = false;
            battleships_start_btn.Visible = false;
        }

        private void tetris_btn_Click(object sender, EventArgs e)
        {
            Form form = new TetrisGame();

            form.Show();
        }

        private void battleship_btn_Click(object sender, EventArgs e)
        {
            player1_tb.Visible = true;
            player2_tb.Visible = true;
            battleships_start_btn.Visible = true;
        }

        private void battleships_start_btn_Click(object sender, EventArgs e)
        {
            BattleShips.player1 = player1_tb.Text;
            BattleShips.player2 = player2_tb.Text;

            Form form = new BattleShips();

            form.Show();
        }
    }
}
