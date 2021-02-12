using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Razor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Count()
        {
            ViewData["bottles"] = Request.Form["bottles"];
            return View();
        }

        [HttpGet]
        public IActionResult CreatePerson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DisplayPerson()
        {
            ViewData["firstname"] = Request.Form["firstname"];
            ViewData["lastname"] = Request.Form["lastname"];
            ViewData["age"] = Request.Form["age"];
            ViewData["emailAddress"] = Request.Form["emailAddress"];
            ViewData["dateofbirth"] = Request.Form["dateofbirth"];
            ViewData["password"] = Request.Form["password"];
            ViewData["description"] = Request.Form["description"];

            return View();
        }

        [HttpGet]
        public IActionResult Error()
        {
            return View();
        }
    }
}
