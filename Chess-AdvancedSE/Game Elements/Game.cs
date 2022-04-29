namespace Chess_AdvancedSE
{
    public class Game : IGame
    {
        private Player player;
        private Board board;
        private bool currentPlayerColor;


        public Game()
        {
            player = new(Constants.Color.Random());
            board = new(player);

            currentPlayerColor = true;
        }

        public Board Board { get => board; private set => board = value; }
        public Player Player { get => player; private set => player = value; }

        public bool RecieveMoveRequest(int from_row, int from_col, int to_row, int to_col)
        {
            System.Console.WriteLine("Move detected");

            if (board.viewModel.layout[from_row][from_col].Piece?.Color == currentPlayerColor)
            {
                if (board.MovePiece(from_row, from_col, to_row, to_col))
                {
                    currentPlayerColor = !currentPlayerColor;
                    return true;
                }
            }
            return false;
        }


    }
}
