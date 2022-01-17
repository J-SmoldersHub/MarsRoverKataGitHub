using System;

namespace MarsRoverKataGitHub
{
    public class Randomizer
    {
        public string GetRandomMovement()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 6);

            if (number <= 3)
                return "M";

            if (number == 4)
                return "L";

                return "R";
        }
    }
}
