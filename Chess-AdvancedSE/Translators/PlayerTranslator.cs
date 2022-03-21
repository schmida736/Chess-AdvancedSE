using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Chess_AdvancedSE
{
    public class PlayerTranslator
    {
        private Game game;
        public PlayerTranslator(Game game)
        {
            this.game = game;
        }

        public bool getPlayerColor() {
            return game.player.Color;
        }

        public bool RequestMove(int from_row, int from_col, int to_row, int to_col)
        {
            //TODO maybe process requests via event queue in Board???
            game.RecieveMoveRequest(from_row, from_col, to_row, to_col);
            throw new NotImplementedException();
        }

        public BoardLayout GetBoardLayout()
        {
            return game.board.boardLayout;
        }
    }
}
