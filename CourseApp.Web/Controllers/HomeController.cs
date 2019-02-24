using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CourseApp.Web.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CourseApp.Web.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            var course = new Course();

            course.Id = 1;
            course.Name = "Sezer";

            return View(course);
        }
    }
}
