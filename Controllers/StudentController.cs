using baiTapTuan2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace baiTapTuan2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        [HttpGet]
        public ActionResult Index()
        {
            Student std = new Student()
            {
                StudentId = 1,
                StudentName = "Bach Sy Khang",
                StudentGender = true,
                Address = "daknong",
                Age = 19,
                cacTinh = tinhThanh.Hồ_Chí_Minh
            };
            return View(std);
        }
        [HttpPost]
        public ActionResult Index(Student a)
        {
            return View(a);
        }
    }
}