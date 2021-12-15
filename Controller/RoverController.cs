using rover_project.Model;

namespace rover_project.Controller
{
   public class RoverController
    {
        public void SpinLeft(Rover rover)
        {
            switch (rover.direction)
            {
                case Direction.N:
                    rover.direction = Direction.V;
                    break;
                case Direction.S:
                    rover.direction = Direction.E;
                    break;
                case Direction.E:
                    rover.direction = Direction.N;
                    break;
                case Direction.V:
                    rover.direction = Direction.S;
                    break;
            }
        }

        public void SpinRight(Rover rover)
        {
            switch (rover.direction)
            {
                case Direction.N:
                    rover.direction = Direction.E;
                    break;
                case Direction.S:
                    rover.direction = Direction.V;
                    break;
                case Direction.E:
                    rover.direction = Direction.S;
                    break;
                case Direction.V:
                    rover.direction = Direction.N;
                    break;
            }
        }

        public void Move(int x, int y, Rover rover)
        {
            switch (rover.direction)
            {
                case Direction.N:
                    rover.y = y + 1;
                    break;

                case Direction.S:
                    rover.y = y - 1;
                    break;

                case Direction.E:
                    rover.x = x + 1;
                    break;

                case Direction.V:
                    rover.x = x - 1;

                    break;
            }
        }

    }
}
