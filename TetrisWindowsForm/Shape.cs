using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisWindowsForm
{
    internal class Shape //it is a square
    {
        public bool[,] blocks { get; set; }
        public Size size { get; set; }
        public Point location { get; set; }
        public Color color { get; set; }

        public Shape(bool[,] _blocks, Point loc, Color color)
        {
            size = new Size(_blocks.GetLength(1), _blocks.GetLength(0));
            this.blocks = new bool[size.Height, size.Width];
            Array.Copy(_blocks, this.blocks, size.Width * size.Height);
            location = loc;
            this.color = color;

        }

        public Shape(Shape other)
        {
            size = new Size(other.blocks.GetLength(1), other.blocks.GetLength(0));
            this.blocks = new bool[size.Height, size.Width];
            Array.Copy(other.blocks, this.blocks, size.Width * size.Height);
            location = new Point(other.location.X, other.location.Y);
            this.color = other.color;
        }

        public void rotate()
        {
            bool[,] rotated = new bool[size.Width, size.Height];

            for (int i = 0; i <  size.Width; i++)
            {
                for (int j = 0; j < size.Height; j++)
                {
                    rotated[size.Height - i - 1, j] = blocks[j, i];
                }
            }

            blocks = rotated;
        }
        public void derotate()
        {
            bool[,] rotated = new bool[size.Width, size.Height];

            for (int i = 0; i < size.Width; i++)
            {
                for (int j = 0; j < size.Height; j++)
                {
                    rotated[j, i] = blocks[size.Height - i - 1, j];
                }
            }

            blocks = rotated;
        }

        public bool get(Point p)
        {
            return blocks[p.Y - location.Y, p.X - location.X];
        }

        public void set(Point p, bool val)
        {
            blocks[p.Y - location.Y, p.X - location.X] = val;
        }

        public bool intersectPoint(Point loc)
        {
            if (loc.X >= location.X && loc.X < location.X + size.Width &&
                loc.Y >= location.Y && loc.Y < location.Y + size.Height)
            {
                return true;
            }
            return false;
        }

        public bool intersect(Shape other)
        {
            for (int i = 0; i < size.Width; i++)
            {
                for (int j = 0; j < size.Height; j++)
                {
                    Point loc = new Point(this.location.X + j, this.location.Y + i);

                    if (this.intersectPoint(loc) && other.intersectPoint(loc) && this.get(loc) && other.get(loc))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool isOutOfBounds(Shape other)
        {
            for (int i = 0; i < size.Height; i++)
            {
                for (int j = 0; j < size.Width; j++)
                {
                    if (blocks[i, j] && !other.intersectPoint(new Point(location.X + j, location.Y + i)))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public void move(Point vec)
        {
            location = new Point(location.X + vec.X, location.Y + vec.Y);
        }

        public void drawShape(Shape other)
        {
            for (int i = 0; i < other.size.Height; i++)
            {
                for (int j = 0; j < other.size.Width; j++)
                {
                    if (other.blocks[i, j])
                    {
                        this.blocks[other.location.Y + i, other.location.X + j] = true;
                    }
                }
            }
        }

        public int destroyFullLines()
        {
            int point = 0;

            for (int i = 0; i < size.Height; i++)
            {
                bool is_full = true;

                for (int j = 0; j < size.Width; j++)
                {
                    if (!blocks[i, j])
                    {
                        is_full = false; break;
                    }    
                }

                if (is_full)
                {
                    point++;
                    for (int k = i; k > 0; k--)
                    {
                        for (int l = 0; l < size.Width; l++)
                        {
                            blocks[k, l] = blocks[k - 1, l];
                        }
                    }

                    for (int k = 0; k < size.Width; k++)
                    {
                        blocks[0, k] = false;
                    }
                }
            }

            return point;
        }

        public void clearShape(Shape other)
        {
            for (int i = 0; i < other.size.Height; i++)
            {
                for (int j = 0; j < other.size.Width; j++)
                {
                    if (other.blocks[i, j])
                    {
                        this.blocks[other.location.Y + i, other.location.X + j] = false;
                    }
                }
            }
        }
        public bool isEmpty()
        {
            for (int i = 0; i < size.Height; i++)
            {
                for (int j = 0; j < size.Width; j++)
                {
                    if (blocks[i, j]) return false;
                }
            }

            return true;
        }
        public bool isEmptyOnShape(Shape other)
        {
            for (int i = 0; i <  size.Height; i++)
            {
                for (int j = 0; j <  size.Width; j++)
                {
                    if (this.blocks[i, j] && other.intersectPoint(new Point(this.location.X + j, this.location.Y + i)) && other.blocks[this.location.Y + i, this.location.X + j]) return false;
                }
            }

            return true;
        }
    }
}
