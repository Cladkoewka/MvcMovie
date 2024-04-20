﻿using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }
        // 
        // GET: /HelloWorld/Welcome/ 
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

        public IActionResult Test(string name, int num = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["num"] = num;
            return View();
        }

    }
}
