namespace Chess_AdvancedSE
{
    public class King : Piece
    {
        public IBoardLayout board;
        public King(bool color, IBoardLayout board) : base(color) {
            ImageSource += "k";
            if (color) { ImageSource += "l"; }
            else { ImageSource += "d"; }
            ImageSource += ".png";

            this.board = board;
        }

        public override bool IsMoveable(Square from, Square to)
        {
            int rowDifference = from.Row - to.Row;
            int columnDifference = from.Column - to.Column;

            if(rowDifference == 1 | rowDifference == -1 | rowDifference == 0)
            {
                if (columnDifference == 1| columnDifference == -1)
                {
                    return true;
                }
            }
            else if (columnDifference == 1 | columnDifference == -1 | columnDifference == 0)
            {
                if (rowDifference == 1 | rowDifference == -1)
                {
                    return true;
                }
            }
            return false;
        }

        public override bool MoveIsValid(Square from, Square to)
        {
            return board.GetPiece(to)?.Color != board.GetPiece(from).Color;
        }
    }
}
