using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppMarsRover
{
    public interface IDataResult<out T> : IResult
    {
        T Data { get; }
    }
}
