using ShoppingCart.Domain.Errors;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Domain.Abstractions
{
    public interface IResult<out TValue> : IResult
    {
        TValue Value { get; }
    }
    public interface IResult
    {
        bool IsSuccess { get; }
        bool IsFailure { get; }
        Error Error {  get; }
    }
}
