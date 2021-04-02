using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardTask
{
    class Viewer
    {
        #region Consts

        public const int COUNT_OF_ARGS = 2;
        public const string ERROR_MESSAGE = "Wrong entered arguments";
        public const string WHITE_CELL = " ";
        public const string BLACK_CELL = "*";
        public const int COUNT_OF_SEPARATORS = 2;

        #endregion

        public bool GetNumbers(string mesage, out int height, out int width)
        {
            Console.WriteLine(mesage);
            string parametrs = Console.ReadLine();
            string[] destinationParametrs = parametrs.Split(new char[] { ',' }, COUNT_OF_SEPARATORS);
            
            if (destinationParametrs.Length > COUNT_OF_ARGS)
            {
                throw new ArgumentException("Wrong count of arguments");
            }

            bool isHeight = int.TryParse(destinationParametrs[0], out height);
            bool isWidth = int.TryParse(destinationParametrs[1], out width);

            if (!isHeight)
            {
                throw new ArgumentException("<Height> is not number");
            }

            if (!isWidth)
            {
                throw new ArgumentException("<Width> is not number");
            }

            return isHeight & isWidth;
        }

        public void PrintBoard(ICollection<ICell> boardCells)
        {
            Console.Clear();

            foreach (var cell in boardCells)
            {
                Console.SetCursorPosition(cell.Position.Width, cell.Position.Height);

                if (cell.Color == CellColor.White)
                {
                    Console.WriteLine(WHITE_CELL);
                }
                else
                {
                    if (cell.Color == CellColor.Black)
                    {
                        Console.WriteLine(BLACK_CELL);
                    }
                    else
                    {
                        throw new ArgumentException("Wrong color");
                    }
                }
            }
        }
    }












































    //public void InputParametrs(string mesage, out int height, out int width)
    //{
    //    string parametrs = string.Empty;
    //    bool isNumber = false;
    //    bool isError = false;

    //    do
    //    {
    //        if (isError)
    //        {
    //            Console.Clear();
    //            Console.WriteLine(ERROR_MESSAGE);
    //        }

    //        Console.WriteLine("mesage");
    //        parametrs = Console.ReadLine();
    //        isNumber = GetNumbers(parametrs, out height, out width);

    //    } while (!isNumber);
    //}
}
