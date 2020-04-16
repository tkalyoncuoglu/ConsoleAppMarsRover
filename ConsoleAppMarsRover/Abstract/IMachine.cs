using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppMarsRover
{
    interface IMachine
    {
        void Rotate90Left(StartPositions positions);
        void Rotate90Right(StartPositions positions);
        void MoveInSameDirection(StartPositions positions);

    }
}
