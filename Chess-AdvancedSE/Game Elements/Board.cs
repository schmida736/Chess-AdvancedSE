using System;
using System.Collections.Generic;

namespace Chess_AdvancedSE
{
    public class Board
    {
        public Board(Game game)
        {
            layout = SetupLayout(game.player);
        }

        public List<Square> layout;

        public event EventHandler<Board> LayoutChanged;


        protected virtual void OnLayoutChanged(Board board)
        {
            EventHandler<Board> _handler = LayoutChanged;
            _handler?.Invoke(this, board);
        }

        private static List<Square> SetupLayout(Player player)
        {
            List<Square> layoutSetup = new(64);
            for (int i = 0; i < layoutSetup.Capacity; i++)
            {
                layoutSetup.Add(new Square());
            }
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
                layoutSetup[i].Piece = new Pawn(!player.Color);
            }

            layoutSetup[56].Piece = new Rook(!player.Color);
            layoutSetup[57].Piece = new Knight(!player.Color);
            layoutSetup[58].Piece = new Bishop(!player.Color);
            layoutSetup[59].Piece = new King(!player.Color);
            layoutSetup[60].Piece = new Queen(!player.Color);
            layoutSetup[61].Piece = new Bishop(!player.Color);
            layoutSetup[62].Piece = new Knight(!player.Color);
            layoutSetup[63].Piece = new Rook(!player.Color);

            return layoutSetup;
        }
    }
}
