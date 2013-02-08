using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Xml.Serialization;

public static class Data
{
	private static Content _con;
	public static Content Content
	{
		get
		{
			if (_con == null)
				Data.LoadContent(System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data/content.xml"));
			return _con;
		}
	}
	public static void LoadContent(string path)
	{
		if (_con != null) return;
		try
		{
			using (var fso = File.OpenRead(path))
			using (var read = new StreamReader(fso))
			{
				var serial = new XmlSerializer(typeof(Content), "");
				_con = serial.Deserialize(read) as Content;
			}
		}
		catch (Exception ex)
		{
			if (ex.InnerException != null)
				throw new Exception(ex.InnerException.StackTrace);
			throw new Exception(ex.GetType().Name);
		}
	}
}
