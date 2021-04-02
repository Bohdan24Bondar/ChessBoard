using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardTask
{
    public interface ICell
    {
        Coordinate Position { get; }

        CellColor Color { get; }
    }
}
