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
                    Y_Position++;
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

        public void Movement(InputDirection input)
        {
        }

        private void MoveForward()
        {

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
