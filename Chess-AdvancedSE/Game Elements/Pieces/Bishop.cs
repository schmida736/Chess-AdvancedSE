namespace Chess_AdvancedSE
{
    public class Bishop : Piece
    {
        public Bishop(bool color) : base(color) {
            ImageSource += "b";
            if (color) { ImageSource += "l"; }
            else { ImageSource += "d"; }
            ImageSource += ".png";
        }

    }
}
