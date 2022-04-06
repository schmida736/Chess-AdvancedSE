using System;

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

        

        //TODO: #12 For the love of GOD, clean up this function @Purdbull
        public bool MoveIsValid(Square from, Square to)
        {
            if (from.Row == to.Row && from.Column == to.Column) { return false; }

            if (layout.GetAsList()[from.Row][from.Column] != null)
            {
                Piece movingPiece = layout.GetAsList()[from.Row][from.Column].Piece;
                Piece destinationPiece = layout.GetAsList()[to.Row][to.Column].Piece;

                bool movingPieceColor = movingPiece.Color; //TODO: #16 Fix crash @Purdbull

                if (movingPiece.IsMoveable(from, to) && MoveDoesNotCheck(from, to)) //hehe, codesmell
                {
                    return movingPiece.MoveIsValid(from, to); //this is the way!!! 

                    switch (movingPiece)//swich still there for doku snippets
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
                                else
                                {
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
                                            // TODO: #11 fckn move it to the right somehow @Purdbull
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

        public bool MoveDoesNotCheck(Square from, Square to)
        {
            //move pice
            //check check
            return false; //TODO: Implementation
        }

        public bool MovePiece(int from_row, int from_col, int to_row, int to_col)
        {
            Square fromSquare = this.layout.GetSquareFromCoords(from_row, from_col);
            Square toSquare = this.layout.GetSquareFromCoords(to_row, to_col);
            if (MoveIsValid(fromSquare, toSquare)){
                this.layout.ChangePiece(from_row, from_col, null);
                this.layout.ChangePiece(to_row, to_col, fromSquare.Piece);
                viewModel.layout = this.layout.GetAsList();
                return true;
            }
            else return false;
        }
    }
}
