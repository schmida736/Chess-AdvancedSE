using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_AdvancedSE
{
    public class Piece
    {
        public Piece(Constants.Color color)
        {
            Init(color);
        }

        void Init(Constants.Color color)
        {
            this.color = color;
        }
        public Constants.Color color;
    }
}
