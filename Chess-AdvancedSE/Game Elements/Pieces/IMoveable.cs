using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_AdvancedSE
{
    interface IMoveable
    {
        public bool IsMoveable(Square from, Square to);
    }
}
