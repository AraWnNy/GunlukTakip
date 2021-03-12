using Core.Utilites.Result.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilites.Result.Concrete
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public T Data { get; set; }
        public DataResult(bool success, T data, string message) : base(success, message)
        {
            Data = data;
        }
        public DataResult(bool success, T data):base(success)
        {
            Data = data;
        }
    }
}
