using Xunit;
using Moq;

namespace Chess_AdvancedSE.Tests
{
    public class TestSquare
    {

        private Mock player;

        public TestSquare(){
            player = new Mock<Player>(); //TODO: #15 Replace Player with mock @schmida736
        }

        [Fact]
        public void GetSquareFromCoords_ReturnedSquare_IsEmpty()
        {
            // Given
            BoardLayout layout = new();

            // When
            layout.SetToStartLayout(new Player());
            
            // Then
            Assert.Null(layout.GetSquareFromCoords(3, 3).Piece);
        }

        [Fact]
        public void GetSquareFromCoords_ReturnedSquare_HasExpectedPiece()
        {
            // Given
            BoardLayout layout = new();
            
            // When
            layout.SetToStartLayout(new Player(true));
        
            // Then
            Assert.IsType<Rook>(layout.GetSquareFromCoords(0, 0).Piece);
        }
        [Fact]
        public void GetSquareFromCoords_ReturnedSquare_HasExpectedCoordinates()
        {
            // Given
            BoardLayout layout = new();

            // When
            layout.SetToStartLayout(new Player(true));
        
            // Then
            Assert.Equal(layout.GetSquareFromCoords(7, 5).Row, 7);
            Assert.Equal(layout.GetSquareFromCoords(7, 5).Column, 5);
        }
    }
}
