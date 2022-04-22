namespace Chess_AdvancedSE
{
    interface IDiagonal
    {
        bool IsDiagonalMoveable(Square from, Square to);
        bool DiagonalMoveIsValid(Square from, Square to);
    }
}
