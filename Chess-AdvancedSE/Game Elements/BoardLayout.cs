using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_AdvancedSE
{
    public interface IBoardLayout
    {
        Square GetSquare(int row, int column);
        Piece GetPiece(Square square);
    }

    public class BoardLayout : IBoardLayout
    {
        private List<List<Square>> _layout;
        public BoardLayout()
        {
            this._layout = new();
        }

        public List<List<Square>>GetAsList()
        {
            return this._layout;
        }

        public void Set(List<List<Square>> layout)
        {
            this._layout = layout;
        }

        public Square GetSquareFromCoords(int row, int col)
        {
            return _layout[row][col];
        }

        public void ChangePiece(int row, int col, Piece piece){
            this._layout[row][col].Piece = piece;
        }
        public Square GetSquare(int row, int column)
        {
            return GetSquareFromCoords(row, column);
        }

        public Piece GetPiece(Square square)
        {
            return square.Piece;
        }

        public void SetToStartLayout(Player player)
        {
            List<List<Square>> startLayout = new();
            for (int row = 0; row < 8; row++)
            {
                startLayout.Add(new List<Square>());
                for (int column = 0; column < 8; column++)
                {
                    startLayout[row].Add(new Square(row, column));
                }
            }
            startLayout[0][0].Piece = new Rook(player.Color, this);
            startLayout[0][1].Piece = new Knight(player.Color, this);
            startLayout[0][2].Piece = new Bishop(player.Color, this);
            startLayout[0][3].Piece = new King(player.Color, this);
            startLayout[0][4].Piece = new Queen(player.Color, this);
            startLayout[0][5].Piece = new Bishop(player.Color, this);
            startLayout[0][6].Piece = new Knight(player.Color, this);
            startLayout[0][7].Piece = new Rook(player.Color, this);

            for (int column = 0; column < 8; column++)
            {
                startLayout[1][column].Piece = new Pawn(player.Color);
                startLayout[6][column].Piece = new Pawn(!player.Color);
            }


            startLayout[7][0].Piece = new Rook(!player.Color, this);
            startLayout[7][1].Piece = new Knight(!player.Color, this);
            startLayout[7][2].Piece = new Bishop(!player.Color, this);
            startLayout[7][3].Piece = new King(!player.Color, this);
            startLayout[7][4].Piece = new Queen(!player.Color, this);
            startLayout[7][5].Piece = new Bishop(!player.Color, this);
            startLayout[7][6].Piece = new Knight(!player.Color, this);
            startLayout[7][7].Piece = new Rook(!player.Color, this);

            this._layout = startLayout;
        }
    }
}
