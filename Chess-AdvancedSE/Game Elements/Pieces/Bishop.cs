using System;

namespace Chess_AdvancedSE
{
    public class Bishop : Piece
    {
        public Bishop(bool color) : base(color) {
            ImageSource += "b";
            if (color) { ImageSource += "l"; }
            else { ImageSource += "d"; }
            ImageSource += ".png";
        }

        public bool IsMoveable(Square from, Square to)
        {
            int rowDifference = Math.Abs(to.Row - from.Row);
            int columnDifference = Math.Abs(to.Column - from.Column);

            return (rowDifference == columnDifference);
        }

    }
}
