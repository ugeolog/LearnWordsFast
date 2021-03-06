using System;
using System.Collections.Generic;
using LearnWordsFast.Infrastructure;
using LearnWordsFast.ViewModels;
using Microsoft.AspNet.Mvc;

namespace LearnWordsFast.ApiControllers
{
    public class ApiController : Controller
    {
        protected Guid UserId => User.GetId();

        protected IActionResult Ok()
        {
            return new ContentResult();
        }

        protected IActionResult Ok(object value)
        {
            return new ObjectResult(value);
        }

        protected IActionResult Created(string location)
        {
            return new CreatedResult(location, null);
        }

        protected IActionResult Error()
        {
            return new BadRequestResult();
        }

        protected IActionResult Error(IEnumerable<string> errorMessages)
        {
            return new BadRequestObjectResult(new ErrorViewModel(errorMessages));
        }

        protected IActionResult Error(string error)
        {
            return new BadRequestObjectResult(new ErrorViewModel(new List<string>
            {
                error
            }));
        }

        protected IActionResult Unauthorized()
        {
            return new HttpUnauthorizedResult();
        }

        protected IActionResult NotFound()
        {
            return new HttpNotFoundResult();
        }

        protected IActionResult NotFound(object value)
        {
            return new HttpNotFoundObjectResult(value);
        }
    }
}