using TechTalk.SpecFlow;
using ValTestAT;
using ValTestAT.Base;

namespace BaseProject.Steps
{
	[Binding]
    public class ComumSteps : BaseSteps
    {
        [Given(@"que eu acesse o sistema")]
        public void DadoQueEuAcesseOSistema()
        {
			NavigateToHome();
			GetInstance<LoginModal>().RealizarPreLogin();
		}

		[Given(@"eu logo por e-mail ""(.*)"" e a senha ""(.*)""")]
		public void DadoEuLogoComOE_MailEASenha(string email, string senha)
		{
			GetInstance<HomePage>().ClicarNoMenuProfile();
			GetInstance<HomePage>().ClicarEntrar();
			GetInstance<LoginModal>().LogarPorEmail(email, senha);
		}

		[When(@"eu me logando com ""(.*)"" e ""(.*)""")]
		public void QuandoEuMeLogandoComE(string email, string senha)
		{
			GetInstance<LoginModal>().LogarValidacao(email, senha);
		}

		[When(@"eu clico em Favoritos")]
		public void QuandoEuClicoEmFavoritos()
		{
			GetInstance<Comum>().ClicarFavoritos();
		}

		[Then(@"eu devo ver a mensagem dos favoritos ""(.*)""")]
		public void EntaoEuDevoVerAMensagemDosFavoritos(string msg)
		{
			GetInstance<Comum>().VerificarAdcionarFavoritosMensagem(msg);
		}

		[When(@"eu clico em Compartilhar")]
		public void QuandoEuClicoEmCompartilhar()
		{
			GetInstance<Comum>().ClicarCompartilhar();
		}

		[Then(@"devo ver os links ""(.*)""")]
		public void EntaoDevoVerOsLinks(string links)
		{
			GetInstance<Comum>().VerificarLinksRedeSocial(links);
		}
	}
}