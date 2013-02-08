using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewFlucompMVC.Models
{
	public class ServiceModel
	{
		public string WhichService { get; set; }
		public IHtmlString PageContent
		{
			get { return Data.Content.Pages["Services"].Contents[WhichService].HtmlValue; }
		}
	}
}