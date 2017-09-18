using Microsoft.AspNetCore.Mvc;

namespace DotNetNote20.Controllers
{
    public class ViewComponentDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// CopyrightViewComponent 출력 데모
        /// </summary>
        /// <returns></returns>
        public IActionResult CopyrightDemo()
        {
            return View();
        }

        /// <summary>
        /// TechListViewComponent 사용 데모
        /// </summary>
        /// <returns></returns>
        public IActionResult TechListDemo()
        {
            return View();
        }

        /// <summary>
        /// SiteListViewComponent 사용 데모
        /// </summary>
        public IActionResult SiteListDemo()
        {
            return View();
        }
    }
}