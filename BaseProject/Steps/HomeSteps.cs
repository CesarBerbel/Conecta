using TechTalk.SpecFlow;
using ValTestAT;
using ValTestAT.Base;

namespace BaseProject.Steps
{
	[Binding]
    public class HomeSteps : BaseSteps
    {
		[Then(@"devo ver meu nome ""(.*)"" no menu profile")]
		public void EntaoDevoVerMeuNomeNoMenuProfile(string nome)
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

	}
}