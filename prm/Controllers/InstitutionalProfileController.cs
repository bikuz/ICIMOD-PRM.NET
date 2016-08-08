using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prm.Controllers
{
    public class InstitutionalProfileController : Controller
    {
        //
        // GET: /InstitutionalProfile/

        public ActionResult AddPartner()
        {
            ViewBag.Partners = "active";
            ViewBag.AddPartner = "active";
            return View();
        }

        public ActionResult AddPartnerInfo()
        {
            return PartialView();
        }

        public ActionResult AddOrganizationalInfo()
        {
            return PartialView();
        }
    }
}
