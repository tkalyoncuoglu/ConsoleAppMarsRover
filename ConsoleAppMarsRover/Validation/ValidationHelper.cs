using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppMarsRover
{
    static class ValidationHelper
    {
        public static DataResult<List<int>> ValidationDimension(string val)
        {
            DataResult<List<int>> dataResult;
            List<int> defDimension = null;
            try
            {
                defDimension = val.Trim().Split(' ').Select(int.Parse).ToList();
                if (defDimension.Count() == 2)
                    dataResult = new DataResult<List<int>>(defDimension, true);
                else
                    throw new Exception();

            }
            catch (Exception)
            {
                dataResult = new DataResult<List<int>>(defDimension, false, Resources.ValidationDimension);
            }
            return dataResult;
        }

        public static DataResult<StartPositions> ValidationStartPositions(string val)
        {
            DataResult<StartPositions> dataResult;
            StartPositions startPositions = StartPositions.Instance;

            try
            {
                var _startPositions = val.Trim().Split(' ');
                if (_startPositions.Count() == 3)
                {
                    startPositions.X = Convert.ToInt32(_startPositions[0]);
                    startPositions.Y = Convert.ToInt32(_startPositions[1]);
                    startPositions.Direction = (EnumDirections)Enum.Parse(typeof(EnumDirections), _startPositions[2].ToUpper());
                    dataResult = new DataResult<StartPositions>(startPositions, true);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                dataResult = new DataResult<StartPositions>(startPositions, false, Resources.ValidationStartPositions);
            }

            return dataResult;

        }

        public static DataResult<string> ValidationRoute(string val)
        {
            char[] routerChar = val.ToCharArray();
            if (routerChar.Where(P => P == 'M' || P == 'L' || P == 'R').Count() == routerChar.Count())
            {
                return new DataResult<string>(val.ToUpper(), true);
            }
            else
            {
                return new DataResult<string>(val.ToUpper(), false, Resources.ValidationRoute);
            }
        }
    }
}
