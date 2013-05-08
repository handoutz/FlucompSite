using NewFlucompMVC.Areas.Admin534139597.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DreamSeat;
using System.Web.Security;

namespace NewFlucompMVC.Areas.Admin534139597.Controllers
{
    public class AccountController : Controller
    {
        bool VerifyLogin(LoginModel mod)
        {
            try
            {
                var doc = Databasing.RetrieveById(mod.Username);
                /*Response.Write(doc.passhash);
                Response.Write("   $$$$$$$$$$$<br />");
                Response.Write(mod.PWHash(mod.Password));
                Response.Write("<br />");
                Response.Write(mod.Password);
                Response.Write("<br />");
                Response.Write(mod.PWHash("vadsfGFSDc423fSdg"));*/
                return (doc.passhash == mod.PWHash(mod.Password));
            }
            catch (Exception e)
            {
                Response.Write(e.ToString());
            }
            return false;
        }
        public ActionResult Login()
        {
            return View(new LoginModel());
        }
        [HttpPost]
        public ActionResult Login(LoginModel mod)
        {
            if (ModelState.IsValid)
            {
                if (VerifyLogin(mod))
                {
                    FormsAuthentication.SetAuthCookie(mod.Username, true);
                    return RedirectToAction("Index", "Dash");
                }
                ModelState.AddModelError("", "Invalid username or password.");
            }
            return View();
        }
    }
}
