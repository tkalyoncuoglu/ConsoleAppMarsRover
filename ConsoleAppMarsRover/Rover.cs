using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppMarsRover
{
    internal record Rover
    {
        public required int X { get; init; }

        public required int Y { get; init; }

        public required EnumDirections Direction { get; init; }
    }
}
