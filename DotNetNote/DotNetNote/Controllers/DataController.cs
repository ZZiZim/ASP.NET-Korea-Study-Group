using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetNote20.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetNote20.Controllers
{
    public class DataController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            // 모든 데이터를 읽어서 View 페이지에 전달
            DataService demoService = new DataService();
            var data = demoService.GetAll();
            return View(data);
        }
    }
}
