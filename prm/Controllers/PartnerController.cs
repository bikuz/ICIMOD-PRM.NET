using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prm.Controllers
{
    public class PartnerController : Controller
    {
        //
        // GET: /Partner/

        public ActionResult ViewPartnerList()
        {
            ViewBag.Partners = "active";
            ViewBag.ViewPartnerList = "active";
            return View();
        }
        public ActionResult ViewPartnerProfile()
        {
            ViewBag.Partners = "active";
            ViewBag.ViewPartnerProfile = "active";
            return View();
        }
        public ActionResult PartnerContact()
        {
            ViewBag.Partners = "active";
            ViewBag.PartnerContact = "active";
            return View();
        }
        public ActionResult ViewPartnerProfileRoster()
        {
            ViewBag.Partners = "active";
            ViewBag.ViewPartnerProfileRoster = "active";
            return View();
        }
    }
}
