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
        private List<ICell> _plentyCells;

        #endregion

        public ChessBoard(int height, int width)
        {
            Height = height;
            Width = width;
            _plentyCells = null;
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
            set
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
            _plentyCells = new List<ICell>(_height * _width);
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

                    _plentyCells.Add(new EmptyCell(new Position(row, column), currentColor));
                    isWhiteColor = !isWhiteColor;
                }

                isWhiteColor = !isWhiteColor;
            }
        }

        public void GetBoardCells(out ICollection<ICell> boardCells)
        {
            boardCells = new List<ICell>(_height * _width);

            foreach (var cell in _plentyCells)
            {
                boardCells.Add(new EmptyCell(cell));
            }
        }
    }
}
