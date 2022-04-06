using System;

namespace Chess_AdvancedSE
{
    public class Pawn : Piece
    {
        public Pawn(bool color) : base(color) {
            ImageSource += "p";
            if (color) { ImageSource += "l"; }
            else { ImageSource += "d"; }
            ImageSource += ".png";
        }

        public override bool IsMoveable(Square from, Square to)
        {
            int rowDifference = Math.Abs(to.Row - from.Row);
            int columnDifference = Math.Abs(to.Column - from.Column);

            if ((rowDifference > 0) && (rowDifference < 3) && (columnDifference == 0)) { return true; }
            if ((rowDifference == columnDifference) && (rowDifference == 1)) { return true; }
            

            return false;
        }

        public override bool MoveIsValid(Square from, Square to)
        {
            return true; //TODO
        }

    }
}
