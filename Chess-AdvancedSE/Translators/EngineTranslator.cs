using System;

namespace Chess_AdvancedSE
{
    class EngineTranslator
    {
        private IGame _game;
        public EngineTranslator(IGame game) => _game = game;
        public string GetBoardLayout()
        {
            //TODO later: Translate layout to UCI string
            BoardLayout layout = _game.Board.layout;
            return new String("");
        }

        public bool RequestMove(string moveAsAlgebraicNotation)
        {
            //TODO later: calculate coords from Algebraic Notation string
            int from_row = 0, from_col = 0, to_row = 0, to_col = 0;
            return _game.RecieveMoveRequest(from_row, from_col, to_row, to_col);
        }
    }
}
