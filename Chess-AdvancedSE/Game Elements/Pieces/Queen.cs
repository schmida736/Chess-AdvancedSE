using System;

namespace Chess_AdvancedSE
{
    public class Queen : Piece, IDiagonal, IStraight
    {
        private IBoardLayout board;
        public Queen(bool color, IBoardLayout board) : base(color) {
            ImageSource += "q";
            if (color) { ImageSource += "l"; }
            else { ImageSource += "d"; }
            ImageSource += ".png";

            this.board = board;
        }

        

        public override bool IsMoveable(Square from, Square to)
        {
            return IsStraightMoveable(from, to) | IsDiagonalMoveable(from,to);
        }

       

        public override bool MoveIsValid(Square from, Square to)
        {
            if(IsStraightMoveable(from, to)) { return StraightMoveIsValid(from, to); }
            else { return DiagonalMoveIsValid(from, to); }
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

        public bool IsStraightMoveable(Square from, Square to)
        {
            int rowDifference = Math.Abs(to.Row - from.Row);
            int columnDifference = Math.Abs(to.Column - from.Column);

            if ((rowDifference > 0) && (columnDifference == 0)) { return true; }
            if ((columnDifference > 0) && (rowDifference == 0)) { return true; }
            return false;
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

        public bool IsDiagonalMoveable(Square from, Square to)
        {
            int rowDifference = Math.Abs(to.Row - from.Row);
            int columnDifference = Math.Abs(to.Column - from.Column);

            return (rowDifference == columnDifference);
        }
    }
}
