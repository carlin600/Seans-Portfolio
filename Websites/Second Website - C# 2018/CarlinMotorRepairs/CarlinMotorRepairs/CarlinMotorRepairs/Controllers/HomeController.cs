using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarlinMotorRepairs.Controllers
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

        public ActionResult NewCars()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



        public ActionResult golf ()
        {
            ViewBag.Message = "Your New Cars.";

            return View();
        }

        public ActionResult arteon()
        {
            ViewBag.Message = "Your New Cars.";

            return View();
        }

        public ActionResult passat()
        {
            ViewBag.Message = "Your New Cars.";

            return View();
        }

        public ActionResult UP()
        {
            ViewBag.Message = "Your New Cars.";

            return View();
        }

        
    }
}