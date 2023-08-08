using Practical10A_NEW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical10A_NEW.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            Student std = new Student()
            {
                Id = 1,
                Name = "Rushikesh",
                Email = "rushi@gmail.com"
            };
            return View(std);
        }
        [HttpPost]
        public ActionResult Index(Student std)
        {
            return View("DisplayData", std);
        }
    }
}