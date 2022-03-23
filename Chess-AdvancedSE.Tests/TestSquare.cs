using Xunit;

namespace Chess_AdvancedSE.Tests
{
            //TODO: #10 Implement Unit Tests @schmida736
    public class TestSquare
    {
        Player player = new(false); //TODO: replace with mock
        [Fact]
        public void GetSquareFromCoords_ReturnedSquare_IsEmpty()
        {
            // Given
            BoardLayout layout = new();
            Square emptySquare = new(3, 3);

            // When
            layout.SetToStartLayout(player);
            
            // Then
            Assert.Null(layout.GetSquareFromCoords(3, 3).Piece);
        }

        [Fact]
        public void GetSquareFromCoords_ReturnedSquare_HasExpectedPiece()
        {
            // Given
            BoardLayout layout = new();
            Square emptySquare = new(0, 0);

            // When
            layout.SetToStartLayout(player);
        
            // Then
            Assert.IsType<Rook>(layout.GetSquareFromCoords(0, 0).Piece);
        }
        [Fact]
        public void GetSquareFromCoords_ReturnedSquare_HasExpectedCoordinates()
        {
            // Given
            BoardLayout layout = new();
            Square emptySquare = new(7, 5);

            // When
            layout.SetToStartLayout(player);
        
            // Then
            Assert.Equal(layout.GetSquareFromCoords(7, 5).Row, 7);
            Assert.Equal(layout.GetSquareFromCoords(7, 5).Column, 5);
        }

    }
}
