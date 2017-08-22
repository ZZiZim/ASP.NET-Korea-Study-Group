﻿using Microsoft.AspNetCore.Mvc;

using DotNetNote20.Models;

namespace DotNetNote20.Controllers
{
    public class HelperMethodDemoController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 폼 생성
        /// </summary>
        public IActionResult FormDemo()
        {
            return View();
        }

        /// <summary>
        /// 입력 요소
        /// </summary>
        public IActionResult InputDemo()
        {
            return View();
        }

        /// <summary>
        /// 선택 요소
        /// </summary>
        public IActionResult SelectDemo()
        {
            return View();
        }

        /// <summary>
        /// 강력한 형식의 뷰: 특정 모델 클래스가 사용되는 뷰
        /// </summary>
        public IActionResult StronglyTypedDemo()
        {
            var stc = new StronglyTypedClass()
            {
                Id = 1,
                Name = "홍길동",
                Age = 21
            };

            return View(stc);
        }

        /// <summary>
        /// CSS Class 속성 주기
        /// </summary>
        public IActionResult CssClassDemo()
        {
            return View();
        }

        /// <summary>
        /// 부분 페이지
        /// </summary>
        public IActionResult PartialViewDemo()
        {
            return View();
        }
    }
}

/// <summary>
/// 강력한 형식의 뷰페이지 테스트용 모델 클래스
/// </summary>
public class StronglyTypedClass
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}