using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardTask
{
    public class Position
    {
        private int _height;
        private int _width;

        public Position(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public Position(Position currentPosition)
        {
            Height = currentPosition.Height;
            Width = currentPosition.Width;
        }

        public int Height 
        {
            get
            {
                return _height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height less than 0");
                }

                _height = value;
            }
        }

        public int Width 
        {
            get
            {
                return _width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width less than 0");
                }

                _width = value;
            } 
        }

        public Position CurrentPosition 
        {
            get
            {
                return new Position(this);
            }
        }
    }
}
