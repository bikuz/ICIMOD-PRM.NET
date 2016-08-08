using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prm.Controllers
{
    public class InitiativeController : Controller
    {
        //
        // GET: /Initiative/

        public ActionResult ViewProfile()
        {
            ViewBag.Initiative = "active";
            ViewBag.Initiative_ViewProfile = "active";
            return View();
        }
        public ActionResult ViewInitiative()
        {
            ViewBag.Initiative = "active";
            ViewBag.ViewInitiative = "active";
            return View();
        }
    }
}
