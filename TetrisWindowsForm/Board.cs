using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisWindowsForm
{
    internal class Board
    {
        public bool[,] blocks { get; set; }
        public Size size { get; set; }

        public Board(bool[,] _blocks)
        {
            size = new Size(_blocks.GetLength(1), _blocks.GetLength(0));
            this.blocks = new bool[size.Height, size.Width];
            Array.Copy(_blocks, this.blocks, size.Width * size.Height);
        }

        public Board(Board other)
        {
            size = new Size(other.blocks.GetLength(1), other.blocks.GetLength(0));
            this.blocks = new bool[size.Height, size.Width];
            Array.Copy(other.blocks, this.blocks, size.Width * size.Height);
        }


    }
}
