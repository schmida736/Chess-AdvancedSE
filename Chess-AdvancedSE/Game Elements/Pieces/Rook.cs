namespace Chess_AdvancedSE
{
    public class Rook : Piece
    {
        public Rook(bool color) : base(color){
            ImageSource += "r";
            if (color) { ImageSource += "l"; }
            else { ImageSource += "d"; }
            ImageSource += ".png";
        }
    }
}
