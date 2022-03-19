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
        public void RequestMove(int row, int col)
        {
            //TODO
        }

        public BoardLayout getBoardLayout()
        {
            return game.board.boardLayout;
        }
    }
}
