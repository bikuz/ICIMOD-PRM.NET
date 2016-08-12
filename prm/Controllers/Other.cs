using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prm.Controllers
{
    public class OtherController : Controller
    {
        //
        // GET: /Other/

        public ActionResult RMC_RP_InitiativeReportsUpload()
        {
            ViewBag.Other = "active";
            ViewBag.RMC_RP_InitiativeReportsUpload = "active";
            return View();
        }
        public ActionResult CustomizedReport()
        {
            ViewBag.Other = "active";
            ViewBag.CustomizedReport = "active";
            return View();
        }
    }
}
