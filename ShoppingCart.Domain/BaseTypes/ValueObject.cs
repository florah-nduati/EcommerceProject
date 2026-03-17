using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Domain.BaseTypes
{
    public abstract class ValueObject : IEquatable<ValueObject>
    {
        public bool Equals(ValueObject? other)
        {
            throw new NotImplementedException();
        }
    }
}
