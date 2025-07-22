using Microsoft.AspNetCore.Mvc;

namespace HelpTechWebApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index() => View();

        [HttpGet]
        public IActionResult Error() => View();
    }
}