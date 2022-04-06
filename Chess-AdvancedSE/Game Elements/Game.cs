namespace Chess_AdvancedSE
{
    public class Game
    {
        public Player player;
        public Board board;

        public Game()
        {
            player = new(Constants.Color.Random());
            board = new(player);
        }

        public bool RecieveMoveRequest(int from_row, int from_col, int to_row, int to_col)
        {
            System.Console.WriteLine("Move detected");
            return board.MovePiece(from_row, from_col, to_row, to_col);
        }
    }
}
