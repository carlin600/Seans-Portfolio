using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarlinMotorRepairs.Controllers
{
    public class ManagePartialMenuController : Controller
    {
        // GET: ManagePartialMenu
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated == true)
            {
                return PartialView("_MenuDetailed");
            }
            else
            {
                return PartialView("_MenuBasic");
            }

        }

    }
}