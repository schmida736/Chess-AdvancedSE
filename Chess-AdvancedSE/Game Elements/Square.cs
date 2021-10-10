using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_AdvancedSE
{
    class Square
    {
        public Square(Piece piece = null)
        {
            this.piece = piece;
        }
        public Piece piece { get; set; }
    }
}
