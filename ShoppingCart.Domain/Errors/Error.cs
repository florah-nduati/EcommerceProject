using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Domain.Errors
{
    public class Error : IEquatable<Error>
    {
        public static readonly Error noneError = new(string.Empty,string.Empty);
        public static readonly Error NullValue =new ($"{nameof(Error)}.{nameof(NullValue)}", "the result value is null");
        public static readonly Error ConditionNotSatisfied = new($"{nameof(Error)}.{nameof(ConditionNotSatisfied)}", "The specified condition not satisfied");
        public static readonly Error ValidationError = new($"{nameof(Error)}.{nameof(ValidationError)}", "Validation Error");
        public string Code { get; }
        public string Message { get; }
        public Error(string code, string message)
        {
            Code = code;
            Message = message;
        }
        public static Error New(string code, string message)
        {
                       return new Error(code, message);
        }
        public bool Equals(Error? other)
        {
            throw new NotImplementedException();
        }
    }
}
