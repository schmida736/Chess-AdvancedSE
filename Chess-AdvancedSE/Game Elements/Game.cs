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
    }
}
