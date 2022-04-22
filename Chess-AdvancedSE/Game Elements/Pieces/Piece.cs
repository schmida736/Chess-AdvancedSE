using System;

namespace Chess_AdvancedSE
{
    public class Piece
    {
        protected Piece(bool color)
        {
            Init(color);
        }

        protected void Init(bool color)
        {
            Color = color;
            ImageSource += "../Resources/";
        }

        public bool Color { get; set; }
        public string ImageSource { get; set; }


        public virtual bool IsMoveable(Square from, Square to)
        {
            throw new NotImplementedException();
        }

        public virtual bool MoveIsValid(Square from, Square to)
        {
            throw new NotImplementedException();
        }

        public static int GetSquareDistance(int from, int to)
        {
            return Math.Abs(to - from);
        }
    }
}
