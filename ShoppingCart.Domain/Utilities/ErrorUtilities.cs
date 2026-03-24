using ShoppingCart.Domain.Errors;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ShoppingCart.Domain.Utilities
{
    public static class ErrorUtilities
    {
        public static IList<Error> If(this IList<Error> errors,
            bool condition, Error error)
        {
            if (condition is true)
            {
                errors.Add(error);
            }
            return errors;
        }
    }
}
