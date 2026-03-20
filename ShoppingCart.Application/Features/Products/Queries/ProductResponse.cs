using ShoppingCart.Application.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Application.Features.Products.Queries
{
    public sealed record ProductResponse
     (
         Guid Id,
             string ProductName, string Review,
             decimal Price
     ) : IResponse;
}
