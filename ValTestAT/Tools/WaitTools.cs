using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using ValTestAT.Base;

namespace ValTestAT.Tools
{
	public class WaitTools : ElementTools
	{
		public static bool WaitForURL(string url, int timeout = 500, bool contains = false)
		{
			int cont = 0;
			bool result = true;
			while (result & (cont < timeout))
			{
				if (contains)
				{
					result = DriverContext.Driver.Url.Contains(url);
				}
				else
				{
					result = DriverContext.Driver.Url == url;
				}				
				cont = cont + 1;
				Thread.Sleep(TimeSpan.FromMilliseconds(100));
			}
			return !result;
		}

		public static bool WaitForTextNotEmpty(IWebElement element, int timeout = 500)
		{
			int cont = 0;
			bool result = true;
			while (result & (cont < timeout))
			{
				result = element.Text == "";
				cont = cont + 1;
				Thread.Sleep(TimeSpan.FromMilliseconds(100));
			}

			Assert.IsFalse(result, string.Format("The element {0} text still empty", element.TagName));
			return !result;
		}

		public static bool WaitForVisibility(IWebElement element, int timeout = 500)
		{
			int cont = 0;
			bool result = true;
			while (result & (cont < timeout))
			{
				result = IsVisible(element);
				cont = cont + 1;
				Thread.Sleep(TimeSpan.FromMilliseconds(100));
			}

			Assert.IsFalse(result, $"The element {element.TagName} still not visible", element.TagName);
			return !result;
		}
	}
}
