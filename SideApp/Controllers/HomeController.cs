using Microsoft.AspNetCore.Mvc;

namespace TechApp.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    [HttpGet("list")]
    public object List()
    {
        return new List<string>()
        {
            "Side Menu 1",
            "Side Menu 2",
            "Side Menu 3",
            "Side Menu 4",
        };
    }
}