using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;

namespace Chess_AdvancedSE.Tests
{
    public class TestPieces
    {
        private BoardLayout layout = new();


        [Fact]
        void TestKing_IsMoveable_WalkTooFar_ReturnsFalse()
        {
            // Given
            King piece = new(true, layout);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(4, 7);

            // Then
            Assert.False(piece.IsMoveable(from, to));
        }
        
        [Fact]
        void TestKing_IsMoveable_WalkNone_ReturnsFalse()
        {
            // Given
            King piece = new(true, layout);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(4, 4);

            // Then
            Assert.False(piece.IsMoveable(from, to));
        }

        [Fact]
        void TestKing_IsMoveable_WalkOneForward_ReturnsTrue()
        {
            // Given
            King piece = new(true, layout);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(4, 5);

            // Then
            Assert.True(piece.IsMoveable(from, to));
        }

        [Fact]
        void TestKing_IsMoveable_WalkOneSideways_ReturnsTrue()
        {
            // Given
            King piece = new(true, layout);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(5, 4);

            // Then
            Assert.True(piece.IsMoveable(from, to));
        }

        [Fact]
        void TestKing_IsMoveable_WalkOneDiagonal_ReturnsTrue()
        {
            // Given
            King piece = new(true, layout);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(4, 5);

            // Then
            Assert.True(piece.IsMoveable(from, to));
        }


        [Fact]
        void TestRook_IsMoveable_WalkDiagonal_ReturnsFalse()
        {
            // Given
            Rook piece = new(true, layout);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(5, 5);

            // Then
            Assert.False(piece.IsMoveable(from, to));
        }
        [Fact]
        void TestRook_IsMoveable_WalkNone_ReturnsFalse()
        {
            // Given
            Rook piece = new(true, layout);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(4, 4);

            // Then
            Assert.False(piece.IsMoveable(from, to));
        }

        [Fact]
        void TestRook_IsMoveable_WalkStraight_ReturnsTrue()
        {
            // Given
            Rook piece = new(true, layout);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(4, 7);

            // Then
            Assert.True(piece.IsMoveable(from, to));
        }
        
        [Fact]
        void TestRook_IsMoveable_WalkSideways_ReturnsTrue()
        {
            // Given
            Rook piece = new(true, layout);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(7, 4);

            // Then
            Assert.True(piece.IsMoveable(from, to));
        }

        [Fact]
        void TestBishop_IsMoveable_WalkNone_ReturnsFalse()
        {
            // Given
            Bishop piece = new(true, layout);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(4, 4);

            // Then
            Assert.False(piece.IsMoveable(from, to));
        }

        [Fact]
        void TestBishop_IsMoveable_WalkStraight_ReturnsFalse()
        {
            // Given
            Bishop piece = new(true, layout);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(7, 4);

            // Then
            Assert.False(piece.IsMoveable(from, to));
        }

        [Fact]
        void TestBishop_IsMoveable_WalkSideways_ReturnsFalse()
        {
            // Given
            Bishop piece = new(true, layout);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(4, 7);

            // Then
            Assert.False(piece.IsMoveable(from, to));
        }


        [Fact]
        void TestBishop_IsMoveable_WalkDiagonalNE_ReturnsTrue()
        {
            // Given
            Bishop piece = new(true, layout);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(7, 7);

            // Then
            Assert.True(piece.IsMoveable(from, to));
        }
        
        [Fact]
        void TestBishop_IsMoveable_WalkDiagonalSE_ReturnsTrue()
        {
            // Given
            Bishop piece = new(true, layout);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(7, 1);

            // Then
            Assert.True(piece.IsMoveable(from, to));
        }

        [Fact]
        void TestBishop_IsMoveable_WalkDiagonalSW_ReturnsTrue()
        {
            // Given
            Bishop piece = new(true, layout);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(0, 0);

            // Then
            Assert.True(piece.IsMoveable(from, to));
        }

        [Fact]
        void TestBishop_IsMoveable_WalkDiagonalNW_ReturnsTrue()
        {
            // Given
            Bishop piece = new(true, layout);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(1, 7);

            // Then
            Assert.True(piece.IsMoveable(from, to));
        }

        [Fact]
        void TestKnight_IsMoveable_WalkNone_ReturnsFalse()
        {
            // Given
            Knight piece = new(true, layout);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(4, 4);

            // Then
            Assert.False(piece.IsMoveable(from, to));
        }

        [Fact]
        void TestKnight_IsMoveable_WalkOneForward_ReturnsFalse()
        {
            // Given
            Knight piece = new(true, layout);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(4, 5);

            // Then
            Assert.False(piece.IsMoveable(from, to));
        }

        [Fact]
        void TestKnight_IsMoveable_WalkTwoForward_ReturnsFalse()
        {
            // Given
            Knight piece = new(true, layout);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(4, 6);

            // Then
            Assert.False(piece.IsMoveable(from, to));
        }

        [Fact]
        void TestKnight_IsMoveable_WalkThreeForward_ReturnsFalse()
        {
            // Given
            Knight piece = new(true, layout);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(4, 7);

            // Then
            Assert.False(piece.IsMoveable(from, to));
        }

        [Fact]
        void TestKnight_IsMoveable_WalkForwardLeft_ReturnsTrue()
        {
            // Given
            Knight piece = new(true, layout);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(3, 6);

            // Then
            Assert.True(piece.IsMoveable(from, to));
        }

        [Fact]
        void TestKnight_IsMoveable_WalkRightDown_ReturnsTrue()
        {
            // Given
            Knight piece = new(true, layout);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(6, 3);

            // Then
            Assert.True(piece.IsMoveable(from, to));
        }

        [Fact]
        void TestKnight_IsMoveable_WalkDownLeft_ReturnsTrue()
        {
            // Given
            Knight piece = new(true, layout);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(2, 3);

            // Then
            Assert.True(piece.IsMoveable(from, to));
        }

        [Fact]
        void TestKnight_IsMoveable_WalkLeftUp_ReturnsTrue()
        {
            // Given
            Knight piece = new(true, layout);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(2, 5);

            // Then
            Assert.True(piece.IsMoveable(from, to));
        }

        [Fact]
        void TestQueen_IsMoveable_WalkNone_ReturnsFalse()
        {
            // Given
            Queen piece = new(true, layout);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(4, 4);

            // Then
            Assert.False(piece.IsMoveable(from, to));
        }

        [Fact]
        void TestQueen_IsMoveable_ThreeForwardOneRight_ReturnsFalse()
        {
            // Given
            Queen piece = new(true, layout);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(5, 7);

            // Then
            Assert.False(piece.IsMoveable(from, to));
        }

        [Fact]
        void TestQueen_IsMoveable_WalkHorizontally_ReturnsTrue()
        {
            // Given
            Queen piece = new(true, layout);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(7, 4);

            // Then
            Assert.True(piece.IsMoveable(from, to));
        }

        [Fact]
        void TestQueen_IsMoveable_WalkVertically_ReturnsTrue()
        {
            // Given
            Queen piece = new(true, layout);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(4, 7);

            // Then
            Assert.True(piece.IsMoveable(from, to));
        }

        [Fact]
        void TestQueen_IsMoveable_WalkDiagonally_ReturnsTrue()
        {
            // Given
            Queen piece = new(true, layout);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(7, 7);

            // Then
            Assert.True(piece.IsMoveable(from, to));
        }

        [Fact]
        void TestPawn_IsMoveable_WalkNone_ReturnsFalse()
        {
            // Given
            Pawn piece = new(true);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(4, 4);

            // Then
            Assert.False(piece.IsMoveable(from, to));
        }

        [Fact]
        void TestPawn_IsMoveable_WalkHorizontally_ReturnsFalse()
        {
            // Given
            Pawn piece = new(true);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(4, 5);

            // Then
            Assert.False(piece.IsMoveable(from, to));
        }

        [Fact]
        void TestPawn_IsMoveable_WalkOneVertically_ReturnsTrue()
        {
            // Given
            Pawn piece = new(true);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(5, 4);

            // Then
            Assert.True(piece.IsMoveable(from, to));
        }

        [Fact]
        void TestPawn_IsMoveable_WalkTwoVertically_ReturnsTrue()
        {
            // Given
            Pawn piece = new(true);
            layout.SetEmptyLayout();

            // When
            layout.ChangePiece(4, 4, piece);
            Square from = layout.GetSquare(4, 4);
            Square to = layout.GetSquare(6, 4);

            // Then
            Assert.True(piece.IsMoveable(from, to));
        }


    }
}
