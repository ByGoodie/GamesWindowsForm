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
    public partial class TetrisGame : Form
    {
        enum ShapeInstance : int
        {
            I, J, L, S, Z, T, O, Count
        }

        Size block_size = new Size(50, 50);

        Shape[] shape_instances = new Shape[(int)ShapeInstance.Count];
        Shape board = new Shape(new bool[20, 10], new Point(0, 0), Color.AliceBlue);

        List<Shape> shapes = new List<Shape>();
        Shape current_shape, next_shape;

        int score = 0;

        public TetrisGame()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();

            shape_instances[(int)ShapeInstance.I] = new Shape(new bool[,] { { false, false, false, false}, 
                                        { true, true, true, true},
                                        { false, false, false, false},
                                        { false, false, false, false} }, new Point(3, 0), Color.Orange);

            shape_instances[(int)ShapeInstance.J] = new Shape(new bool[,] { { true, false, false },
                                        { true, true, true },
                                        { false, false, false } }, new Point(3, 0), Color.Pink);

            shape_instances[(int)ShapeInstance.L] = new Shape(new bool[,] { { false, false, true },
                                        { true, true, true },
                                        { false, false, false } }, new Point(3, 0), Color.Red);

            shape_instances[(int)ShapeInstance.S] = new Shape(new bool[,] { { false, true, true },
                                        { true, true, false },
                                        { false, false, false } }, new Point(3, 0), Color.Green);

            shape_instances[(int)ShapeInstance.Z] = new Shape(new bool[,] { { true, true, false },
                                        { false, true, true },
                                        { false, false, false } }, new Point(3, 0), Color.Blue);

            shape_instances[(int)ShapeInstance.T] = new Shape(new bool[,] { { true, true, true },
                                        { false, true, false },
                                        { false, false, false } }, new Point(3, 0), Color.Purple);

            shape_instances[(int)ShapeInstance.O] = new Shape(new bool[,] { { true, true },
                                        { true, true } }, new Point(4, 0), Color.Yellow);
        }

        private void fallShape()
        {
            current_shape.move(new Point(0, 1));
            if (current_shape.intersect(board) || current_shape.isOutOfBounds(board))
            {
                current_shape.move(new Point(0, -1));
                board.drawShape(current_shape);
                score += board.destroyFullLines();
                Label score_lbl = (Label)next_pnl.Controls["score_lbl"];
                score_lbl.Text = "Score: " + score.ToString();
                clearBoard();
                nextShape();
                if (current_shape.intersect(board) )
                {
                    MainMenu.last_score = score;
                    this.Close();
                    return;
                }
                clearNextShape();
                drawNextShape(next_shape);
                drawShape(current_shape);
                drawShape(board);
                return;
            }
            clearBoard();
            drawShape(board);
            drawShape(current_shape);
        } 

        private void nextShape()
        {
            Random rnd = new Random();

            current_shape = next_shape;
            next_shape = new Shape(shape_instances[rnd.Next((int)ShapeInstance.Count)]);
        }

        private void drawShape(Shape shape)
        {
            for (int i = 0; i < shape.size.Height; i++)
            {
                for (int j = 0; j < shape.size.Width; j++)
                {
                    if (shape.blocks[i, j])
                    {
                        Button block = (Button)board_pnl.Controls["block_" + (shape.location.Y + i).ToString() + "_" + (shape.location.X + j).ToString()];
                        block.BackColor = shape.color;
                    }
                }
            }
        }

        private void clearNextShape()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Button block = (Button)next_pnl.Controls["next_block_" + i.ToString() + "_" + j.ToString()];
                    block.BackColor = Color.Black;                   
                }
            }
        }

        private void drawNextShape(Shape shape)
        {
            Point start = new Point(2 - shape.size.Width / 2, 2 - shape.size.Height / 2);

            for (int i = 0; i < shape.size.Height; i++)
            {
                for (int j = 0; j < shape.size.Width; j++)
                {
                    if (shape.blocks[i, j])
                    {
                        Button block = (Button)next_pnl.Controls["next_block_" + (start.Y + i).ToString() + "_" + (start.X + j).ToString()];
                        block.BackColor = shape.color;
                    }
                }
            }
        }

        private void clearBoard()
        {
            for (int i = 0; i < board.size.Height; i++)
            {
                for (int j = 0; j < board.size.Width; j++)
                {
                    Button btn = (Button)board_pnl.Controls["block_" + i.ToString() + "_" + j.ToString()];
                    btn.BackColor = Color.Black;
                }
            }

        }

        private void TetrisGame_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1000, 1100);
            board_pnl.Size = new Size(500, 1000);
            board_pnl.Location = new Point(this.Width - board_pnl.Width, 0);
            next_pnl.Location = new Point(0, 0);
            next_pnl.Size = new Size(this.Width - board_pnl.Width, this.Height);
            next_pnl.BackColor = Color.DarkGray;

            Point next_point = new Point(next_pnl.Width / 2 - 2 * block_size.Width, 60);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Button btn = new Button();

                    btn.Name = "next_block_" + i.ToString() + "_" + j.ToString();
                    btn.Text = "";
                    btn.BackColor = Color.Black;
                    btn.FlatAppearance.BorderColor = Color.Black;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 1;
                    btn.Location = new Point(next_point.X + j * block_size.Width, next_point.Y + i * block_size.Height);
                    btn.Size = block_size;
                    btn.Enabled = false;

                    next_pnl.Controls.Add(btn);
                }
            }

            /*Label score_lbl = new Label();
            score_lbl.Font = new Font(FontFamily.GenericMonospace, 16, FontStyle.Regular);
            score_lbl.Name = "score_lbl";
            score_lbl.Text = "Score: 0";
            //score_lbl.Location = new Point((this.Width - score_lbl.Width) / 2, 20);
            score_lbl.Location = new Point(0, 20);*/

            next_pnl.Controls.Add(score_lbl);

            for (int i = 0; i < board.size.Height; i++)
            {
                for (int j = 0; j < board.size.Width; j++)
                {
                    Button btn = new Button();

                    btn.Name = "block_" + i.ToString() + "_" + j.ToString();
                    btn.Text = "";
                    btn.BackColor = Color.Black;
                    btn.FlatAppearance.BorderColor = Color.Black;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 1;
                    btn.Location = new Point(j * block_size.Width, i * block_size.Height);
                    btn.Size = block_size;
                    btn.Enabled = false;
               
                    board_pnl.Controls.Add(btn);
                }
            }

            this.Controls.Add(next_pnl);
            this.Controls.Add(board_pnl);

            Random rnd = new Random();

            next_shape = new Shape(shape_instances[rnd.Next((int)ShapeInstance.Count)]);

            nextShape();

            drawNextShape(next_shape);
            drawShape(current_shape);
        }

        private void TetrisGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.Space:
                    current_shape.rotate();
                    if (current_shape.intersect(board) || current_shape.isOutOfBounds(board))
                    {
                        current_shape.derotate();
                        return;
                    }
                    clearBoard();
                    drawShape(board);
                    drawShape(current_shape);
                    break;

                case 'A':
                case 'a':
                    current_shape.move(new Point(-1, 0));
                    if (current_shape.intersect(board) || current_shape.isOutOfBounds(board))
                    {
                        current_shape.move(new Point(1, 0));
                        return;
                    }
                    clearBoard();
                    drawShape(board);
                    drawShape(current_shape);
                    break;

                case 'D':
                case 'd':
                    current_shape.move(new Point(1, 0));
                    if (current_shape.intersect(board) || current_shape.isOutOfBounds(board))
                    {
                        current_shape.move(new Point(-1, 0));
                        return;
                    }
                    clearBoard();
                    drawShape(board);
                    drawShape(current_shape);
                    break;

                case 'S':
                case 's':
                    fallShape();
                    break;
               
            }
        }

        private void FallTimer_Tick(object sender, EventArgs e)
        {
            fallShape();
        }

        private void TetrisGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu.last_score = score;
            this.Close();
        }
    }
}
