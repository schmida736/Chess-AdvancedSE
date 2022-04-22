namespace Chess_AdvancedSE
{
    public class King : Piece, IDiagonal, IStraight
    {
        public IBoardLayout board;
        public King(bool color, IBoardLayout board) : base(color) {
            ImageSource += "k";
            if (color) { ImageSource += "l"; }
            else { ImageSource += "d"; }
            ImageSource += ".png";

            this.board = board;
        }

        

        public override bool MoveIsValid(Square from, Square to)
        {
            if (IsStraightMoveable(from, to)) { return StraightMoveIsValid(from, to); }
            else { return DiagonalMoveIsValid(from, to); }
        }

        public override bool IsMoveable(Square from, Square to)
        {
            return IsStraightMoveable(from, to) | IsDiagonalMoveable(from, to);
        }

        public bool IsStraightMoveable(Square from, Square to)
        {
            return (GetSquareDistance(to.Row, from.Row) == 1 && GetSquareDistance(to.Column, from.Column) == 0) 
                |  (GetSquareDistance(to.Row, from.Row) == 0 && GetSquareDistance(to.Column, from.Column) == 1);
        }

        public bool StraightMoveIsValid(Square from, Square to)
        {
            return board.GetPiece(to)?.Color != board.GetPiece(from).Color;
        }

        public bool DiagonalMoveIsValid(Square from, Square to)
        {
            return board.GetPiece(to)?.Color != board.GetPiece(from).Color;
        }

        public bool IsDiagonalMoveable(Square from, Square to)
        {
            return GetSquareDistance(to.Row, from.Row) == GetSquareDistance(to.Column, from.Column) && GetSquareDistance(to.Row, from.Row) == 1;
        }
    }
}
