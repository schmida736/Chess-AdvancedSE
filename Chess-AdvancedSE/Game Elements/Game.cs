namespace Chess_AdvancedSE
{
    class Game
    {
        public Player player;
        public Board board;

        public Game()
        {
            player = new(Constants.Color.Random());
            board = new(this);
        }
    }
}
