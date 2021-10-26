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
            int valor = 1;

            
            while ((ele.GetAttribute("class").Contains("off")) & (valor <= 5))
            {
                PerformClick(ele);
                Thread.Sleep(TimeSpan.FromMilliseconds(100));
                valor++;
            }         
        }

		public void ClicarCompartilhar()
		{
			PerformClick(FindByXPath(IconeCompartilhar));
		}

		public void VerificarAdcionarFavoritosMensagem(string msg)
		{
			CheckIfListContainsText(FindByXPath(MensagemAdcionado), msg);
			Thread.Sleep(TimeSpan.FromSeconds(8));
		}

		public void VerificarLinksRedeSocial(string links)
		{
			CheckIfListMatch(ElementsByXPath(LinksRedesSociais), links.Split(','));
		}

        public void ClicarFecharModal()
        {
            Click(FindByXPath(FecharModal));
        }
    }
}