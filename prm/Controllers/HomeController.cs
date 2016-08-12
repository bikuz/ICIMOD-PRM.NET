using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prm.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Home = "active";
            return View();
        }

        public ActionResult PartnershipMap()
        {
            return View();
        }

        public ActionResult newIndex()
        {
            ViewBag.Home = "active";
            return View();
        }

    }
}
