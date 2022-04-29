using System;

namespace Chess_AdvancedSE
{
    public class PlayerTranslator
    {
        private IGame _game;
        public PlayerTranslator(IGame game)
        {
            this._game = game;
        }

        public bool getPlayerColor()
        {
            return _game.Player.Color;
        }

        public bool RequestMove(Tuple<int, int> coords_from, Tuple<int, int> coords_to)
        {
            //TODO maybe process requests via event queue in Board???
            return _game.RecieveMoveRequest(coords_from.Item1, coords_from.Item2, coords_to.Item1, coords_to.Item2);
        }

        public BoardLayout_ViewModel GetBoardLayout()
        {
            return _game.Board.viewModel;
        }
    }
}
