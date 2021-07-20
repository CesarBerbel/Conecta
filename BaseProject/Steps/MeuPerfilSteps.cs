using BaseProject.Pages.MeuPerfil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
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

    }
}
