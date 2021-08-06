using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValTestAT.Base;
using ValTestAT.Tools;

namespace ValTestAT
{
	partial class ArtigoPage : BasePage
	{
		public void AcessarArtigo(string url)
		{
			NavigateTo(BaseUrl + url);
			CheckForURL(BaseUrl + url);
		}

		public void VerificarMensagemConteudoExclusivo(string msg)
		{
			CheckIfListContainsText(FindByXPath(MensagemConteudoExclusivo), msg);
		}

		public void VerificarArtigo(string artigo)
		{
			CheckForURL(BaseUrl + artigo);
		}

        public void VerificarMsgConteudoExclusivoOops(string msg)
        {
            string mensagem = ElementTools.GetText(FindByXPath(MsgConteudoExclusivoOops)).Remove(4, 2);
            
            Assert.AreEqual(mensagem, msg);
        }

        public void VerificarMensagemOops(string msg)
        {
            string mensagem = ElementTools.GetText(FindByXPath(MsgConteudoExclusivoOops)).Replace("\r\n", " ");

            Assert.AreEqual(mensagem, msg);

            
        }

        public void ClicarVoltarHome()
        {
            Click(FindById(BotaoVoltarHome));
        }

    }
}