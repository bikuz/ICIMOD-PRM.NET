using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prm.Controllers
{
    public class PartnershipInstrumentController : Controller
    {
        //
        // GET: /PartnershipInstrument/

        public ActionResult PartnershipProfile()
        {
            ViewBag.PartnershipInstrument = "active";
            ViewBag.PartnershipProfile = "active";
            return View();
        }
        public ActionResult PartnerTracker()
        {
            ViewBag.PartnershipInstrument = "active";
            ViewBag.PartnerTracker = "active";
            return View();
        }
        public ActionResult ViewPartnershipsNew()
        {
            ViewBag.PartnershipInstrument = "active";
            ViewBag.ViewPartnershipsNew = "active";
            return View();
        }
        public ActionResult ViewPartnershipsOld()
        {
            ViewBag.PartnershipInstrument = "active";
            ViewBag.ViewPartnershipsOld = "active";
            return View();
        }
        public ActionResult ViewDonorList()
        {
            ViewBag.PartnershipInstrument = "active";
            ViewBag.ViewDonorList = "active";
            return View();
        }
    }
}
