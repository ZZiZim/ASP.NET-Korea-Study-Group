using Microsoft.AspNetCore.Mvc;

namespace DotNetNote20.Controllers
{
    public class TechController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}