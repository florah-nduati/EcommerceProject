using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Application.Abstractions.CQRS
{
    public interface IQuery<out TResponse> : IRequest<IResult<TResponse>> where TResponse : IResponse
    {
    }
}
