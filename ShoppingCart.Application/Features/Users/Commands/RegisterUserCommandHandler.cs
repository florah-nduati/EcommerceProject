using ShoppingCart.Application.Abstractions;
using ShoppingCart.Application.Abstractions.CQRS;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Application.Features.Users.Commands
{
    public sealed class RegisterUserCommandHandler : ICommandHandler<RegisterUserCommand, RegisterUserResponse>
    {

        public Task<IResult<RegisterUserResponse>> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
