using System;

namespace Chess_AdvancedSE
{
    public class Knight : Piece
    {

        public IBoardLayout board;
        public Knight(bool color, IBoardLayout board) : base(color) {
            ImageSource += "n";
            if (color) { ImageSource += "l"; }
            else { ImageSource += "d"; }
            ImageSource += ".png";

            this.board = board;
        }

        public override bool IsMoveable(Square from, Square to)
        {
            int rowDifference = Math.Abs(to.Row - from.Row);
            int columnDifference = Math.Abs(to.Column - from.Column);

            if ((rowDifference == 2) && (columnDifference == 1)) { return true; }
            if ((columnDifference == 2) && (rowDifference == 1)) { return true; }
            return false;
        }

        public override bool MoveIsValid(Square from, Square to)
        {
            return to.Piece?.Color != from.Piece.Color;           
        }

    }
}
