using ShoppingCart.Domain.Errors;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Application.Abstractions
{
    public interface IResult<out T>: IResult
    {
        T Result { get; }
    }
    public interface IResult
    {
        bool IsSuccess { get; }
        bool IsFailure { get; }
        Error Error { get; }
    }
}
