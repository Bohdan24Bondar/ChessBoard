using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardTask
{
    class ChessBoard
    {
        #region Consts

        public const int DEVIDER = 2;

        #endregion

        #region Private

        private int _height;
        private int _width;
        private Queue<ICell> _plentyCells;

        #endregion

        public ChessBoard(int height, int width)
        {
            Height = height;
            Width = width;
            _plentyCells = new Queue<ICell>(_height * _width);
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
                    throw new ArgumentException("<Height> less than 0");
                }

                if (value % DEVIDER != 0)
                {
                    throw new ArgumentException("<Height> is odd number");
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

                if (value % DEVIDER != 0)
                {
                    throw new ArgumentException("Width is odd number");
                }

                _width = value;
            }
        }

        public void FillBoard(bool isWhiteColor)
        {
            CellColor currentColor;

            for (int row = 0; row < _height; row++)
            {
                for (int column = 0; column < _width; column++)
                {
                    if (isWhiteColor)
                    {
                        currentColor = CellColor.White;
                    }
                    else
                    {
                        currentColor = CellColor.Black;
                    }

                    _plentyCells.Enqueue(new Cell(new Coordinate(row, column), 
                            currentColor, FigureImage.None));
                    isWhiteColor = !isWhiteColor;
                }

                isWhiteColor = !isWhiteColor;
            }
        }

        public void GetBoardCells(out Queue<ICell> boardCells)
        {
            boardCells = new Queue<ICell>(_height * _width);

            foreach (var cell in _plentyCells)
            {
                boardCells.Enqueue(new Cell(cell));
            }
        }
    }
}
