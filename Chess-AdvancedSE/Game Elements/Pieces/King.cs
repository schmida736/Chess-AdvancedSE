namespace Chess_AdvancedSE
{
    public class King : Piece
    {
        public King(bool color) : base(color) {
            ImageSource += "k";
            if (color) { ImageSource += "l"; }
            else { ImageSource += "d"; }
            ImageSource += ".png";
        }
    }
}
