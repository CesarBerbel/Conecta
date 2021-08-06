using TechTalk.SpecFlow;
using ValTestAT;
using ValTestAT.Base;

namespace BaseProject.Steps
{
	[Binding]
    public class LoginSteps : BaseSteps
    {
        
        [When(@"clico em Logar")]
        public void QuandoClicoEmLogar()
        {
            GetInstance<LoginModal>().ClicarLogar();
        }

        [Then(@"eu devo ser direcionado para Home deslogada")]
        public void EntaoEuDevoSerDirecionadoParaHomeDeslogada()
        {
            NavigateToHome();
        }

        [Then(@"devo ver a mensagem de erro do login ""(.*)""")]
        public void EntaoDevoVerAMensagemDeErroDoLogin(string msg)
        {
            GetInstance<LoginModal>().VerificarMensagemValidacao(msg);
        }

        [When(@"Eu escolho o login por email")]
        public void QuandoEuEscolhoOLoginPorEmail()
        {
            GetInstance<LoginModal>().EscolherLoginPorEmail();
        }



    }
}