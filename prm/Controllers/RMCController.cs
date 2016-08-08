using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prm.Controllers
{
    public class RMCController : Controller
    {
        //
        // GET: /RMC/

        public ActionResult ViewRMC()
        {
            ViewBag.RMC = "active";
            ViewBag.ViewRMC = "active";
            return View();
        }
        public ActionResult ViewProfile()
        {
            ViewBag.RMC = "active";
            ViewBag.RMC_ViewProfile = "active";
            return View();
        }
    }
}
