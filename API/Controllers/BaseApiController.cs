using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {   // Using _ for private property as a naming convention
        private IMediator? _mediator;
        // Protected means this will be available for the class we declare in and classes that 
        // derive from this class
        protected IMediator Mediator 
            => _mediator ??= HttpContext.RequestServices.GetService<IMediator>()
                ?? throw new InvalidOperationException("IMediator service is unavailable");
    }


}