using rover_project.Model;
using System;

namespace rover_project
{
    public class Rover
    {
        public int x { get; set; }
       
        public int y { get; set; }

        public Direction direction { get; set; }

        public string commands { get; set; }
    }
}
