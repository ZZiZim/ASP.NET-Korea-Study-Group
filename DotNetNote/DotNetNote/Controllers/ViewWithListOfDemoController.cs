using DotNetNote.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetNote.Controllers
{
    public class ViewWithListOfDemoController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<DemoModel> models = new List<DemoModel>()
            {
                new DemoModel { Id = 1, Name = "홍길동"},
                new DemoModel { Id = 2, Name = "백두산"},
                new DemoModel { Id = 3, Name = "임꺽정"}
            };

            return View(models);
        }
    }
}
