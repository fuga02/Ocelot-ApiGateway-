using Microsoft.AspNetCore.Mvc;

namespace WebApi1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{

    [HttpGet("GetUser")]
    public string GetUser()
    {
        return "Hello fuga02";
    }
}