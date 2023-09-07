using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class CodestreamController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Hello, Codestreamers!";
    }
}
