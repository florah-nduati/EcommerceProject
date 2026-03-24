using ShoppingCart.Domain.BaseTypes;
using ShoppingCart.Domain.Errors;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Domain.ValueObjects
{
    public sealed class ProductName : ValueObject
    {
        public new string Value { get; }
        private ProductName(string value)
        {
            Value = value;
        }
        public static ProductName Create(string productName)
        {
            var errors = Validate(productName);
        }
        private static IList<Error> Validate(string productName)
        {
            return EmptyList<Error>()
                .if(productName.isNullOrWhiteSpace)
        }
    }

}
