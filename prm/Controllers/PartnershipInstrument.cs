﻿using System;
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
            return View();
        }
        public ActionResult PartnerTracker()
        {
            return View();
        }
        public ActionResult ViewPartnershipsNew()
        {
            return View();
        }
        public ActionResult ViewPartnershipsOld()
        {
            return View();
        }
    }
}
