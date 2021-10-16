namespace Chess_AdvancedSE
{
    public class Queen : Piece
    {
        public Queen(bool color) : base(color) {
            ImageSource += "q";
            if (color) { ImageSource += "l"; }
            else { ImageSource += "d"; }
            ImageSource += ".png";
        }

    }
}
