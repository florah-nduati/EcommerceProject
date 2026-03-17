using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Domain.EntityIds
{
    public readonly record struct UserId 
    {
        public Guid Value { get; }
        private UserId(Guid id)
        {
            Value = id;
        }
        public static UserId Create(Guid id)
        {
            return new UserId(id);
        }
    }
}
