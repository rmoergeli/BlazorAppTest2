using BlazorAppTest2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppTest2.Controllers
{
    public class StudentsController : Controller
    {
        [ActionName("Index")]
        public IActionResult Index()
        {
            return View(GetStudents());
        }

        private List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student
            {
                Name = "Smith",
                Surname = "John"
            });

            return students;
        }
    }
}
