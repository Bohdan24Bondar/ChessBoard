using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardTask
{
    class Cell : ICell
    {
        #region Private

        private Coordinate _positionOnBoard;
        private CellColor _currentColor;
        private FigureImage _picture;

        #endregion

        public Cell(Coordinate boardPosition, CellColor color, FigureImage picture)
        {
            _positionOnBoard = boardPosition;
            _currentColor = color;
            _picture = picture;
            
        }

        public Cell(ICell currentCell)
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
                    throw new FormatException("Wrong value for <Color>");
                }

                _currentColor = value;
            } 
        }

        public FigureImage Picture
        {
            get
            {
                return _picture;
            }
            private set
            {
                if (value < FigureImage.None)
                {
                    throw new FormatException("Wrong value for <Color>");
                }

                _picture = value;
            }
        }

    }
}
