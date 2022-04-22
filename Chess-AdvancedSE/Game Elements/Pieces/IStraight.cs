namespace Chess_AdvancedSE
{
    public interface IStraight
    {
        public bool IsStraightMoveable(Square from, Square to);
        public bool StraightMoveIsValid(Square from, Square to);
    }
}
