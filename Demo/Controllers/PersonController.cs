using System.Reflection.PortableExecutable;
using System;
using Microsoft.AspNetCore.Mvc;

namespace Demo.PersonController
{
    public class PersonController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string Name)
        {
            ViewBag.thongbao= "Xin chào "+Name;
            return View();
        }
    }
}