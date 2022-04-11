using System;

namespace Chess_AdvancedSE
{
    public class PlayerTranslator
    {
        private Game _game;
        public PlayerTranslator(Game game)
        {
            this._game = game;
        }

        public bool getPlayerColor() {
            return _game.player.Color;
        }

        public bool RequestMove(Tuple<int, int> coords_from, Tuple<int, int> coords_to)
        {
            //TODO maybe process requests via event queue in Board???
            return _game.RecieveMoveRequest(coords_from.Item1, coords_from.Item2, coords_to.Item1, coords_to.Item2);
        }

        public BoardLayout_ViewModel GetBoardLayout()
        {
            return _game.board.viewModel;
        }
    }
}
