using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardTask
{
    public struct Coordinate
    {
        private int _height;
        private int _width;

        public Coordinate(int height, int width)
        {
            _height = height;
            _width = width;
        }

        public int Height 
        {
            get
            {
                return _height;
            }
            private set
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
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width less than 0");
                }

                _width = value;
            } 
        }
    }
}
