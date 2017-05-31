using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    [Route("home/")]
    public IActionResult Index()
    {
        return Ok("Welcome to my D & D web application... under progress");
    }
}