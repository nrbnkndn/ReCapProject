using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message):this (success)
        {
            Message = message;
            //Success = success; buraya gerek yok. tekrar etmesine. aşağıdakini çağırırız this ile.
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; } //getter read onlydir ancak constructorda set edilebilir.
        //kafasına göre kod değişmesin diye bu yapıyı standart hale geitiriyoruz.

        public string Message { get; }
    }
}
