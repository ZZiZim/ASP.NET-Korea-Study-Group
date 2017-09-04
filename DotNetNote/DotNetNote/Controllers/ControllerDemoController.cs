using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetNote20.Controllers
{
    public class ControllerDemoController : Controller
    {
        // 액션: 메서드
        // /ControllerDemo/Index
        public void Index()
        {
            // 아무런 값도 출력하지 않음
        }

        public string StringAction()
        {
            return "String을 반환하는 액션 메서드";
        }

        public DateTime DateTimeAction()
        {
            return DateTime.Now;
        }

        public IActionResult DefaultAction()
        {
            return View(); //컨트롤러/액션 메서드
        }
    }
}
