using ShoppingCart.Domain.Abstractions;
using ShoppingCart.Domain.Errors;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Net.NetworkInformation;
using System.Text;

namespace ShoppingCart.Domain.Results
{
    public class Result<TValue> : Result, IResult<TValue>
    {
        private readonly TValue? _value;
        public TValue Value => IsSuccess ? _value! :
            throw new InvalidOperationException($"The value of failure result cannot be accessed" +
                $"Type '{typeof(TValue).FullName}'");
        protected internal Result(TValue? value, Error error):base(error)
        {
            _value = value;
        }
        public static implicit operator Result<TValue>(TValue? value)
        {
            return Create(value);
        }


        
    }
    public class Result : IResult
    {
        private static readonly Result _success = new (Error.noneError);
            private protected Result(Error error)
        {
            Error = error;
        }
        public bool IsSuccess => Error == Error.noneError;

        public bool IsFailure => !IsSuccess;

        public Error Error{get; }
        public static Result Create(bool condition)
        {
            return condition? Success() : Failure(Error.ConditionNotSatisfied);
        }
        public static Result Success()
        {
            return _success;
        }
        public static Result Failure(Error error)
        {
            return new(error);
        }
        public static Result<TValue> Create<TValue>(TValue? value)
        {
            if(value is null)
            {
                return Failure<TValue>(Error.NullValue);
            }
            if(value is Error)
            {
                throw new InvalidOperationException("Provided value is an error");
            }
            return Success(value);
        }
        public static Result<TValue> Failure<TValue>(Error error)
        {
            return new Result<TValue>(default, error);
        }
        public static Result<TValue> Success<TValue>(TValue value)
        {
            return Success(value); 
        }
    }
}
