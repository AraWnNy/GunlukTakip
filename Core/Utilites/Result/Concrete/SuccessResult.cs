using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilites.Result.Abstract;

namespace Core.Utilites.Result.Concrete
{
    public class SuccessResult : Result
    {
        public SuccessResult():base(true)
        {

        }

        public SuccessResult(string message):base(true, message)
        {

        }
    }
}
