using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using U19056509_HW4.ViewModels;

namespace U19056509_HW4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Person> people = new List<Person>();

            ApplyViewModel application1 = new ApplyViewModel(12, "Jhon", "malowi", "Primary");
            ApplyViewModel application2 = new ApplyViewModel(22, "James", "DRC", "Tertiary");
            ApplyViewModel application3 = new ApplyViewModel(32, "Jimmy", "South Africa", "Secondary");
            ApplyViewModel application4 = new ApplyViewModel(19, "Judo", "Zimbabe", "Primary");
            ApplyViewModel application5 = new ApplyViewModel(16, "Jeremy", "Mozambique", "Tertiary");

            people.Add(application1);
            people.Add(application2);
            people.Add(application3);
            people.Add(application4);
            people.Add(application5);

            DonateViewModel donation1 = new DonateViewModel(52, "bob", "south afirca", 100);
            DonateViewModel donation2 = new DonateViewModel(30, "bil", "DRC", 20000);
            DonateViewModel donation3 = new DonateViewModel(25, "billy", "south korea", 30000);
            DonateViewModel donation4 = new DonateViewModel(45, "simon ", "west afirca", 45000);
            DonateViewModel donation5 = new DonateViewModel(38, "silly", "uganda", 900);

            people.Add(donation1);
            people.Add(donation2);
            people.Add(donation3);
            people.Add(donation4);
            people.Add(donation5);
            TeacherViewModel teacher1 = new TeacherViewModel(56, "james", "USA", 12);
            TeacherViewModel teacher2 = new TeacherViewModel(23, "jimmy", "Engand", 3);
            TeacherViewModel teacher3 = new TeacherViewModel(54, "bob", "France", 27);
            TeacherViewModel teacher4 = new TeacherViewModel(42, "rob", "AUZ", 20);
            TeacherViewModel teacher5 = new TeacherViewModel(31, "toby", "Figi", 3);

            people.Add(teacher1);
            people.Add(teacher2);
            people.Add(teacher3);
            people.Add(teacher4);
            people.Add(teacher5);
            return View(people);
        }
    }


}