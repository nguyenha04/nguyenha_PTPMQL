using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class StudentController : Controller
    {

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Student());
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            ViewBag.Message = "Thêm sinh viên thành công!";
            ViewBag.FullName = student.FullName;
            ViewData["Address"] = student.Address;
            ViewData["University"] = student.University;

            return View(student);
        }
    }
}