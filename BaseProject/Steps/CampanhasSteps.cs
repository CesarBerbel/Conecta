using TechTalk.SpecFlow;
using ValTestAT;
using ValTestAT.Base;

namespace BaseProject.Steps
{
	[Binding]
    public class CampanhasSteps : BaseSteps
    {
        [Given(@"que eu acesse a campanha ""(.*)""")]
        public void DadoQueEuAcesseACampanha(string campanha)
        {

            GetInstance<CampanhaPage>().AcessarCampanha(campanha);
            GetInstance<LoginModal>().RealizarPreLogin();

        }


        [When(@"eu acesso a campanha ""(.*)""")]
        public void QuandoEuAcessoACampanha(string url)
        {  
			GetInstance<CampanhaPage>().AcessarCampanha(url);
		}

        [When(@"clico em Fechar")]
        public void QuandoClicoEmFechar()
        {
            GetInstance<CampanhaPage>().ClicarBotaoFechar();
        }

        [Then(@"devo ver a mensagem de conta identificada ""(.*)""")]
        public void EntaoDevoVerAMensagemDeContaIdentificada(string msg)
        {
            GetInstance<CampanhaPage>().VerificarMensagemContaIdentificada(msg);
        }

        [Then(@"eu visualizo a campanha ""(.*)""")]
        public void EntaoEuVisualizoACampanha(string campanha)
        {
            GetInstance<CampanhaPage>().VerificarCampanha(campanha);
        }

        [When(@"clico em Deixar para depois")]
        public void QuandoClicoEmDeixarParaDepois()
        {
            GetInstance<LoginModal>().ClicarEmDeixarParaDepois();
        }

        [Given(@"que eu retorne para home")]
        public void DadoQueEuRetorneParaHome()
        {
            NavigateToHome();
        }

    }
}