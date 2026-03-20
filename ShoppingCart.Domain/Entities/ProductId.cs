using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Domain.Entities
{
    public readonly record struct  ProductId 
    {
        private ProductId(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; }
        public static ProductId New()
        {
            return new ProductId(Guid.NewGuid());
        }
        public static ProductId Create(Guid id)
        {
            return new ProductId(id);
        }
    }
}
