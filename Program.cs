using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using rover_project.Controller;

namespace rover_project
{
    class Program
    {
        private static readonly DirectionController directionController = new DirectionController();

        static void Main(string[] args)
        {
            var inputFilePath = @"C:\Users\MONICA\source\repos\rover_project\Input.txt";

            Plateau plateau = new Plateau();

            List<Rover> rover = new List<Rover>();

            ReadInputFile(inputFilePath, ref plateau, ref rover);

            plateau.MoveRover(rover[0]);

            Console.ReadLine();
        }

        private static void ReadInputFile(String inputFilePath, ref Plateau plateau, ref List<Rover> rover)
        {
            var lines = File.ReadAllLines(inputFilePath);

            var plateau_coordinates = lines[0].Split(' ');

            plateau = new Plateau(Convert.ToInt32(plateau_coordinates[0]), Convert.ToInt32(plateau_coordinates[1]));

            for (int i = 1; i < lines.Count(); i++)
            {
                var rover_coordinates = lines[i].Split(' ');
                var rover_commands = lines[i + 1];

                rover.Add(new Rover
                {
                    x = Convert.ToInt32(rover_coordinates[0]),
                    y = Convert.ToInt32(rover_coordinates[1]),
                    direction = directionController.GetDirection(rover_coordinates[2]),
                    commands = rover_commands,
                });
                i++;
            }
        }
    }
}
