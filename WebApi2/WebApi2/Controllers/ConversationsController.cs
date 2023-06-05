using Microsoft.AspNetCore.Mvc;

namespace WebApi2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ConversationsController : ControllerBase
{
    [HttpGet("word")]
    public string Word()
    {
        return "Hello world";
    }
    [HttpPost("PostWord")]
    public string PostWord(string word)
    {
        return word;
    }

}