namespace Chess_AdvancedSE
{
    class Square
    {
        public Square(Piece piece = null)
        {
            Piece = piece;
        }
        public Piece Piece { get; set; }
    }
}
