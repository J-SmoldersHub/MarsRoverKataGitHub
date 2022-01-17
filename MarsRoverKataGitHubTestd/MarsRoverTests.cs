using MarsRoverKataGitHub;
using Xunit;

namespace MarsRoverKataGitHubTestd
{
    public class MarsRoverTests
    {
        [Fact]
        public void MarsRoverInitalize()
        {
            // Arrange
            var rover = new MarsRover();

            // Act

            // Assert
            Assert.Equal(0, rover.X_Position);
            Assert.Equal(0, rover.Y_Position);
        }
    }
}
