namespace Chess_AdvancedSE
{
    public class Square
    {
        public Square(int row, int column)
        {
            Row = row;
            Column = column;
        }
        public Piece Piece { get; set; }

        public int Row { get; set; }
        public int Column { get; set; }
    }
}
