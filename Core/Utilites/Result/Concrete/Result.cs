using Core.Utilites.Result.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilites.Result.Concrete
{
    public class Result : IResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public Result(bool success, string message):this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }
    }
}
