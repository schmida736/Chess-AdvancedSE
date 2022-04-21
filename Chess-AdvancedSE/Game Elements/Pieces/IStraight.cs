using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_AdvancedSE
{
    public interface IStraight
    {
        public bool IsStraightMoveable(Square from, Square to);
        public bool StraightMoveIsValid(Square from, Square to);
    }
}
