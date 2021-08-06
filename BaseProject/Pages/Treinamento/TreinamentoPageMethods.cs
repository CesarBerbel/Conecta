using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValTestAT.Base;
using ValTestAT.Tools;

namespace ValTestAT
{
	partial class TreinamentoPage : BasePage
	{
		public void AcessarTreinamento(string url)
		{
			NavigateTo(BaseUrl + url);
			CheckForURL(BaseUrl + url);
		}
		public void VerificarTreinamento(string treinamento)
		{
			CheckForURL(BaseUrl + treinamento);
		}
        public void ClicarMenuTreinamento()
        {
            Click(FindByXPath(MenuTreinamento));
        }
        public void ClicarBaixarCertificado()
        {
            JClick(FindByXPath(LinkCertificado));
        }

        public void VisualizarCertificado(string certificado)
        {            
            DriverContext.Driver.SwitchTo().Window(DriverContext.Driver.WindowHandles[1]);            
            Assert.IsTrue(DriverContext.Driver.Url.Contains(certificado));
            DriverContext.Driver.SwitchTo().Window(DriverContext.Driver.WindowHandles[0]);
        }

        public void ClicarAbrirModuloDermatite()
        {
            JClick(WaitTools.WaitForVisibility("xpath", BotaoAbrirModuloDermatite));
        }

        public void ClicarAbrirModuloComunicacao()
        {
            JClick(WaitTools.WaitForVisibility("xpath", BotaoAbrirModuloComunicacaoEfic));
        }

        public void ClicarBaixarPdf()
        {
            JClick(FindByXPath(BaixarPdf));
        }

        public void VerificarConclusaoModulo()
        {
            WaitTools.WaitForVisibility("xpath", IconeModuloConcluido);
        }

        public void ClicarEnviarResposta()
        {
            Click(FindByXPath(BotaoEnviarResposta));
        }

        public void VerificarMensagemResposta(string msg)
        {
            CheckIfListContainsText(FindByXPath(MensagemRespCerta), msg);
        }

        public void VerificarMensagemModuloCompleto(string msg)
        {
            CheckIfListContainsText(FindByXPath(MensagemModuloCompleto), msg);
        }
        public void VerificarMensagemConclusaoCurso(string msg)
        {
            CheckIfListContainsText(FindByXPath(MensagemCursoCompleto), msg);
        }

        public void VerificarMensagemPesquisaSatisfacao(string msg)
        {
            CheckIfListContainsText(FindByXPath(MensagemPesqSatisf), msg);
        }

        public void ClicarProximaPergunta()
        {
            Click(FindByXPath(BotaoProximaPergunta));
        }

        public void ClicarFecharModulo()
        {
            Click(FindByXPath(IconeFecharModulo));
        }

        public void ClicarBotaoProximo()
        {
            JClick(FindByXPath(BotaoProximo));
        }

        public void ClicarRespostaQuizz(string resposta, string pergunta)
        {
            JClick(FindByXPath(string.Format(RespostaQuizz, pergunta, resposta)));
        }

        public void ClicarRespostaPesquisaSatisfacao(string resposta, string questao)
        {
            JClick(FindByXPath(string.Format(RespostaPesquisaSatisfacao, questao, resposta)));
        }
    }
}