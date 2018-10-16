using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
/*
using System.Data.Client;
using System.Data;
using System.Configuration;

    SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString)
     */

namespace Sales.Backend.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}