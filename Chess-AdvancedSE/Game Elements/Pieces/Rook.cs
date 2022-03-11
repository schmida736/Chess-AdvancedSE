using System;

namespace Chess_AdvancedSE
{
    public class Rook : Piece
    {
        public Rook(bool color) : base(color){
            ImageSource += "r";
            if (color) { ImageSource += "l"; }
            else { ImageSource += "d"; }
            ImageSource += ".png";
        }

        

        public bool IsMoveable(Square from, Square to)
        {
            int rowDifference = Math.Abs(to.Row - from.Row);
            int columnDifference = Math.Abs(to.Column - from.Column);

            if ((rowDifference > 0) && (columnDifference == 0)) { return true; }
            if ((columnDifference > 0) && (rowDifference == 0)) { return true; }
            return false;
        }
    }
}
