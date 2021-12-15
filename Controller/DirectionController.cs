using rover_project.Model;

namespace rover_project.Controller
{
    public class DirectionController
    {
        public Direction GetDirection(string value)
        {
            switch (value)
            {
                case "N":
                    return Direction.N;
                case "S":
                    return Direction.S;
                case "E":
                    return Direction.E;
                case "V":
                    return Direction.V;

                default:
                    return Direction.N;
            }
        }
    }
}
