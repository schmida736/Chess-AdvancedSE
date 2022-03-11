using System;

namespace Chess_AdvancedSE
{
    public class Knight : Piece
    {
        public Knight(bool color) : base(color) {
            ImageSource += "n";
            if (color) { ImageSource += "l"; }
            else { ImageSource += "d"; }
            ImageSource += ".png";
        }

        public bool IsMoveable(Square from, Square to)
        {
            int rowDifference = Math.Abs(to.Row - from.Row);
            int columnDifference = Math.Abs(to.Column - from.Column);

            if ((rowDifference == 2) && (columnDifference == 1)) { return true; }
            if ((columnDifference == 2) && (rowDifference == 1)) { return true; }
            return false;
        }

    }
}
