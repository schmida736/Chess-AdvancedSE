using System;

namespace Chess_AdvancedSE
{
    public class Queen : Piece
    {
        public Queen(bool color) : base(color) {
            ImageSource += "q";
            if (color) { ImageSource += "l"; }
            else { ImageSource += "d"; }
            ImageSource += ".png";
        }

        public bool IsMoveable(Square from, Square to)
        {
            int rowDifference = Math.Abs(to.Row - from.Row);
            int columnDifference = Math.Abs(to.Column - from.Column);

            if (rowDifference == columnDifference)              { return true; }
            if ((rowDifference > 0) && (columnDifference == 0)) { return true; }
            if ((columnDifference > 0) && (rowDifference == 0)) { return true; }
            return false;
        }

    }
}
