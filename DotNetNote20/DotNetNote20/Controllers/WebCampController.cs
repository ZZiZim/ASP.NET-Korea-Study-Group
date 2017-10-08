using Microsoft.AspNetCore.Mvc;

namespace DotNetNote20.Controllers
{
    public class WebCampController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}