﻿using Core.Utilities.Result.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Result.Concrete
{
    public class Result : IResult
    {
        public bool Success { get; }

        public string Message { get; }

        public Result(bool success)
        {
            this.Success = success;
        }
        public Result(bool success, string message):this(success) { 
            this.Message= message;
        }
    }
}