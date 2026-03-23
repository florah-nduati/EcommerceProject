using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Domain.BaseTypes
{
    public abstract class AggregateRoot<T> where T : struct
    {
        protected AggregateRoot(T id) : base(id)
        {

        }
    }
}
