using BaseProject.Pages.MeuPerfil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using ValTestAT;
using ValTestAT.Base;

namespace BaseProject.Steps
{
    [Binding]
    class MeuPerfilSteps : BaseSteps
    {
        [Then(@"devo ser direcionado para pagina de Perfil")]
        public void EntaoDevoSerDirecionadoParaPaginaDePerfil()
        {
            GetInstance<MeuPerfilPage>().VerificarPaginaPerfil();
        }

        [When(@"eu clico em Minha conta")]
        public void QuandoEuClicoEmMinhaConta()
        {
            GetInstance<MeuPerfilPage>().ClicarMinhaConta();
        }

        [When(@"eu altero o Celular para ""(.*)""")]
        public void QuandoEuAlteroOCelularPara(string cel)
        {
            GetInstance<MeuPerfilPage>().PreencherCelular(cel);
        }


        [When(@"eu altero o Celular para um numero valido")]
        public void QuandoEuAlteroOCelularParaUmNumeroValido()
        {
            GetInstance<MeuPerfilPage>().PreencherCelularAleatorio();
        }

        [When(@"eu clico em Salvar")]
        public void QuandoEuClicoEmSalvar()
        {
            GetInstance<MeuPerfilPage>().ClicarSalvar();
        }

        [Then(@"devo visualizar a mensagem ""(.*)""")]
        public void EntaoDevoVisualizarAMensagem(string msg)
        {
            GetInstance<MeuPerfilPage>().VerificarMensagemAlteracao(msg);
        }

        [When(@"altero o Email com email válido")]
        public void QuandoAlteroOEmailComEmailValido()
        {
           GetInstance<MeuPerfilPage>().PreencherEmailAleatorio();
        }

        [When(@"altero o Email para ""(.*)""")]
        public void QuandoAlteroOEmailPara(string email)
        {
            GetInstance<MeuPerfilPage>().PreencherEmail(email);
        }

        //[Then(@"devo ver a mensagem de validação de email ""(.*)""")]
        //public void EntaoDevoVerAMensagemDeValidacaoDeEmail(string msg)
        //{
        //    GetInstance<MeuPerfilPage>().ValidarMensagemEmail(msg);
        //}


        //[Then(@"eu nao devo ver o botao Salvar")]
        //public void EntaoEuNaoDevoVerOBotaoSalvar()
        //{
        //    GetInstance<MeuPerfilPage>().VerificarVisibilidadeBotao();
        //}

    }
}
