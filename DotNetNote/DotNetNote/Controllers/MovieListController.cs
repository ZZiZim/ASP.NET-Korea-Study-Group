using DotNetNote.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetNote.Controllers
{
    public class MovieListController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<MovieViewModel> vms = new List<MovieViewModel>()
            {
                new MovieViewModel {Id = 1, Title = "명랑", CreateionDate = new DateTime(2014, 1, 1) },
                new MovieViewModel {Id = 2, Title = "실미도", CreateionDate = new DateTime(2013, 1, 1) },
                new MovieViewModel {Id = 3, Title = "베테랑", CreateionDate = new DateTime(2015, 1, 1) }
            };

            return View(vms);
        }
    }
}
