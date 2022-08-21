using U19056509_HW4.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace U19056509_HW4.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Bursary
        public ActionResult Index()
        {
            List<TeacherViewModel> Teacher = GetTestData();
            return View(Teacher);
        }
        private List<TeacherViewModel> GetTestData()
        {
            List<TeacherViewModel> Teacher = new List<TeacherViewModel>();
            TeacherViewModel teacher1 = new TeacherViewModel(56, "james", "USA", 12);
            TeacherViewModel teacher2 = new TeacherViewModel(23, "jimmy", "Engand", 3);
            TeacherViewModel teacher3 = new TeacherViewModel(54, "bob", "France", 27);
            TeacherViewModel teacher4 = new TeacherViewModel(42, "rob", "AUZ", 20);
            TeacherViewModel teacher5 = new TeacherViewModel(31, "toby", "Figi", 3);

            Teacher.Add(teacher1);
            Teacher.Add(teacher2);
            Teacher.Add(teacher3);
            Teacher.Add(teacher4);
            Teacher.Add(teacher5);


            return Teacher;
        }
    }
}