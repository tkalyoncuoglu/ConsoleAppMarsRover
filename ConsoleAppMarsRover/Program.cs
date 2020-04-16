using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppMarsRover
{
    class Program
    {
        /// <summary>
        /// //
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region IoC
            var serviceProvider = new ServiceCollection()
          .AddSingleton<IMachine, RoverPosition>()
          .BuildServiceProvider();
            #endregion

            #region def
            DataResult<List<int>> dataResultDimension = ReadLineDimension();
            DataResult<StartPositions> dataResultPosition = ReadLinePosition();
            DataResult<string> dataResultRoute = ReadLineRoute();
            #endregion

            Creater creater = new Creater(serviceProvider.GetService<IMachine>(), dataResultPosition.Data, dataResultRoute.Data, dataResultDimension.Data);
            DataResult<string> dataResultStartPosition = creater.StartPosition();
            if (dataResultStartPosition.Success)
            {
                Console.WriteLine(dataResultStartPosition.Data);
            }
            else
            {
                Console.WriteLine(dataResultStartPosition.Message);
            }
            Console.ReadKey();
        }

        #region private
        private static DataResult<string> ReadLineRoute()
        {
            Console.Write(Resources.EnterRoute);
            DataResult<string> dataResultPosition = ValidationHelper.ValidationRoute(Console.ReadLine());
            if (!dataResultPosition.Success)
            {
                Console.WriteLine(dataResultPosition.Message);
                dataResultPosition = ReadLineRoute();
            }
            return dataResultPosition;
        }

        private static DataResult<StartPositions> ReadLinePosition()
        {
            Console.Write(Resources.EnterPosition);
            DataResult<StartPositions> dataResultPosition = ValidationHelper.ValidationStartPositions(Console.ReadLine());
            if (!dataResultPosition.Success)
            {
                Console.WriteLine(dataResultPosition.Message);
                dataResultPosition = ReadLinePosition();
            }

            return dataResultPosition;
        }

        private static DataResult<List<int>> ReadLineDimension()
        {
            Console.Write(Resources.EnterDimension);
            DataResult<List<int>> dataResultDimension = ValidationHelper.ValidationDimension(Console.ReadLine());
            if (!dataResultDimension.Success)
            {
                Console.WriteLine(dataResultDimension.Message);
                dataResultDimension = ReadLineDimension();
            }
            return dataResultDimension;
        }
        #endregion


    }
}
