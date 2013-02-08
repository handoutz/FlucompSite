using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewFlucompMVC.Models
{
	public class HomeModel
	{

	}
	public class NavigationModel
	{
		public struct Link
		{
			public string Text { get; set; }
			public string Url { get; set; }
		}
		public List<Link> Links = new List<Link>();
	}
	public class ProductInfo
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public string Url { get; set; }
		public string ImageSrc { get; set; }
		public ProductInfo(string name, string desc, string url, string src)
		{
			Name = name;
			Description = desc;
			Url = url;
			ImageSrc = src;
		}
	}
	public class ProductModel
	{
		private List<ProductInfo> _plist;
		public List<ProductInfo> Products
		{
			get
			{
				if (_plist == null)
				{
					_plist = new List<ProductInfo>();
				}
				return _plist;
			}
		}
		public ProductInfo Current { get; set; }
	}
}