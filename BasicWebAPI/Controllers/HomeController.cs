
using Microsoft.AspNetCore.Mvc;

namespace BasicWebAPI.Controllers;

[ApiController]
[Route("/")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public string Index()
    {
        return "It works";
    }
}
