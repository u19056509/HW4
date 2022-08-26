using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using U19056509_HW4.ViewModels;
using System.Data.SqlClient;

namespace U19056509_HW4.Controllers
{
    public class HomeController : Controller
    {
        private SqlConnection myConnection = new SqlConnection(Globals.ConnectionString);
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Application()
        {
            return View();
        }
        public ActionResult Donate()
        {
            return View();
        }
        public ActionResult Teach()
        {
            return View();
        }
        public ActionResult Update()
        {
            return View();
        }

        public ActionResult DoInsert(int age, string name, string country, string type)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand("insert into Name VALUES ('"+age+","+ name + ","+country+","+ type + "')",myConnection);
                myConnection.Open();
                ViewBag.Message = "Success: your aplication is in for review";

            }
            catch (Exception err)
            {

                ViewBag.Message = err.Message;
            }
            finally
            {
                myConnection.Close();
            }
            return View("Index");
        }

    }


}