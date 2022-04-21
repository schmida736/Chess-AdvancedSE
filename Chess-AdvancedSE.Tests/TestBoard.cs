using Xunit;
using Moq;

namespace Chess_AdvancedSE.Tests
{
    public class TestBoard {
        private Mock layout;
        private Player player;

        public TestBoard(){
            player = new Player();
            layout = new Mock<BoardLayout>();
        }




        [Fact]
        public void MoveIsValid_InvalidPathing_ReturnsFalse()
        {
            // Given
            Board board = new(player);
            Square from = new Square(0, 1);
            Square to = new Square(0, 5);

            // When



            // Then
            Assert.False(board.MoveIsValid(from, to));
        }

        [Fact]
        public void MoveIsValid_BlockedPath_ReturnsFalse()
        {
            // Given
        
            // When
        
            // Then
        }

        [Fact]
        public void MoveIsValid_SelfCheck_ReturnsFalse()
        {
            // Given
        
            // When
        
            // Then
        }

        [Fact]
        public void MoveIsValid_TakingOwnPiece_ReturnsFalse()
        {
            // Given
        
            // When
        
            // Then
        }
        
        [Fact]
        public void MoveIsValid_RegularMove_ReturnsTrue()
        {
            // Given
        
            // When
        
            // Then
        }

        [Fact]
        public void MoveIsValid_MoveWithTake_IsValid()
        {
            // Given
        
            // When
        
            // Then
        }

        [Fact]
        public void MoveDoesNotCheck_RegularMove_ReturnsTrue()
        {
            // Given
        
            // When
        
            // Then
        }

        [Fact]
        public void MoveDoesNotCheck_CheckingMove_ReturnsFalse()
        {
            // Given
        
            // When
        
            // Then
        }

        [Fact]
        public void MovePiece_MovesPiece()
        {
            // Given
        
            // When
        
            // Then
        }
    }
}