using TechTalk.SpecFlow;
using ValTestAT;
using ValTestAT.Base;

namespace BaseProject.Steps
{
	[Binding]
    public class HomeSteps : BaseSteps
    {
		[Then(@"devo ver meu nome ""(.*)"" na Home")]
		public void EntaoDevoVerMeuNomeNaHome(string nome)
		{
			GetInstance<HomePage>().VerificarNomeMensagem(nome);
        }


        [Given(@"eu clico no menu profile para expandir")]
		public void DadoEuClicoNoMenuProfileParaExpandir()
		{
			GetInstance<HomePage>().ClicarNoMenuProfile();
		}


		[When(@"eu clico no menu profile Logado para expandir")]
		public void DadoEuClicoNoMenuProfileLogadoParaExpandir()
		{
			GetInstance<HomePage>().ClicarNoMenuProfileLogado();
		}

        [When(@"eu clico no menu profile validado para expandir")]
        public void QuandoEuClicoNoMenuProfileValidadoParaExpandir()
        {
            GetInstance<HomePage>().ClicarMenuProfileSoftlogin();
        }
        
        [When(@"eu clico em Itens Salvos")]
		public void QuandoEuClicoEmItensSalvos()
		{
			GetInstance<HomePage>().ClicarItensSalvos();
		}

		[Given(@"clico em Criar Conta")]
		public void DadoClicoEmCriarConta()
		{
			GetInstance<HomePage>().ClicarCriarConta();
		}

        [When(@"clico em Criar conta")]
        public void QuandoClicoEmCriarConta()
        {
            GetInstance<HomePage>().ClicarCriarContaValidado();
        }

        [When(@"eu clico em Meu Perfil")]
        public void QuandoEuClicoEmMeuPerfil()
        {
            GetInstance<HomePage>().ClicarMenuMeuPerfil();
        }

        [When(@"eu clico em Encerrar Sessao")]
        public void QuandoEuClicoEmEncerrarSessao()
        {
            GetInstance<HomePage>().ClicarEncerrarSessao();
        }

        [When(@"eu clico em Entrar")]
        public void DadoEuClicoEmEntrar()
        {
            GetInstance<HomePage>().ClicarEntrar();
        }

        [When(@"eu clico no Menu ""(.*)""")]
        public void QuandoEuClicoNoMenu(string cal)
        {
            GetInstance<HomePage>().ClicarCalendario(cal);
        }

        [When(@"eu clico em Busca")]
        public void QuandoEuClicoEmBusca()
        {
            GetInstance<HomePage>().ClicarMenuBusca();
        }


    }
}