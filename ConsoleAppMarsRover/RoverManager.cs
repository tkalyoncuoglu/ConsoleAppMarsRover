using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMarsRover
{
    internal class RoverManager
    {
        public static Rover Move(Rover rover)
        {
            switch(rover.Direction)
            {
                case EnumDirections.E : return rover with { X = rover.X + 1 };

                case EnumDirections.W : return rover with { X = rover.X - 1 };

                case EnumDirections.N : return rover with { Y = rover.Y + 1 };

                case EnumDirections.S : return rover with { Y = rover.Y - 1 };
            }

            return null;
        }

        public static Rover Left(Rover rover)
        {
            return rover with { Direction = (EnumDirections)((((int)rover.Direction - 1) % 4 + 4) % 4) };
        }

        public static Rover Right(Rover rover)
        {
            return rover with { Direction = (EnumDirections)(((int)rover.Direction + 1) % 4) };
        }
    }
}
