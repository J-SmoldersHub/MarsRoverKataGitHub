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
        public void MarsRoverTurnRightOneStepForward()
        {
            // Arrange
            var rover = new MarsRover();

            // Act
            rover.Movement("RM");

            // Assert
            Assert.Equal(1, rover.X_Position);
            Assert.Equal(0, rover.Y_Position);
            Assert.Equal(CompassDirection.E, rover.Direction);
        }

        [Fact]
        public void MarsRoverMoving()
        {
            // Arrange
            var rover = new MarsRover();

            // Act
            rover.Movement("MMMRMMM");

            // Assert
            Assert.Equal(3, rover.X_Position);
            Assert.Equal(3, rover.Y_Position);
            Assert.Equal(CompassDirection.E, rover.Direction);
        }

        [Fact]
        public void MarsRoverMovingSouth()
        {
            // Arrange
            var rover = new MarsRover();

            // Act
            rover.Movement("MMMRRMM");

            // Assert
            Assert.Equal(0, rover.X_Position);
            Assert.Equal(1, rover.Y_Position);
            Assert.Equal(CompassDirection.S, rover.Direction);
        }

        [Fact]
        public void MarsRoverMovingLeft()
        {
            // Arrange
            var rover = new MarsRover();

            // Act
            rover.Movement("MMMRMMMLLM");

            // Assert
            Assert.Equal(2, rover.X_Position);
            Assert.Equal(3, rover.Y_Position);
            Assert.Equal(CompassDirection.W, rover.Direction);
        }

        [Fact]
        public void MarsRoverMovingLeftOverLapping()
        {
            // Arrange
            var rover = new MarsRover();

            // Act
            rover.Movement("MMMRMMMLLMMMM");

            // Assert
            Assert.Equal(9, rover.X_Position);
            Assert.Equal(3, rover.Y_Position);
            Assert.Equal(CompassDirection.W, rover.Direction);
        }

        [Fact]
        public void MarsRoverMovingDownOverLapping()
        {
            // Arrange
            var rover = new MarsRover();

            // Act
            rover.Movement("MMMRRMMMMM");

            // Assert
            Assert.Equal(0, rover.X_Position);
            Assert.Equal(8, rover.Y_Position);
            Assert.Equal(CompassDirection.S, rover.Direction);
        }


        [Fact]
        public void MarsRoverMovingRightOverLapping()
        {
            // Arrange
            var rover = new MarsRover();

            // Act
            rover.Movement("RMMMMMMMMMMM");

            // Assert
            Assert.Equal(1, rover.X_Position);
            Assert.Equal(0, rover.Y_Position);
            Assert.Equal(CompassDirection.E, rover.Direction);
        }

        [Fact]
        public void MarsRoverMovingUpOverLapping()
        {
            // Arrange
            var rover = new MarsRover();

            // Act
            rover.Movement("MMMMMMMMMMMM");

            // Assert
            Assert.Equal(0, rover.X_Position);
            Assert.Equal(2, rover.Y_Position);
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

        [Fact]
        public void MarsRoverTurnRightThreeTimes()
        {
            // Arrange
            var rover = new MarsRover();

            // Act
            rover.Movement("RRR");

            // Assert
            Assert.Equal(0, rover.X_Position);
            Assert.Equal(0, rover.Y_Position);
            Assert.Equal(CompassDirection.W, rover.Direction);
        }

        [Fact]
        public void MarsRoverTurnRightFourTimes()
        {
            // Arrange
            var rover = new MarsRover();

            // Act
            rover.Movement("RRRR");

            // Assert
            Assert.Equal(0, rover.X_Position);
            Assert.Equal(0, rover.Y_Position);
            Assert.Equal(CompassDirection.N, rover.Direction);
        }

        [Fact]
        public void MarsRoverTurnLeft()
        {
            // Arrange
            var rover = new MarsRover();

            // Act
            rover.Movement("L");

            // Assert
            Assert.Equal(0, rover.X_Position);
            Assert.Equal(0, rover.Y_Position);
            Assert.Equal(CompassDirection.W, rover.Direction);
        }

        [Fact]
        public void MarsRoverTurnLeftTwice()
        {
            // Arrange
            var rover = new MarsRover();

            // Act
            rover.Movement("LL");

            // Assert
            Assert.Equal(0, rover.X_Position);
            Assert.Equal(0, rover.Y_Position);
            Assert.Equal(CompassDirection.S, rover.Direction);
        }

        [Fact]
        public void MarsRoverTurnLeftThreeTimes()
        {
            // Arrange
            var rover = new MarsRover();

            // Act
            rover.Movement("LLL");

            // Assert
            Assert.Equal(0, rover.X_Position);
            Assert.Equal(0, rover.Y_Position);
            Assert.Equal(CompassDirection.E, rover.Direction);
        }

        [Fact]
        public void MarsRoverTurnLeftFourTimes()
        {
            // Arrange
            var rover = new MarsRover();

            // Act
            rover.Movement("LLLL");

            // Assert
            Assert.Equal(0, rover.X_Position);
            Assert.Equal(0, rover.Y_Position);
            Assert.Equal(CompassDirection.N, rover.Direction);
        }
    }
}