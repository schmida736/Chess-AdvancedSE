using System;
using System.Collections.Generic;

namespace Chess_AdvancedSE
{
    public class Board
    {
        public Board(Player player)
        {
            boardLayout.Layout = SetupLayout(player);
        }

        public BoardLayout boardLayout = new();


        private static List<List<Square>> SetupLayout(Player player)
        {
            List<List<Square>> layoutSetup = new();
            for (int row = 0; row < 8; row++)
            {
                layoutSetup.Add(new List<Square>());
                for (int column = 0; column < 8; column++)
                {
                    layoutSetup[row].Add(new Square(row, column));
                }
            }
            layoutSetup[0][0].Piece = new Rook(player.Color);
            layoutSetup[0][1].Piece = new Knight(player.Color);
            layoutSetup[0][2].Piece = new Bishop(player.Color);
            layoutSetup[0][3].Piece = new King(player.Color);
            layoutSetup[0][4].Piece = new Queen(player.Color);
            layoutSetup[0][5].Piece = new Bishop(player.Color);
            layoutSetup[0][6].Piece = new Knight(player.Color);
            layoutSetup[0][7].Piece = new Rook(player.Color);

            for(int column = 0; column < 8; column++)
            {
                layoutSetup[1][column].Piece = new Pawn(player.Color);
                layoutSetup[6][column].Piece = new Pawn(!player.Color);
            }


            layoutSetup[7][0].Piece = new Rook(!player.Color);
            layoutSetup[7][1].Piece = new Knight(!player.Color);
            layoutSetup[7][2].Piece = new Bishop(!player.Color);
            layoutSetup[7][3].Piece = new King(!player.Color);
            layoutSetup[7][4].Piece = new Queen(!player.Color);
            layoutSetup[7][5].Piece = new Bishop(!player.Color);
            layoutSetup[7][6].Piece = new Knight(!player.Color);
            layoutSetup[7][7].Piece = new Rook(!player.Color);

            return layoutSetup;
        }

        public bool MoveIsValid(Square from, Square to)
        {
            if(boardLayout.Layout[from.Row][from.Column] != null)
            {
                Piece movingPiece = boardLayout.Layout[from.Row][from.Column].Piece;
                Piece destinationPiece = boardLayout.Layout[to.Row][to.Column].Piece;

                bool movingPieceColor = movingPiece.Color;

                if (movingPiece.IsMoveable(from, to) && MoveDoesntCheck(from, to)) //hehe, codesmell
                {
                    switch (movingPiece)
                    {
                        case King:
                            if (destinationPiece?.Color != movingPieceColor)
                            {
                                return true;
                            }
                            break;

                        case Queen:                 
                            break;

                        case Bishop:
                            break;

                        case Knight:
                            break;

                        case Rook:
                            break;

                        case Pawn:
                            break;

                        default:
                            return false;
                    }
                }
                    
            }
            return false;
        } 

        public bool MoveDoesntCheck(Square from, Square to)
        {
            //move pice
            //check check
            return false; //TODO: Implementation
        }

        public void MovePiece(Square from, Square to)
        {

        }
    }
}
