using U19056509_HW4.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace U19056509_HW4.Controllers
{
    public class BursaryController : Controller
    {
        // GET: Bursary
        public ActionResult Index()
        {
            List<ApplyViewModel> Aply = GetTestData();
            return View(Aply);
        }
        private List<ApplyViewModel> GetTestData()
        {
            List<ApplyViewModel> Aply = new List<ApplyViewModel>();
            ApplyViewModel application1 = new ApplyViewModel(12, "Jhon", "malowi", "Primary");
            ApplyViewModel application2 = new ApplyViewModel(22, "James", "DRC", "Tertiary");
            ApplyViewModel application3 = new ApplyViewModel(32, "Jimmy", "South Africa", "Secondary");
            ApplyViewModel application4 = new ApplyViewModel(19, "Judo", "Zimbabe", "Primary");
            ApplyViewModel application5 = new ApplyViewModel(16, "Jeremy", "Mozambique", "Tertiary");

            Aply.Add(application1);
            Aply.Add(application2);
            Aply.Add(application3);
            Aply.Add(application4);
            Aply.Add(application5);


            return Aply;
        }
    }
}