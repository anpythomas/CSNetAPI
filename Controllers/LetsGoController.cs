using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]

public class LetsGoController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Let's go! Let's build an API!";
    }
}
