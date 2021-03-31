using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardTask
{
    public interface ICell
    {
        Position PositionOnBoard { get; }

        CellColor Color { get; }
    }
}
