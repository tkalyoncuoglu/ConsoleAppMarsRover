using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppMarsRover
{
    public class RoverPosition : IMachine
    {
        public void MoveInSameDirection(StartPositions positions)
        {
            
            switch (positions.Direction)
            {
                case EnumDirections.N:
                    positions.Y += 1;
                    break;
                case EnumDirections.S:
                    positions.Y -= 1;
                    break;
                case EnumDirections.E:
                    positions.X += 1;
                    break;
                case EnumDirections.W:
                    positions.X -= 1;
                    break;
                default:
                    break;
            }
        }

        public void Rotate90Left(StartPositions positions)
        {
            switch (positions.Direction)
            {
                case EnumDirections.N:
                    positions.Direction = EnumDirections.W;
                    break;
                case EnumDirections.E:
                    positions.Direction = EnumDirections.N;
                    break;
                case EnumDirections.S:
                    positions.Direction = EnumDirections.E;
                    break;

                case EnumDirections.W:
                    positions.Direction = EnumDirections.S;
                    break;
                default:
                    break;
            }
        }

        public void Rotate90Right(StartPositions positions)
        {
            switch (positions.Direction)
            {
                case EnumDirections.N:
                    positions.Direction = EnumDirections.E;
                    break;
                case EnumDirections.E:
                    positions.Direction = EnumDirections.S;
                    break;
                case EnumDirections.S:
                    positions.Direction = EnumDirections.W;
                    break;

                case EnumDirections.W:
                    positions.Direction = EnumDirections.N;
                    break;
                default:
                    break;
            }
        }

    }
}
