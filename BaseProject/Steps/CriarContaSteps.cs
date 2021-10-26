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

        [When(@"preencho o campo email com ""(.*)""")]
        public void QuandoPreenchoOCampoEmailCom(string email)
        {
            GetInstance<CriarConta>().PreencherCampoEmail(email);
        }


        [When(@"marco a opcao Li e concordo com os Termos e Condições")]
		public void QuandoMarcoAOpcaoLiEConcordoComOsTermosECondicoes()
		{
			GetInstance<CriarConta>().AceitarTermosECondicoes();
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

        [When(@"clico em Prosseguir")]
        public void QuandoClicoEmProsseguir()
        {
            GetInstance<LoginModal>().ClicarEmProsseguir();
        }

        [When(@"clico em Continuar")]          
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

        [Then(@"devo ver as mensagens de erro ""(.*)""")]
        public void EntaoDevoVerAsMensagensDeErro(string msg)
        {
            GetInstance<CriarConta>().VerificarMensagemObrigatoria(msg);
        }

       [Then(@"devo ver a mensagens de erro ""(.*)""")]
        public void EntaoDevoVerAMensagensDeErro(string msg)
        {
            GetInstance<CriarConta>().VerificarMensagemErro(msg);
        }
        
        [When(@"eu valido com ""(.*)""")]
		public void QuandoEuValidoCom(string userString)
		{
			GetInstance<CriarConta>().ValidarUsuario(userString);
		}

        [When(@"preencho o Cadastro completo com ""(.*)""")]
        public void QuandoPreenchoOCadastroCompletoCom(string userString)
        {
            GetInstance<CriarConta>().CadastrarContaCompleta(userString);
        }

        [When(@"preencho os dados iniciais do Cadastro com ""(.*)""")]
        public void QuandoPreenchoOsDadosIniciaisDoCadastroCom(string userString)
        {
            GetInstance<CriarConta>().IniciarCadastroConta(userString);
        }

        [When(@"preencho o Cadastro com registro e email aleatórios ""(.*)""")]
        public void QuandoPreenchoOCadastroComRegistroEEmailAleatorios(string userString)
        {
            GetInstance<CriarConta>().IniciarCadastroContaAleatorio(userString);
        }

        [When(@"preencho os dados finais do cadastro com ""(.*)""")]
        public void QuandoPreenchoOsDadosFinaisDoCadastroCom(string userString)
        {
            GetInstance<CriarConta>().FinalizarCadastroConta(userString);
        }

        [Then(@"eu devo ver a mensagem de finalizacao de cadastro ""(.*)""")]
        public void EntaoEuDevoVerAMensagemDeFinalizacaoDeCadastro(string msg)
        {
            GetInstance<CriarConta>().VerificarMensagemFinalCadastro(msg);
        }

        [When(@"preencho o email aleatório")]
        public void QuandoPreenchoOEmailAleatorio()
        {
            GetInstance<CriarConta>().PreencherEmailAleatorio();
        }
    }
}