using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardTask
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ChessBoardController boardController = new ChessBoardController(true);
            boardController.Run();

            Console.ReadKey();
        }
    }
}
