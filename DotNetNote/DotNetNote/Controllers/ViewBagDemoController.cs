using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetNote.Controllers
{
    public class ViewBagDemoController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Name = "박용준";
            ViewBag.Age = 21;
            ViewBag.원하는모든단어 = "모든값...";

            ViewData["Address"] = "세종시...";
            return View();
        }
    }
}
