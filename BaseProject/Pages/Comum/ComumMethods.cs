using System;
using System.Threading;
using ValTestAT.Base;

namespace ValTestAT
{
	partial class Comum : BasePage
	{
		public void ClicarFavoritos()
		{
			var ele = FindByXPath(IconeFavoritos);
			while (ele.GetAttribute("class").Contains("off"))
			{
				PerformClick(ele);
			}
		}

		public void ClicarCompartilhar()
		{
			PerformClick(FindByXPath(IconeCompartilhar));
		}

		public void VerificarAdcionarFavoritosMensagem(string msg)
		{
			CheckElementText(FindByXPath(MensagemAdcionado), msg);
			Thread.Sleep(TimeSpan.FromSeconds(8));
		}

		public void VerificarLinksRedeSocial(string links)
		{
			CheckIfListMatch(links.Split(','), ElementsByXPath(LinksRedesSociais));
		}
	}
}