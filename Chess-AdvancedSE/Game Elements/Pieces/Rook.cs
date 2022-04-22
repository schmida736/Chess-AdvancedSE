using System;

namespace Chess_AdvancedSE
{
    public class Rook : Piece, IStraight
    {
        public IBoardLayout board;
        public Rook(bool color, IBoardLayout board) : base(color)
        {
            ImageSource += "r";
            if (color) { ImageSource += "l"; }
            else { ImageSource += "d"; }
            ImageSource += ".png";

            this.board = board;
        }



        public override bool IsMoveable(Square from, Square to)
        {
            return IsStraightMoveable(from, to);
        }

        public override bool MoveIsValid(Square from, Square to)
        {
            return StraightMoveIsValid(from, to);
        }

        public bool IsStraightMoveable(Square from, Square to)
        {
            int rowDifference = Math.Abs(to.Row - from.Row);
            int columnDifference = Math.Abs(to.Column - from.Column);

            if ((rowDifference > 0) && (columnDifference == 0)) { return true; }
            if ((columnDifference > 0) && (rowDifference == 0)) { return true; }
            return false;
        }



        public bool StraightMoveIsValid(Square from, Square to)
        {
            if (to.Piece?.Color != from.Piece.Color)
            {
                int rowDifference = Math.Abs(to.Row - from.Row);
                int columnDifference = Math.Abs(to.Column - from.Column);

                if (rowDifference == 0)
                {
                    if (to.Column > from.Column)
                    {
                        for (int i = from.Column + 1; i < to.Column; i++)
                        {
                            if (board.GetPiece(board.GetSquare(from.Row, i)) != null) { return false; }
                        }
                    }
                    else
                    {
                        for (int i = from.Column - 1; i > to.Column; i--)
                        {
                            if (board.GetPiece(board.GetSquare(from.Row, i)) != null) { return false; }
                        }
                    }
                    return true; //nothing in the way
                }
                else if (columnDifference == 0)
                {
                    if (to.Row > from.Row)
                    {
                        for (int i = from.Row + 1; i < to.Row; i++)
                        {
                            if (board.GetPiece(board.GetSquare(i, from.Column)) != null) { return false; }
                        }
                    }
                    else
                    {
                        for (int i = from.Row - 1; i > to.Row; i--)
                        {
                            if (board.GetPiece(board.GetSquare(i, from.Column)) != null) { return false; }
                        }
                    }
                    return true; //nothing in the way
                }
            }
            return false;
        }
    }
}
