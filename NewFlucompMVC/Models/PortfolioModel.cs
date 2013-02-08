using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewFlucompMVC.Models
{
	public class PortfolioModel
	{
		public string CaseId { get; set; }
		public IHtmlString Content
		{
			get { return Data.Content.Pages["Portfolio"].Contents[CaseId].HtmlValue; }
		}
	}
}