using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Application.Features.Users.Commands
{
    public sealed record RegisterUserCommand
  (
        string Username,
            string Email,
            string Password,
            string ConfirmPassword
  );
}
