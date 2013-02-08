using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewFlucompMVC.Controllers
{
	public class UtilityController : Controller
	{
		public ActionResult Index()
		{
			return RedirectToAction("Index", "Home");
		}
		public ActionResult ExternalLinkId(int id)
		{
			var links = new[]{
				"http://validator.w3.org/check?uri=http%3A%2F%2Fflucomp.com%2FnewDesign&charset=%28detect+automatically%29&doctype=Inline&group=0"
			};
			if (id >= links.Length)
				return RedirectToAction("Index", "Home");
			else return RedirectPermanent(links[id]);
		}
		public ActionResult ExternalLink(string id)
		{
			return RedirectPermanent(id);
		}
	}
}
