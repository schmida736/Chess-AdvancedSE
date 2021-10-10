using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_AdvancedSE
{
    class Board
    {
        public Board(Game game)
        {
            this.layout = setupLayout(game.player);
        }
        public List<Square> layout;
        private List<Square> setupLayout(Player player)
        {
            List<Square> layoutSetup = new List<Square>(64);
            layoutSetup[0].piece = new Rook(player.color);
            layoutSetup[1].piece = new Knight(player.color);
            layoutSetup[2].piece = new Bishop(player.color);
            layoutSetup[3].piece = new King(player.color);
            layoutSetup[4].piece = new Queen(player.color);
            layoutSetup[5].piece = new Bishop(player.color);
            layoutSetup[6].piece = new Knight(player.color);
            layoutSetup[7].piece = new Rook(player.color);

            for(int i = 8; i <= 15; i++)
            {
                layoutSetup[i].piece = new Pawn(player.color);
            }

            //TODO: Inverse color!


            for (int i = 48; i <= 55; i++)
            {
                layoutSetup[i].piece = new Pawn(player.color);
            }

            layoutSetup[56].piece = new Rook(player.color);
            layoutSetup[57].piece = new Knight(player.color);
            layoutSetup[58].piece = new Bishop(player.color);
            layoutSetup[59].piece = new King(player.color);
            layoutSetup[60].piece = new Queen(player.color);
            layoutSetup[61].piece = new Bishop(player.color);
            layoutSetup[62].piece = new Knight(player.color);
            layoutSetup[63].piece = new Rook(player.color);

            return layoutSetup;
        }
    }
}
