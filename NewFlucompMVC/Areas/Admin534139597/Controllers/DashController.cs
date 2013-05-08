using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewFlucompMVC.Areas.Admin534139597.Controllers
{
    public class DashController : Controller
    {
        //
        // GET: /Admin534139597/Home/

        public ActionResult Index()
        {
            if (!Request.IsAuthenticated)
                return RedirectToAction("Login", "Account");
            return View();
        }

    }
}
