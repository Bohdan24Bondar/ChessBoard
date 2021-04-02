﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardTask
{
    class ConsoleController
    {
        public const string message = "Please enter even number for <Width> " +
            "than <,> and <Height>\nAfter these actions push <Enter>";
        
        #region Private

        private ChessBoard _currentBoard;
        private bool _isWhiteFirst;
        private Viewer _currentUI;

        #endregion

        public ConsoleController(bool isWhiteFirst)
        {
            _isWhiteFirst = isWhiteFirst;
            _currentBoard = null;
            _currentUI = null;
        }

        public void Run()
        {
            int height;
            int width;
            _currentUI = new Viewer();
            _currentUI.GetNumbers(message, out height, out width);
            _currentBoard = new ChessBoard(height, width);
            _currentBoard.FillBoard(_isWhiteFirst);
            ICollection<ICell> boardCells;
            _currentBoard.GetBoardCells(out boardCells);
            _currentUI.PrintBoard(boardCells);
        }
    }
}