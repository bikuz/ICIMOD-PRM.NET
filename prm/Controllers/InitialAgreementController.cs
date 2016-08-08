using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prm.Controllers
{
    public class InitialAgreementController : Controller
    {
        //
        // GET: /InitialAgreement/

        public ActionResult AddDonor()
        {
            ViewBag.PartnershipInstrument = "active";
            ViewBag.PartnershipInstrument_AddDonor = "active";
            return View();
        }

        public ActionResult AddClauses()
        {
            ViewBag.Other = "active";
            ViewBag.Other_AddClauses = "active";
            return View();
        }

        public ActionResult AddContract()
        {
            ViewBag.PartnershipInstrument = "active";
            ViewBag.PartnershipInstrument_AddContract = "active";
            return View();
        }
    }
}
