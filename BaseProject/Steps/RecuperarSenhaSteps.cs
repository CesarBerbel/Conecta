using TechTalk.SpecFlow;
using ValTestAT;
using ValTestAT.Base;

namespace BaseProject.Steps
{
	[Binding]
    public class RecuperarSenhaSteps : BaseSteps
    {
        [When(@"clico em Esqueceu sua senha\?")]
        public void QuandoClicoEmEsqueceuSuaSenha()
        {
            GetInstance<LoginModal>().ClicarEsqueceuSenha();
        }

        [Then(@"eu devo ver a tela de envio de senha com o titulo ""(.*)""")]
        public void EntaoEuDevoVerATelaDeEnvioDeSenhaComOTitulo(string msg)
        {
            GetInstance<LoginModal>().VerificarTituloModalEsqueciSenha(msg);
        }

        [When(@"eu clico em Não recebeu\? Reenviar email")]
        public void QuandoEuClicoEmNaoRecebeuReenviarEmail()
        {
            GetInstance<LoginModal>().ClicarReenviarEmail();
        }

        [When(@"eu clico em Não tenho mais acesso a este email")]
        public void QuandoEuClicoEmNaoTenhoMaisAcessoAEsteEmail()
        {
            GetInstance<LoginModal>().ClicarNaoTenhoAcessoEmail();
        }

        [Then(@"eu devo ver o final do telefone ""(.*)""")]
        public void EntaoEuDevoVerOFinalDoTelefone(string tel)
        {
            GetInstance<LoginModal>().VerificarTelefone(tel);
        }

        [When(@"eu preencho o campo Celular com ""(.*)""")]
        public void QuandoEuPreenchoOCampoCelularCom(string cel)
        {
            GetInstance<LoginModal>().PreencherCelular(cel);
        }

        [When(@"eu preencho o campo Novo email com ""(.*)""")]
        public void QuandoEuPreenchoOCampoNovoEmailCom(string email)
        {
            GetInstance<LoginModal>().PreencherEmail(email);
        }

        [When(@"clico em Habilitar novo email")]
        public void QuandoClicoEmHabilitarNovoEmail()
        {
            GetInstance<LoginModal>().ClicarLogar();
        }


    }
}