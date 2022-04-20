using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_AdvancedSE
{
    interface IDiagonal
    {
        bool IsDiagonalMoveable(Square from, Square to);
        bool DiagonalMoveIsValid(Square from, Square to);
    }
}
