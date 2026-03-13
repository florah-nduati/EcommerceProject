using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Presentation.Abstraction
{

    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public abstract class ApiBaseController : ControllerBase

    {
        protected readonly ISender sender;
        {
            Sender = sender;
        }
   
    }
}
