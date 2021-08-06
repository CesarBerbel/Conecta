using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using ValTestAT.Base;
using ValTestAT.Tools;

namespace ValTestAT
{
	partial class EventoPage : BasePage
	{
		public void AcessarEvento(string url)
		{
			NavigateTo(BaseUrl + url);
			CheckForURL(BaseUrl + url);
		}

        public void VerificarEvento(string evento)
        {
            CheckForURL(BaseUrl + evento);
        }
        public void ClicarNoLinkSalvar()
        {
            JClick(WaitTools.WaitForVisibility("xpath", LinkCalendario));
        }
        public void SelecionarOpcaoNoLinkSalvar(string opcao)
        {
            JClick(FindByXPath(string.Format(OpcaoNoLinkSalvar, opcao)));
        }

        public void ClicarAdicionarCal(string botaoCal)
        {
            JClick(FindByXPath(string.Format(BotaoCalendario, botaoCal)));
        }         

        public void SelecionarOpcaoNoBotaoCal(string opcao)
        {
            JClick(FindByXPath(string.Format(OpcaoNoLinkSalvar, opcao)));
        }

        public void VerificarVisibilidadeBotaoAdicionarCal()
        {
            CheckIfElementNotExists(ElementsByXPath(BotaoCalendario, false));
        }

        public void VerificarVisibilidadeBotaoAoVivo(string TextoBotao)
        {
            string mensagem = ElementTools.GetText(FindByXPath(BotaoAoVivo));
            Assert.AreEqual(mensagem, TextoBotao);
        }
                
        public void VerificarVisibilidadeBotaoAdicionado(string BtnAdicionado)
        {
            CheckElementTextContains(FindByXPath(BotaoAdicionado), BtnAdicionado);            
        }           

    }
}
