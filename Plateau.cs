using rover_project.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rover_project
{
    class Plateau
    {
        private int x;
        private int y;
        private readonly RoverController roverController = new RoverController();
        public Plateau(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public void MoveRover(Rover rover)
        {
            Console.WriteLine("Rover start from (" + rover.x + "," + rover.y + "," + rover.direction + " )");
            var commands = rover.commands.ToCharArray();

            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == 'L')
                {
                    roverController.SpinLeft(rover);
                }
                else if (commands[i] == 'R')
                {
                    roverController.SpinRight(rover);
                }
                else
                {
                    roverController.Move(rover.x, rover.y, rover);
                }

            }
            Console.WriteLine("Rover position is (" + rover.x + "," + rover.y + "," + rover.direction + " )");
        }
    }
}
