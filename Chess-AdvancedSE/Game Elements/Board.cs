using System.Collections.Generic;

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
            layoutSetup[0].Piece = new Rook(player.Color);
            layoutSetup[1].Piece = new Knight(player.Color);
            layoutSetup[2].Piece = new Bishop(player.Color);
            layoutSetup[3].Piece = new King(player.Color);
            layoutSetup[4].Piece = new Queen(player.Color);
            layoutSetup[5].Piece = new Bishop(player.Color);
            layoutSetup[6].Piece = new Knight(player.Color);
            layoutSetup[7].Piece = new Rook(player.Color);

            for(int i = 8; i <= 15; i++)
            {
                layoutSetup[i].Piece = new Pawn(player.Color);
            }

            //TODO: Inverse color!


            for (int i = 48; i <= 55; i++)
            {
                layoutSetup[i].Piece = new Pawn(player.Color);
            }

            layoutSetup[56].Piece = new Rook(player.Color);
            layoutSetup[57].Piece = new Knight(player.Color);
            layoutSetup[58].Piece = new Bishop(player.Color);
            layoutSetup[59].Piece = new King(player.Color);
            layoutSetup[60].Piece = new Queen(player.Color);
            layoutSetup[61].Piece = new Bishop(player.Color);
            layoutSetup[62].Piece = new Knight(player.Color);
            layoutSetup[63].Piece = new Rook(player.Color);

            return layoutSetup;
        }
    }
}
