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
            return View();
        }
        public ActionResult ViewPartnerProfile()
        {
            return View();
        }
        public ActionResult PartnerContact()
        {
            return View();
        }
    }
}
