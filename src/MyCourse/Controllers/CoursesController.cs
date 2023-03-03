using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            //return View();
            return Content("Sono Index");
        }

        public IActionResult Detail(string id)
        {
            return Content($"Sono Detail, ho ricevuto l'id {id}");
        }
    }
}
