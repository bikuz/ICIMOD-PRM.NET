using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prm.Controllers
{
    public class RPController : Controller
    {
        //
        // GET: /RP/

        public ActionResult ViewRP()
        {
            ViewBag.RP = "active";
            ViewBag.ViewRP = "active";
            return View();
        }
        public ActionResult ViewProfile()
        {
            ViewBag.RP = "active";
            ViewBag.RP_ViewProfile = "active";
            return View();
        }

    }
}
