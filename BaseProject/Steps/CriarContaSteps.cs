using TechTalk.SpecFlow;
using ValTestAT;
using ValTestAT.Base;

namespace BaseProject.Steps
{
	[Binding]
    public class CriarContaSteps : BaseSteps
    {
		[When(@"escolho tipo de HCP ""(.*)""")]
		public void QuandoEscolhoTipoDeHCP(string tipo)
		{
			GetInstance<CriarConta>().SelecionarTipoHCP(tipo);
		}

		[When(@"escolho o Estado ""(.*)""")]
		public void QuandoEscolhoOEstado(string uf)
		{
			GetInstance<CriarConta>().SelecionarEstado(uf);
		}

		[When(@"preencho o campo Número do registro com registro aleatório")]
		public void QuandoPreenchoOCampoNumeroDoRegistroComRegistroAleatorio()
		{
			GetInstance<CriarConta>().PreencherRegistroNumeroAleatorio();
		}

		[When(@"preencho o Email com email aleatório")]
		public void QuandoPreenchoOEmailComEmailAleatorio()
		{
			GetInstance<CriarConta>().PreencherEmailAleatorio();
		}

		[When(@"marco a opcao Li e concordo com os Termos e Condições")]
		public void QuandoMarcoAOpcaoLiEConcordoComOsTermosECondicoes()
		{
			GetInstance<CriarConta>().AceitarTermosECondicoes();
		}

		[When(@"eu clico em Continuar")]
		public void QuandoEuClicoEmContinuar()
		{
			GetInstance<CriarConta>().ClicarContinuar();
		}

		[When(@"Eu preencho o campo Nome com ""(.*)""")]
		public void QuandoEuPreenchoOCampoNomeCom(string nome)
		{
			GetInstance<CriarConta>().PreencherNome(nome);
		}

		[When(@"preencho o campo Sobrenome com ""(.*)""")]
		public void QuandoPreenchoOCampoSobrenomeCom(string sobreNome)
		{
			GetInstance<CriarConta>().PreencherSobreNome(sobreNome);
		}

		[When(@"eu preencho o Celular com ""(.*)""")]
		public void QuandoEuPreenchoOCelularCom(string cel)
		{
			GetInstance<CriarConta>().PreencherCelular(cel);
		}

		[When(@"preencho o campo Adicionar Senha com ""(.*)""")]
		public void QuandoPreenchoOCampoAdicionarSenhaCom(string senha)
		{
			GetInstance<CriarConta>().PreencherAdcionarSenha(senha);
		}

		[When(@"preencho o campo Repetir Senha com ""(.*)""")]
		public void QuandoPreenchoOCampoRepetirSenhaCom(string senha)
		{
			GetInstance<CriarConta>().PreencherRepetirSenha(senha);
		}

		[When(@"clico em Finalizar")]
		public void QuandoClicoEmFinalizar()
		{
			GetInstance<CriarConta>().ClicarContinuar();
		}

		[Then(@"devo ver a mensagem de conta criada com sucesso ""(.*)""")]
		public void EntaoDevoVerAMensagemDeContaCriadaComSucesso(string msg)
		{
			GetInstance<CriarConta>().VerificarMensagemSucesso(msg);
		}

		[When(@"eu valido com ""(.*)""")]
		public void QuandoEuValidoCom(string userString)
		{
			GetInstance<CriarConta>().ValidarUsuario(userString);
		}
	}
}