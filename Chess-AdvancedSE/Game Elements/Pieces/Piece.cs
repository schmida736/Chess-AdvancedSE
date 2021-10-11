using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_AdvancedSE
{
    class Piece
    {
        protected Piece(bool color)
        {
            Init(color);
        }

        protected void Init(bool color)
        {
            this.color = color;
        }
        public bool color;
    }
}
