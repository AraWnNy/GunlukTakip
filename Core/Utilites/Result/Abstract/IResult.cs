using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilites.Result.Abstract
{
    public interface IResult
    {
        bool Success { get; set; }
        string Message { get; set; }
    }
}
