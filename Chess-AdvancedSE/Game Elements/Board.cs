using System;
using System.Collections.Generic;

namespace Chess_AdvancedSE
{
    public class Board
    {
        public BoardLayout_ViewModel viewModel = new();
        public BoardLayout layout = new();

        public Board(Player player)
        {
            this.layout.SetToStartLayout(player);
            viewModel.layout = layout.GetAsList();
        }

        public bool MoveIsValid(Square from, Square to)
        {
            if(from.Row == to.Row && from.Column == to.Column) { return false; }

            if(layout.GetAsList()[from.Row][from.Column] != null)
            {
                Piece movingPiece = layout.GetAsList()[from.Row][from.Column].Piece;
                Piece destinationPiece = layout.GetAsList()[to.Row][to.Column].Piece;

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
                            if (destinationPiece?.Color != movingPieceColor)
                            {
                                int rowDifference = Math.Abs(to.Row - from.Row);
                                int columnDifference = Math.Abs(to.Column - from.Column);

                                if(rowDifference == 0)
                                {
                                    if (to.Column > from.Column)
                                    {
                                        for (int i = from.Column+1; i < to.Column; i++)
                                        {
                                            if (layout.GetAsList()[from.Row][i].Piece != null) { return false; }
                                        }
                                    }
                                    else
                                    {
                                        for (int i = from.Column-1; i > to.Column; i--)
                                        {
                                            if (layout.GetAsList()[from.Row][i].Piece != null) { return false; }
                                        }
                                    }
                                    return true; //nothing in the way
                                }
                                else if (columnDifference == 0)
                                {
                                    if (to.Row > from.Row)
                                    {
                                        for (int i = from.Row + 1; i < to.Row; i++)
                                        {
                                            if (layout.GetAsList()[i][from.Column].Piece != null) { return false; }
                                        }
                                    }
                                    else
                                    {
                                        for (int i = from.Row - 1; i > to.Row; i--)
                                        {
                                            if (layout.GetAsList()[i][from.Column].Piece != null) { return false; }
                                        }
                                    }
                                    return true; //nothing in the way
                                }
                                else
                                {
                                    if(to.Row > from.Row)
                                    {
                                        if(to.Column > from.Column)
                                        {
                                            for (int i = 1; i < columnDifference; i++)
                                            {
                                                if (layout.GetAsList()[from.Row + i][from.Column + i].Piece != null) { return false; }
                                            }
                                        }
                                        else
                                        {
                                            for (int i = 1; i < columnDifference; i++)
                                            {
                                                if (layout.GetAsList()[from.Row + i][from.Column - i].Piece != null) { return false; }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (to.Column > from.Column)
                                        {
                                            for (int i = 1; i < columnDifference; i++)
                                            {
                                                if (layout.GetAsList()[from.Row - i][from.Column + i].Piece != null) { return false; }
                                            }
                                        }
                                        else
                                        {
                                            for (int i = 1; i < columnDifference; i++)
                                            {
                                                if (layout.GetAsList()[from.Row - i][from.Column - i].Piece != null) { return false; }
                                            }
                                        }
                                    }
                                }
                                return true; //nothing in the way
                            }
                            break;

                        case Bishop:
                            if (destinationPiece?.Color != movingPieceColor)
                            {
                                int rowDifference = Math.Abs(to.Row - from.Row);
                                int columnDifference = Math.Abs(to.Column - from.Column);
                                if (to.Row > from.Row)
                                {
                                    if (to.Column > from.Column)
                                    {
                                        for (int i = 1; i < columnDifference; i++)
                                        {
                                            if (layout.GetAsList()[from.Row + i][from.Column + i].Piece != null) { return false; }
                                        }
                                    }
                                    else
                                    {
                                        for (int i = 1; i < columnDifference; i++)
                                        {
                                            if (layout.GetAsList()[from.Row + i][from.Column - i].Piece != null) { return false; }
                                        }
                                    }
                                }
                                else
                                {
                                    if (to.Column > from.Column)
                                    {
                                        for (int i = 1; i < columnDifference; i++)
                                        {
                                            if (layout.GetAsList()[from.Row - i][from.Column + i].Piece != null) { return false; }
                                        }
                                    }
                                    else
                                    {
                                        for (int i = 1; i < columnDifference; i++)
                                        {
                                            if (layout.GetAsList()[from.Row - i][from.Column - i].Piece != null) { return false; }
                                        }
                                    }
                                }
                                return true; //nothing in the way
                            }                            
                            break;

                        case Knight:
                            if (destinationPiece?.Color != movingPieceColor)
                            {
                                return true;
                            }
                            break;

                        case Rook:
                            if (destinationPiece?.Color != movingPieceColor)
                            {
                                int rowDifference = Math.Abs(to.Row - from.Row);
                                int columnDifference = Math.Abs(to.Column - from.Column);

                                if (rowDifference == 0)
                                {
                                    if (to.Column > from.Column)
                                    {
                                        for (int i = from.Column + 1; i < to.Column; i++)
                                        {
                                            if (layout.GetAsList()[from.Row][i].Piece != null) { return false; }
                                        }
                                    }
                                    else
                                    {
                                        for (int i = from.Column - 1; i > to.Column; i--)
                                        {
                                            if (layout.GetAsList()[from.Row][i].Piece != null) { return false; }
                                        }
                                    }
                                    return true; //nothing in the way
                                }
                                else if (columnDifference == 0)
                                {
                                    if (to.Row > from.Row)
                                    {
                                        for (int i = from.Row + 1; i < to.Row; i++)
                                        {
                                            if (layout.GetAsList()[i][from.Column].Piece != null) { return false; }
                                        }
                                    }
                                    else
                                    {
                                        for (int i = from.Row - 1; i > to.Row; i--)
                                        {
                                            if (layout.GetAsList()[i][from.Column].Piece != null) { return false; }
                                        }
                                    }
                                    return true; //nothing in the way
                                }
                            }
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

        public Square GetSquareFromCoords(int row, int col)
        {
            return layout.GetAsList()[row][col];
        }
    }
}
