namespace Chess_AdvancedSE
{
    public class Pawn : Piece
    {
        public Pawn(bool color) : base(color) {
            ImageSource += "p";
            if (color) { ImageSource += "l"; }
            else { ImageSource += "d"; }
            ImageSource += ".png";
        }

    }
}
