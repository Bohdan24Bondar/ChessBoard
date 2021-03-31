using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardTask
{
    class EmptyCell : ICell
    {
        #region Private

        private Position _positionOnBoard;
        private CellColor _currentColor;

        #endregion

        public EmptyCell(Position boardPosition, CellColor color)
        {
            PositionOnBoard = new Position(boardPosition);
            Color = color;
        }

        public EmptyCell(ICell currentCell)
        {
            PositionOnBoard = new Position(currentCell.PositionOnBoard);
            Color = currentCell.Color;
        }

        public Position PositionOnBoard 
        {
            get
            {
                return new Position(_positionOnBoard);
            } 
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Empty reference for " +
                        "<PositionOnBoard>");
                }

                _positionOnBoard = value;
            }
        }

        public CellColor Color 
        {
            get
            {
                return _currentColor;
            }
            private set
            {
                if ((value < CellColor.None) || (value > CellColor.Black))
                {
                    throw new ArgumentException("Wrong value for <Color>");
                }

                _currentColor = value;
            } 
        }
    }
}
