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
    public partial class BattleShips : Form
    {
        static public string player1, player2;

        private const int ship_count = 4;
        private int controlled_ship = -1;
        bool player1_turn = true;
        private Size block_size = new Size(40, 40), block_margin = new Size(1, 1);
        private Shape player1_board = new Shape(new bool[7, 9], new Point(0, 0), Color.Black),
            player2_board = new Shape(new bool[7, 9], new Point(0, 0), Color.Black);

        private void done_btn_Click(object sender, EventArgs e)
        {
            if (player1_pnl.Visible)
            {
                player1_pnl.Visible = false;
                player2_pnl.Visible = true;

                clearBoard(player1_pnl);
                randomizeShips();

                controlled_ship = -1;

                for (int i = 0; i < ship_count; i++)
                {
                    drawShip(player2_pnl, p2_ship_instances[i], i + 1);
                }
            }
            else
            {
                player1_pnl.Visible = true;
                done_btn.Visible = false;
                clearBoard(player2_pnl);

                turn_lbl.Visible = true;
                turn_lbl.Text = player1 + "'s turn";
                turn_lbl.Location = new Point((this.Width - turn_lbl.Width) / 2, 374);
            }
        }

        private Shape[] p1_ship_instances = new Shape[4], p2_ship_instances = new Shape[4];



        public BattleShips()
        {
            InitializeComponent();

            p1_ship_instances[0] = new Shape(
                new bool[2, 2]
                {
                    {true, true },
                    {false, false }
                },
                new Point(0, 0), Color.Black
            );

            p1_ship_instances[1] = new Shape(
                new bool[3, 3]
                {
                    {false, false, false },
                    {true, true, true },
                    {false, false, false },
                },
                new Point(0, 0), Color.Black
            );

            p1_ship_instances[2] = new Shape(
               new bool[4, 4]
               {
                    {false, false, false, false },
                    {true, true, true, true },
                    {false, false, false, false },
                    {false, false, false, false },
               },
               new Point(0, 0), Color.Black
           );

            p1_ship_instances[3] = new Shape(
              new bool[5, 5]
              {
                    {false, false, false, false, false },
                    {false, false, false, false, false},
                    {true, true, true, true, true },
                    {false, false, false, false, false },
                    {false, false, false, false, false },
              },
              new Point(0, 0), Color.Black
            );

            p2_ship_instances[0] = new Shape(
               new bool[2, 2]
               {
                    {true, true },
                    {false, false }
               },
               new Point(0, 0), Color.Black
           );

            p2_ship_instances[1] = new Shape(
                new bool[3, 3]
                {
                    {false, false, false },
                    {true, true, true },
                    {false, false, false },
                },
                new Point(0, 0), Color.Black
            );

            p2_ship_instances[2] = new Shape(
               new bool[4, 4]
               {
                    {false, false, false, false },
                    {true, true, true, true },
                    {false, false, false, false },
                    {false, false, false, false },
               },
               new Point(0, 0), Color.Black
           );

            p2_ship_instances[3] = new Shape(
              new bool[5, 5]
              {
                    {false, false, false, false, false },
                    {false, false, false, false, false},
                    {true, true, true, true, true },
                    {false, false, false, false, false },
                    {false, false, false, false, false },
              },
              new Point(0, 0), Color.Black
          );
        }

        private void placeRandom(Shape board, Shape ship)
        {
            Random rnd = new Random();

            if (rnd.Next(1) == 1) ship.rotate();

            do
            {
                ship.location = new Point(rnd.Next(9) - ship.size.Width / 2, rnd.Next(7) - ship.size.Height / 2);

                ship.isOutOfBounds(ship);
            } while (ship.isOutOfBounds(board) || board.intersect(ship));

            board.drawShape(ship);
        }

        private void randomizeShips()
        {
            Shape board = player1_pnl.Visible ? player1_board : player2_board;
            Shape[] ship_instances = player1_pnl.Visible ? p1_ship_instances : p2_ship_instances;

            for (int i = 0; i < ship_count; i++)
            {
                placeRandom(board, ship_instances[i]);
            }
        }

        private void BattleShips_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                    controlled_ship = int.Parse(e.KeyChar.ToString()) - 1;
                    return;
            }

            if ((player1_pnl.Visible && player2_pnl.Visible) || controlled_ship == -1)
                return;

            Shape board;
            Panel panel;
            Shape[] ship_instances;
            if (player1_pnl.Visible)
            {
                panel = player1_pnl;
                board = player1_board;
                ship_instances = p1_ship_instances;
            }
            else
            {
                panel = player2_pnl;
                board = player2_board;
                ship_instances = p2_ship_instances;
            }

            switch(e.KeyChar)
            {
                case 'd':
                case 'D':
                    board.clearShape(ship_instances[controlled_ship]);
                    ship_instances[controlled_ship].move(new Point(1, 0));
                    if (ship_instances[controlled_ship].isOutOfBounds(board) || board.intersect(ship_instances[controlled_ship]))
                    {
                        ship_instances[controlled_ship].move(new Point(-1, 0));
                    }
                    board.drawShape(ship_instances[controlled_ship]);
                    break;

                case 'a':
                case 'A':
                    board.clearShape(ship_instances[controlled_ship]);
                    ship_instances[controlled_ship].move(new Point(-1, 0));
                    if (ship_instances[controlled_ship].isOutOfBounds(board) || board.intersect(ship_instances[controlled_ship]))
                    {
                        ship_instances[controlled_ship].move(new Point(1, 0));
                    }
                    board.drawShape(ship_instances[controlled_ship]);
                    break;

                case 'w':
                case 'W':
                    board.clearShape(ship_instances[controlled_ship]);
                    ship_instances[controlled_ship].move(new Point(0, -1));
                    if (ship_instances[controlled_ship].isOutOfBounds(board) || board.intersect(ship_instances[controlled_ship]))
                    {
                        ship_instances[controlled_ship].move(new Point(0, 1));
                    }
                    board.drawShape(ship_instances[controlled_ship]);
                    break;

                case 's':
                case 'S':
                    board.clearShape(ship_instances[controlled_ship]);
                    ship_instances[controlled_ship].move(new Point(0, 1));
                    if (ship_instances[controlled_ship].isOutOfBounds(board) || board.intersect(ship_instances[controlled_ship]))
                    {
                        ship_instances[controlled_ship].move(new Point(0, -1));
                    }
                    board.drawShape(ship_instances[controlled_ship]);
                    break;

                case 'r':
                case 'R':
                    board.clearShape(ship_instances[controlled_ship]);
                    ship_instances[controlled_ship].rotate();
                    if (ship_instances[controlled_ship].isOutOfBounds(board) || board.intersect(ship_instances[controlled_ship]))
                    {
                        ship_instances[controlled_ship].derotate();
                    }
                    board.drawShape(ship_instances[controlled_ship]);
                    break;
            }

            clearBoard(panel);
            for (int i = 0; i < ship_count; i++)
            {
                drawShip(panel, ship_instances[i], i + 1);
            }
        }

        private void clearBoard(Panel panel)
        {
            for (int i = 0; i < player1_board.size.Height; i++)
            {
                for (int j = 0; j < player1_board.size.Width; j++)
                {
                    Button btn = (Button)panel.Controls["block_" + i.ToString() + "_" + j.ToString()];

                    btn.BackColor = Color.Blue;
                    btn.Text = "";
                }
            }
        }

        private void drawShip(Panel panel, Shape ship, int x)
        {
            int k = 1;
            for (int i = 0; i < ship.size.Height; i++)
            {
                for (int j = 0; j < ship.size.Width; j++)
                {
                    if (ship.blocks[i, j])
                    {
                        Button btn = (Button)panel.Controls["block_" + (ship.location.Y + i).ToString() + "_" + (ship.location.X + j).ToString()];
                        if (k++ == ship.size.Height / 2 && x != -1)
                            btn.Text = x.ToString();
                        btn.BackColor = ship.color;
                    }
                }
            }
        }

        private void BattleShips_Load(object sender, EventArgs e)
        {
            this.Size = new Size(450, 898);

            player1_pnl.Size = new Size(450, 374);
            player1_pnl.Location = new Point(0, 0);
            player2_pnl.Size = new Size(450, 374);
            player2_pnl.Location = new Point(0, 474);

            player1_lbl.Text = player1;
            player1_lbl.Location = new Point(player1_pnl.Width - player1_lbl.Width - 20, 0);

            player2_lbl.Text = player2;
            player2_lbl.Location = new Point(player2_pnl.Width - player2_lbl.Width - 20, 0);

            for (int i = 0; i < player1_board.size.Height; i++)
            {
                for (int j = 0; j < player1_board.size.Width; j++)
                {
                    Button btn = new Button();
                    btn.BackColor = Color.Blue;
                    btn.FlatAppearance.BorderColor = Color.AliceBlue;
                    btn.Name = "block_" + i.ToString() + "_" + j.ToString();
                    btn.Size = block_size;
                    btn.Location = new Point(j * block_size.Width + block_margin.Width * 2 * j + block_margin.Width, i * block_size.Height + block_margin.Height * 2 * i + block_margin.Height + 24);
                    btn.ForeColor = Color.White;
                    btn.Click += player1_click;
                    player1_pnl.Controls.Add(btn);
                }
            }

            for (int i = 0; i < player2_board.size.Height; i++)
            {
                for (int j = 0; j < player2_board.size.Width; j++)
                {
                    Button btn = new Button();
                    btn.BackColor = Color.Blue;

                    btn.FlatAppearance.BorderColor = Color.AliceBlue;
                    btn.Name = "block_" + i.ToString() + "_" + j.ToString();
                    btn.Size = block_size;
                    btn.Location = new Point(j * block_size.Width + block_margin.Width * 2 * j + block_margin.Width, i * block_size.Height + block_margin.Height * 2 * i + block_margin.Height + 24);
                    btn.ForeColor = Color.White;
                    btn.Click += player2_click;
                    player2_pnl.Controls.Add(btn);
                }

                this.KeyPreview = true;
            }

            randomizeShips();
            for (int i = 0; i < ship_count; i++)
            {
                drawShip(player1_pnl, p1_ship_instances[i], i + 1);
            }

            done_btn.Location = new Point((this.Width - done_btn.Width) / 2, 378);

            player2_pnl.Visible = false;
            turn_lbl.Visible = false;
            winner_lbl.Visible = false;
        }

        private void player1_click(object sender, EventArgs e)
        {
            if (!(player1_pnl.Visible && player2_pnl.Visible)) return;
            if (player1_turn) return;

            Button btn = (Button)sender;

            string[] parsed = btn.Name.Split('_');

            int i = int.Parse(parsed[1]), j = int.Parse(parsed[2]);


            if (player1_board.blocks[i, j])
            {
                btn.BackColor = Color.Black;
                player1_board.blocks[i, j] = false;

                for (int k = 0; k < ship_count; k++)
                {
                    if (p1_ship_instances[k].intersectPoint(new Point(j, i)))
                    {
                        if (p1_ship_instances[k].isEmptyOnShape(player1_board))
                        {
                            p1_ship_instances[k].color = Color.Green;
                            drawShip(player1_pnl, p1_ship_instances[k], -1);
                        }
                        break;
                    }
                }

                if (player1_board.isEmpty())
                {
                    player1_pnl.Enabled = false;
                    player2_pnl.Enabled = false;
                    winner_lbl.Text = player2 + " has gg ez won against trash " + player1;
                    winner_lbl.Location = new Point((this.Width - winner_lbl.Width) / 2, 374);
                    winner_lbl.Visible = true;
                    turn_lbl.Visible = false;
                }
            }
            else
            {
                btn.BackColor = Color.Red;
                player1_turn = true;
                turn_lbl.Text = player1 + "'s turn";
                turn_lbl.Location = new Point((this.Width - turn_lbl.Width) / 2, 374);
            }

            btn.Enabled = false;

        }

        private void player2_click(object sender, EventArgs e)
        {
            if (!(player1_pnl.Visible && player2_pnl.Visible)) return;
            if (!player1_turn) return;

            Button btn = (Button)sender;

            string[] parsed = btn.Name.Split('_');

            int i = int.Parse(parsed[1]), j = int.Parse(parsed[2]);


            if (player2_board.blocks[i, j])
            {
                btn.BackColor = Color.Black;
                player2_board.blocks[i, j] = false;

                for (int k = 0; k < ship_count; k++)
                {
                    if (p2_ship_instances[k].intersectPoint(new Point(j, i)))
                    {
                        if (p2_ship_instances[k].isEmptyOnShape(player2_board))
                        {
                            p2_ship_instances[k].color = Color.Green;
                            drawShip(player2_pnl, p2_ship_instances[k], -1);
                        }
                        break;
                    }
                }

                if (player2_board.isEmpty())
                {
                    player1_pnl.Enabled = false;
                    player2_pnl.Enabled = false;
                    winner_lbl.Text = player1 + " has gg ez won against trash " + player2;
                    winner_lbl.Location = new Point((this.Width - winner_lbl.Width) / 2, 374);
                    winner_lbl.Visible = true;
                    turn_lbl.Visible = false;
                }
            }
            else
            {
                btn.BackColor = Color.Red;
                player1_turn = false;
                turn_lbl.Text = player2 + "'s turn";
                turn_lbl.Location = new Point((this.Width - turn_lbl.Width) / 2, 374);
            }

            btn.Enabled = false;

        }
    }
}
