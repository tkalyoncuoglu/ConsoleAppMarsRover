using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppMarsRover
{
   public interface IResult
    {
        bool Success { get;  }
        string Message { get; }
    }
}
