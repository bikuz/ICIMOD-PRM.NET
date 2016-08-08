using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prm.Controllers
{
    public class PartnershipAgreementController : Controller
    {
        //
        // GET: /PartnershipAgreement/

        public ActionResult ImportDeliverable()
        {
            ViewBag.PartnershipInstrument = "active";
            ViewBag.PartnershipAgreement_ImportDeliverable = "active";
            return View();
        }

        public ActionResult AddContract()
        {
            ViewBag.PartnershipInstrument = "active";
            ViewBag.PartnershipAgreement_AddContract = "active";
            return View();
        }
    }
}
