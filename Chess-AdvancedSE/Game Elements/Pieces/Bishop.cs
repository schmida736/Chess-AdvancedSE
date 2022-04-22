using System;

namespace Chess_AdvancedSE
{
    public class Bishop : Piece, IDiagonal
    {
        public IBoardLayout board;
        public Bishop(bool color, IBoardLayout board) : base(color) {
            ImageSource += "b";
            if (color) { ImageSource += "l"; }
            else { ImageSource += "d"; }
            ImageSource += ".png";

            this.board = board;
        }

        public override bool IsMoveable(Square from, Square to)
        {
            return IsDiagonalMoveable(from, to);
        }

        public override bool MoveIsValid(Square from, Square to)
        {
            return DiagonalMoveIsValid(from, to);
        }

        public bool IsDiagonalMoveable(Square from, Square to)
        {
            return (GetSquareDistance(to.Row, from.Row) == GetSquareDistance(to.Column, from.Column));
        }

        public bool DiagonalMoveIsValid(Square from, Square to)
        {

            if (to.Piece?.Color != from.Piece.Color)
            {
                int rowDifference = Math.Abs(to.Row - from.Row);
                int columnDifference = Math.Abs(to.Column - from.Column);
                if (to.Row > from.Row)
                {
                    if (to.Column > from.Column)
                    {
                        for (int i = 1; i < columnDifference; i++)
                        {
                            if (board.GetPiece(board.GetSquare(from.Row + i, from.Column + i)) != null) { return false; }
                        }
                    }
                    else
                    {
                        for (int i = 1; i < columnDifference; i++)
                        {
                            if (board.GetPiece(board.GetSquare(from.Row + i, from.Column - i)) != null) { return false; }
                        }
                    }
                }
                else
                {
                    if (to.Column > from.Column)
                    {
                        for (int i = 1; i < columnDifference; i++)
                        {
                            if (board.GetPiece(board.GetSquare(from.Row - i, from.Column + i)) != null) { return false; }
                        }
                    }
                    else
                    {
                        for (int i = 1; i < columnDifference; i++)
                        {
                            if (board.GetPiece(board.GetSquare(from.Row - i, from.Column - i)) != null) { return false; }
                        }
                    }
                }
                return true; //nothing in the way
            }
            return false;
        }
    }
}


