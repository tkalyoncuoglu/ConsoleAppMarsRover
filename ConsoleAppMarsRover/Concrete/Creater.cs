using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppMarsRover
{
    class Creater
    {
        IMachine _machine;
        StartPositions _startPositions;
        string _moves;
        List<int> _maxPoints;
        public Creater(IMachine machine, StartPositions startPositions, string moves, List<int> maxPoints)
        {
            _machine = machine;
            _startPositions = startPositions;
            _moves = moves;
            _maxPoints = maxPoints;
        }

        public DataResult<string> StartPosition()
        {
            foreach (var move in _moves)
            {
                switch (move)
                {
                    case 'M':
                        _machine.MoveInSameDirection(_startPositions);
                        break;
                    case 'L':
                        _machine.Rotate90Left(_startPositions);
                        break;
                    case 'R':
                        _machine.Rotate90Right(_startPositions);
                        break;
                }

                if (_startPositions.X < 0 || _startPositions.X > _maxPoints[0] || _startPositions.Y < 0 || _startPositions.Y > _maxPoints[1])
                {
                    return new DataResult<string>("", false, $"Position limit exceeding ({_startPositions.X} , {_startPositions.Y}) and ({_maxPoints[0]} , {_maxPoints[1]})");
                }
            }
            string data = _startPositions.X + " " + _startPositions.Y + " " + _startPositions.Direction; ;
            return new DataResult<string>(data, true);
        }


    }
}
