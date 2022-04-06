using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Chess_AdvancedSE
{
    public class Piece
    {
        protected Piece(bool color)
        {
            Init(color);
        }

        protected void Init(bool color)
        {
            Color = color;
            ImageSource += "../Resources/";
        }

        public bool Color { get; set; }
        public string ImageSource { get; set; }


        public virtual bool IsMoveable(Square from, Square to)
        {
            throw new NotImplementedException();
        }

        public virtual bool MoveIsValid(Square from, Square to)
        {
            throw new NotImplementedException();
        }
    }
}
