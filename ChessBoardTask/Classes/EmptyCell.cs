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

        private Coordinate _positionOnBoard;
        private CellColor _currentColor;

        #endregion

        public EmptyCell(Coordinate boardPosition, CellColor color)
        {
            Position = boardPosition;
            Color = color;
        }

        public EmptyCell(ICell currentCell)
        {
            Position = currentCell.Position;
            Color = currentCell.Color;
        }

        public Coordinate Position 
        {
            get
            {
                return _positionOnBoard;
            } 
            private set
            {
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
