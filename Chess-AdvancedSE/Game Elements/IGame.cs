namespace Chess_AdvancedSE
{
    public interface IGame
    {
        Board Board { get; }
        Player Player { get; }

        bool RecieveMoveRequest(int from_row, int from_col, int to_row, int to_col);
    }
}