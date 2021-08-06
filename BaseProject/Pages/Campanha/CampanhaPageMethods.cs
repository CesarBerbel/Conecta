using System;
using System.Threading;
using ValTestAT.Base;
using ValTestAT.Config;
using ValTestAT.Tools;

namespace ValTestAT
{
	partial class CampanhaPage : BasePage
	{
		public void AcessarCampanha(string url)
		{
			NavigateTo(BaseUrl + url);
			CheckForURL(BaseUrl + url);
		}
        public void ClicarBotaoFechar()
        {
            Click(WaitTools.WaitForVisibility("xpath", BotaoFechar));

        }
        public void VerificarMensagemContaIdentificada(string msg)
        {
            CheckIfListContainsText(FindByXPath(MsgContaIdentificada), msg);
        }

        public void VerificarCampanha(string campanha)
        {
            CheckForURL(BaseUrl + campanha);
        }
               
    }
}