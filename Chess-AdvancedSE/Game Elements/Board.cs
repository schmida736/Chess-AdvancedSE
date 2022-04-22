namespace Chess_AdvancedSE
{

    public class Board
    {
        public BoardLayout_ViewModel viewModel = new();
        public BoardLayout layout = new();

        private Piece getPieceFrom(Square square)
        {
            return layout.GetAsList()[square.Row][square.Column]?.Piece;
        }

        public Board(Player player)
        {
            this.layout.SetToStartLayout(player);
            viewModel.layout = layout.GetAsList();
        }



        //TODO: #12 For the love of GOD, clean up this function @Purdbull
        public bool MoveIsValid(Square from, Square to)
        {
            if (from.Row == to.Row && from.Column == to.Column) { return false; }
            if (layout.GetAsList()[from.Row][from.Column] != null)
            {
                if (getPieceFrom(from) == null) { return false; }

                if (getPieceFrom(from).IsMoveable(from, to) && MoveDoesNotCheck(from, to))
                {
                    return getPieceFrom(from).MoveIsValid(from, to);
                }
            }
            return false;
        }

        public bool MoveDoesNotCheck(Square from, Square to)
        {
            //move piece
            //check check
            return true; //TODO: Implementation
        }

        public bool MovePiece(int from_row, int from_col, int to_row, int to_col)
        {
            Square fromSquare = this.layout.GetSquareFromCoords(from_row, from_col);
            Square toSquare = this.layout.GetSquareFromCoords(to_row, to_col);
            if (MoveIsValid(fromSquare, toSquare))
            {
                this.layout.ChangePiece(to_row, to_col, fromSquare.Piece);
                this.layout.ChangePiece(from_row, from_col, null);
                viewModel.layout = this.layout.GetAsList();
                return true;
            }
            else return false;
        }
    }
}
