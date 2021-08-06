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
        [When(@"preencho o campo Número do registro com ""(.*)""")]
        public void QuandoPreenchoOCampoNumeroDoRegistroCom(string numRegistro)
        {
            GetInstance<LoginModal>().PreencherRegistro(numRegistro);
        }

        [Given(@"eu logue como ""(.*)"" com o e-mail ""(.*)"" e a senha ""(.*)""")]
        public void DadoEuLogoComOE_MailEASenha(string nome, string email, string senha)
		{
			GetInstance<HomePage>().ClicarNoMenuProfile();
			GetInstance<HomePage>().ClicarEntrar();
			GetInstance<LoginModal>().LogarPorEmail(nome, email, senha);
		}

        [When(@"eu logo pelo registro com ""(.*)""")]
        public void QuandoEuLogoPeloRegistroCom(string user)
        {
            GetInstance<HomePage>().ClicarNoMenuProfile();
            GetInstance<HomePage>().ClicarEntrar();
            GetInstance<LoginModal>().LogarPorRegistro(user);
        }

        [When(@"eu logo pelo email com ""(.*)"" e ""(.*)""")]
        public void QuandoEuLogoPeloEmailComE(string email, string senha)
        {
            GetInstance<LoginModal>().LogarComEmail(email, senha);
        }


        [When(@"eu me logo com ""(.*)"" e ""(.*)""")]
		public void QuandoEuMeLogoComE(string email, string senha)
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