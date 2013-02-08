using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewFlucompMVC.Models
{
	public class ContactFormModel
	{
		[Required, DataType(DataType.EmailAddress)]
		public string From { get; set; }

		[Required]
		public string Subject { get; set; }

		[Required]
		public string Message { get; set; }
	}
}