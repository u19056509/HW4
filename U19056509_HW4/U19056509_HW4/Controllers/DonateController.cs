using U19056509_HW4.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace U19056509_HW4.Controllers
{
    public class DonateController : Controller
    {
        // GET: Donation
        public ActionResult Index()
        {
            List<DonateViewModel> donate = GetTestData();
            return View(donate);
        }
        private List<DonateViewModel> GetTestData()
        {
            List<DonateViewModel> donate = new List<DonateViewModel>();
            DonateViewModel donation1 = new DonateViewModel(52, "bob", "south afirca", 100);
            DonateViewModel donation2 = new DonateViewModel(30, "bil", "DRC", 20000);
            DonateViewModel donation3 = new DonateViewModel(25, "billy", "south korea", 30000);
            DonateViewModel donation4 = new DonateViewModel(45, "simon ", "west afirca", 45000);
            DonateViewModel donation5 = new DonateViewModel(38, "silly", "uganda", 900);

            donate.Add(donation1);
            donate.Add(donation2);
            donate.Add(donation3);
            donate.Add(donation4);
            donate.Add(donation5);

            return donate;


        }
    }
}