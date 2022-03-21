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
            //TODO: Ask Board if move is permitted
            return false;
        }
    }
}
