using Microsoft.AspNetCore.Mvc;

namespace TravelApi.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
    
}