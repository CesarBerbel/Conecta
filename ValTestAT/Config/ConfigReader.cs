using System;
using System.IO;
using System.Xml.XPath;
using ValTestAT.Base;

namespace ValTestAT.Config
{
	public class ConfigReader
	{
		public static void InitializeConfigurations()
		{
			XPathItem url;
			XPathItem testtype;
			XPathItem isreport;
			XPathItem buildname;
			XPathItem browsertype;

			string strFilename = @"..\..\Config\GlobalConfig.xml";
			FileStream stream = new FileStream(strFilename, FileMode.Open);
			XPathDocument document = new XPathDocument(stream);
			XPathNavigator navigator = document.CreateNavigator();

			//Get XML Details and pass it in XPathItem type variables
			url = navigator.SelectSingleNode("ValTestAT/Settings/URL");
			buildname = navigator.SelectSingleNode("ValTestAT/Settings/BuildName");
			testtype = navigator.SelectSingleNode("ValTestAT/Settings/TestType");
			isreport = navigator.SelectSingleNode("ValTestAT/Settings/IsReport");
			browsertype = navigator.SelectSingleNode("ValTestAT/Settings/Browser");

			//Set XML Details in the property to be used accross framework
			Configurations.URL = url.Value.ToString();
			Configurations.BuildName = buildname.Value.ToString();
			Configurations.TestType = testtype.Value.ToString();
			Configurations.IsReporting = isreport.Value.ToString();
			Configurations.BrowserType = (BrowserType)Enum.Parse(typeof(BrowserType), browsertype.Value.ToString());
		}
	}
}
