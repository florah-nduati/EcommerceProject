using ShoppingCart.Application.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Application.Features.Users.Commands
{
    public sealed record RegisterUserResponse
   (Guid id) : IResponse;
}
