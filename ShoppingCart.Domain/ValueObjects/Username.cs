using ShoppingCart.Domain.BaseTypes;
using ShoppingCart.Domain.Errors;
using ShoppingCart.Domain.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Domain.ValueObjects
{
    public sealed class Username : ValueObject
    {
        public const int maxLength = 50;
        public new string Value { get; }
        private Username(string value)
        {
            Value = value;

        }
        public static Username Create(string username)
        {
            return new Username(username);
        }
        public static IList<Error>Validate(string username)
        {
            return Listutilities.EmptyList<Error>();
        }
    }
}
