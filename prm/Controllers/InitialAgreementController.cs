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
            return View();
        }

        public ActionResult AddClauses()
        {
            return View();
        }

        public ActionResult AddContract()
        {
            return View();
        }
    }
}
