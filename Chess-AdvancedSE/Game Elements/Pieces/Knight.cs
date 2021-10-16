namespace Chess_AdvancedSE
{
    public class Knight : Piece
    {
        public Knight(bool color) : base(color) {
            ImageSource += "n";
            if (color) { ImageSource += "l"; }
            else { ImageSource += "d"; }
            ImageSource += ".png";
        }

    }
}
