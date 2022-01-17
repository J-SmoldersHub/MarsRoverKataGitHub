using System;

namespace MarsRoverKataGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomizer = new Randomizer();
            string input = "";

            for (var i = 0; i < 20; i++)
            {
                input += randomizer.GetRandomMovement();

                var rover = new MarsRover();
                rover.Movement(input);

                string output = rover.ReceivePosition(input);
                Console.WriteLine(output);
                Console.ReadLine();
            }

            Console.WriteLine("Mars Rover stopped working");
            Console.ReadLine();
        }
    }
}
