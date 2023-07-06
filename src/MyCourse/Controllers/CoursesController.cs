using Microsoft.AspNetCore.Mvc;
using MyCourse.Models.Services.Application;
using MyCourse.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourseService courseService;

        public CoursesController(ICourseService courseService)
        {
            this.courseService = courseService;
        }

        public IActionResult Index()
        {
            ViewData["Title"] =  "Catalogo dei corsi";
            var courseService = new CourseService();
            List<CourseViewModel> courses = courseService.GetCourses();

            return View(courses);
        }

        public IActionResult Detail(int id)
        {
            var courseService = new CourseService();
            CourseDetailViewModel viewModel = courseService.GetCourse(id);
            ViewData["Title"] =  viewModel.Title;
            return View(viewModel);
        }
    }
}
