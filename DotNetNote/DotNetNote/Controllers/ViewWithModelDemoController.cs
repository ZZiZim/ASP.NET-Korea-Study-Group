using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetNote.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetNote.Controllers
{
    public class ViewWithModelDemoController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            DemoModel dm = new DemoModel();
            dm.Id = 1;
            dm.Name = "홍길동";
            return View(dm);
        }
    }
}
