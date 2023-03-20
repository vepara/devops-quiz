using Microsoft.AspNetCore.Mvc;

namespace TechApp.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    [HttpGet("Menu")]
    public object List()
    {
        return new List<string>()
        {
            "Tech menu A",
            "Tech menu B"
        };
    }
}