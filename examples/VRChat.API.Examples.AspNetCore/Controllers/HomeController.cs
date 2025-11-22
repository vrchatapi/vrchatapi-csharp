using Microsoft.AspNetCore.Mvc;

namespace VRChat.API.Examples.AspNetCore.Controllers;

public class HomeController : Controller
{
    [Route("/")]
    public IActionResult Index()
    {
        return Ok(new { status = "healthy" });
    }
}
