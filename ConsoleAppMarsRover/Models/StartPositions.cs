using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppMarsRover
{
    public class StartPositions
    {

        private static StartPositions instance = new StartPositions();
        private StartPositions() { }


        public static StartPositions Instance
        {

            get { return instance; }
        }

        public int X { get; set; }
        public int Y { get; set; }
        public EnumDirections Direction { get; set; }
    }
}
