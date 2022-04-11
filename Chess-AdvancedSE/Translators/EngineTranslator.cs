using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_AdvancedSE
{
    class EngineTranslator
    {
        private Game _game;
        public EngineTranslator(Game game) => _game = game;
        public string GetBoardLayout()
        {
            //TODO later: Translate layout to UCI string
            BoardLayout layout = _game.board.layout;
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
