namespace Chess_AdvancedSE
{
    public class Game
    {
        public Player player;
        public Board board;

        private Player playerOne;
        private Player playerTwo;
        private bool currentPlayerColor;


        public Game()
        {
            player = new(Constants.Color.Random());
            board = new(player);

            playerOne = player;
            playerTwo = new(!player.Color);

            currentPlayerColor = !playerOne.Color;
        }

        public bool RecieveMoveRequest(int from_row, int from_col, int to_row, int to_col)
        {
            System.Console.WriteLine("Move detected");

            if(board.viewModel.layout[from_row][from_col].Piece?.Color == currentPlayerColor)
            {
                if(board.MovePiece(from_row, from_col, to_row, to_col))
                {
                    currentPlayerColor = !currentPlayerColor;
                    return true;
                }
            }
            return false;
        }

        
    }
}
