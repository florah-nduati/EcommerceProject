using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Application.Features.Products.Queries;
using ShoppingCart.Domain.EntityIds;
using ShoppingCart.Presentation.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Presentation.Controllers
{
    public sealed class ProductsController : ApiBaseController
    {
        public ProductsController(ISender sender) : base(sender)
        {

        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type=typeof(ProductResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ProblemDetails))]
        public async Task<IActionResult> GetProductById([FromRoute] ProductId id, CancellationToken cancellationToken)
            {
            var query = new GetProductByIdQuery(id);
            var Response = await Sender.Send(query, cancellationToken);
            if(Response.IsFailure)
            {
               
            }
            return Ok(Response);
        }

    }
}
