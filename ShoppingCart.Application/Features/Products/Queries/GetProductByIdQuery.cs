using ShoppingCart.Application.Abstractions.CQRS;
using ShoppingCart.Domain.EntityIds;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Application.Features.Products.Queries
{
    public sealed record GetProductByIdQuery(ProductId Id) : IQuery<ProductResponse>;

}
