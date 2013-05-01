using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewFlucompMVC.Models;

namespace NewFlucompMVC.Controllers
{
	public class HomeController : Controller
	{
		private void InitViewbag()
		{
			if (ViewBag.Initialized == null)
			{
				var menu = new Models.NavigationModel();
				menu.Links.Add(new Models.NavigationModel.Link() { Text = "Home", Url = Url.Action("Index") });
				menu.Links.Add(new Models.NavigationModel.Link() { Text = "Products", Url = Url.Action("Products") });
				menu.Links.Add(new Models.NavigationModel.Link() { Text = "Portfolio", Url = Url.Action("Portfolio") });
				menu.Links.Add(new Models.NavigationModel.Link() { Text = "Services", Url = Url.Action("Services") });
				//menu.Links.Add(new Models.NavigationModel.Link() { Text = "About Us", Url = Url.Action("About") });
				menu.Links.Add(new Models.NavigationModel.Link() { Text = "Contact Us", Url = Url.Action("Contact") });
				menu.Links.Add(new Models.NavigationModel.Link() { Text = "Leadership", Url = Url.Action("Staff") });
				//menu.Links.Add(new NavigationModel.Link() {Text=""});
				ViewBag.NavMenu = menu;
				ViewBag.GetLayout = new Func<string>(() =>
				{
					if (Request.IsAjaxRequest())
						return null;
					else
						return "~/Views/Shared/_Layout.cshtml";
				});
			}
			ViewBag.Initialized = true;
		}
		public ActionResult Portfolio(string id = "Index")
		{
			InitViewbag();
			return View("Portfolio", new PortfolioModel()
										 {
											 CaseId = id
										 });
		}
		public ActionResult ContentWriter()
		{
            InitViewbag();
			return View("ContentWriter");
		}
		private ActionResult GetView(string name, object model = null)
		{
			if (Request.IsAjaxRequest())
			{
				ViewBag.IsPartial = true;
				return PartialView(name, model);
			}
			else
				return View(name, model);
		}
		private string c(string str)
		{
			return Url.Content(str);
		}
		public ActionResult Index()
		{
			InitViewbag();
            ViewBag.FeaturedProduct = CreateProductModel().Products[1];
			return GetView("Index");
		}
		public ProductModel CreateProductModel()
		{
			var model = new ProductModel();
			var blank = c("~/Include/img/gallery_none.png");
			foreach (var prod in Data.Content.Pages["Products"].Product)
			{
				model.Products.Add(new ProductInfo(prod.Name, prod.Description, Url.Content(prod.Link), c(prod.Picture)));
			}
			return model;
		}
		public ActionResult Products()
		{
			InitViewbag();
			var model = CreateProductModel();
			model.Current = model.Products[0];
			return GetView("Products", model);
		}
		public ActionResult ProductInfo(int id)
		{
			InitViewbag();
			var model = CreateProductModel();
			model.Current = model.Products[id];
			if (Request.IsAjaxRequest())
				return PartialView("ProductInfo", model.Current);
			else
				return GetView("Products", model);
		}
		public ActionResult About()
		{
			InitViewbag();
			return GetView("About");
		}
		public ActionResult Contact()
		{
			InitViewbag();
			return GetView("Contact");
		}
		public ActionResult Services(string id = "Index")
		{
			InitViewbag();
			return GetView("Services", new ServiceModel()
										   {
											   WhichService = id
										   });
		}
		public ActionResult Staff()
		{
			InitViewbag();
			return GetView("Staff");
		}
	}
}
