using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Freelance.Application.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ErrorsController : ControllerBase
{
    [HttpGet]
    [Route("/error")]
    public IActionResult Error()
    {
        return Problem();
    }
}
