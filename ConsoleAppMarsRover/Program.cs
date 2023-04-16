using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppMarsRover
{
    class Program
    {
     
        static void Main(string[] args)
        {
            var dimensionsRead = Console.ReadLine();
            
            var dimension = dimensionsRead.Trim().Split(' ').Select(int.Parse).ToList();

            var positionAndHeadingRead = Console.ReadLine();

            var positionAndHeading = positionAndHeadingRead.Trim().Split(' ');

            var rover = new Rover(){X = Convert.ToInt32(positionAndHeading[0]),
                                    Y = Convert.ToInt32(positionAndHeading[1]),
                                    Direction = (EnumDirections)Enum.
                                    Parse(typeof(EnumDirections), positionAndHeading[2].ToUpper())
            };

            var routeRead = Console.ReadLine();

            var route = routeRead.ToCharArray();

            var dict = new Dictionary<char, Func<Rover, Rover>>
            {
                { 'L', RoverManager.Left }, {'R', RoverManager.Right}, {'M', RoverManager.Move}
            };

            route.ToList().ForEach(x => rover = dict[x](rover));

            Console.WriteLine(rover.X.ToString() + " " + rover.Y.ToString() + " " + rover.Direction.ToString());

        }




    }
}
