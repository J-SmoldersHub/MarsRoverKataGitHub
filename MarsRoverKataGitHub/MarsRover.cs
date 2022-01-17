namespace MarsRoverKataGitHub
{
    public class MarsRover
    {
        public int X_Position { get; set; }
        public int Y_Position { get; set; }

        public CompassDirection Direction { get; set; }

        public MarsRover()
        {
            X_Position = 0;
            Y_Position = 0;
            Direction = CompassDirection.N;
        }

        public void Movement(string input)
        {
            var array = input.ToCharArray();

            foreach(var c in array)
            {
                if (c == 'M')
                {
                    MoveForward();
                }
                if (c == 'R')
                {
                    TurnRight();
                }
                if (c == 'L')
                {
                    TurnLeft();
                }
            }
        }

        public string ReceivePosition() =>
            $"{this.X_Position} : {this.Y_Position} : {this.Direction.ToString()}";

        public void Movement(InputDirection input)
        {
            // not te be implemented yet
        }

        private void MoveForward()
        {
            if (this.Direction == CompassDirection.N)
            {
                Y_Position++;
            }
            if (this.Direction == CompassDirection.E)
            {
                X_Position = X_Position == 9
                    ? 0
                    : ++X_Position;
            }
            if (this.Direction == CompassDirection.S)
            {
                Y_Position = Y_Position == 0
                    ? 9
                    : --Y_Position;
            }
            if (this.Direction == CompassDirection.W)
            {
                X_Position = X_Position == 0
                    ? 9
                    : --X_Position;
            }
        }

        private void TurnLeft()
        {
            if (Direction == CompassDirection.N)
            {
                Direction = CompassDirection.W;
            }
            else
            {
                Direction--;
            }
        }

        private void TurnRight()
        {
            if (Direction == CompassDirection.W)
            {
                Direction = CompassDirection.N;
            }
            else
            {
                Direction++;
            }
        }
    }
}
