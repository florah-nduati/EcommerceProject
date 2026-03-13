using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Presentation.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Presentation.Controllers
{
    public sealed class UserController : ApiBaseController
    {
        public UserController(ISender sender) : base(sender)
        {
            
        }
        [HttpPost("[action]")]
        [ProducesResponseType(StatusCodes.Status200OK, Type=typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type =typeof(ProblemDetails))]
        public async Task<IActionResult> Login()
        {
            return Ok();
        }

        [HttpPost("[action]")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ProblemDetails))]
        public async Task<IActionResult> Register()
        {
            return Ok();
        }


        [HttpGet("{username}")]
        //[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ProblemDetails))]
        public async Task<IActionResult> GetUserByUserName([FromRoute] string username, CancellationToken cancellationToken)
        {
            return Ok();
        }



    }
}
