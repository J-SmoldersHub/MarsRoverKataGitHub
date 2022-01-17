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

        [Fact]
        public void MarsRoverOneStepForward()
        {
            // Arrange
            var rover = new MarsRover();

            // Act
            rover.Movement("M");

            // Assert
            Assert.Equal(0, rover.X_Position);
            Assert.Equal(1, rover.Y_Position);
            Assert.Equal(CompassDirection.N, rover.Direction);
        }

        [Fact]
        public void MarsRoverTurnRight()
        {
            // Arrange
            var rover = new MarsRover();

            // Act
            rover.Movement("R");

            // Assert
            Assert.Equal(0, rover.X_Position);
            Assert.Equal(0, rover.Y_Position);
            Assert.Equal(CompassDirection.E, rover.Direction);
        }

        [Fact]
        public void MarsRoverTurnRightTwice()
        {
            // Arrange
            var rover = new MarsRover();

            // Act
            rover.Movement("RR");

            // Assert
            Assert.Equal(0, rover.X_Position);
            Assert.Equal(0, rover.Y_Position);
            Assert.Equal(CompassDirection.S, rover.Direction);
        }
    }
}
