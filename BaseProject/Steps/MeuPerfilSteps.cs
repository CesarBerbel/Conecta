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
            GetInstance<MeuPerfilPage>().AlterarCelular(cel);
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
            GetInstance<MeuPerfilPage>().AlterarEmail(email);
        }

        [Then(@"devo ver a mensagem de validação de email inválido ""(.*)""")]
        [Then(@"devo ver a mensagem de validação de email ""(.*)""")]
        public void EntaoDevoVerAMensagemDeValidacaoDeEmail(string msg)
        {
            GetInstance<MeuPerfilPage>().ValidarMensagemEmail(msg);
        }

        [Then(@"devo ver a Mensagem de personalização da conta ""(.*)""")]
        public void EntaoDevoVerAMensagemDePersonalizacaoDaConta(string msg)
        {
            GetInstance<MeuPerfilPage>().VerificarMensagemPersonalizacaoConta(msg);
        }
        

        [Then(@"eu nao devo ver o botao Salvar")]
        public void EntaoEuNaoDevoVerOBotaoSalvar()
        {
            GetInstance<MeuPerfilPage>().VerificarVisibilidadeBotao();
        }

        [When(@"eu clico em Alterar senha")]
        public void QuandoEuClicoEmAlterarSenha()
        {
            GetInstance<MeuPerfilPage>().ClicarAlterarSenha();
        }

        [When(@"preencho o campo Senha com ""(.*)""")]
        public void QuandoPreenchoOCampoSenhaCom(string senha)
        {
            GetInstance<MeuPerfilPage>().PreencherSenha(senha);
        }

        [When(@"confirmo a senha ""(.*)"" no campo Repetir Senha")]
        public void QuandoConfirmoASenhaNoCampoRepetirSenha(string senha)
        {
            GetInstance<MeuPerfilPage>().ConfirmarSenha(senha);
        }

        [When(@"eu clico em Cadastrar")]
        public void QuandoEuClicoEmCadastrar()
        {
            GetInstance<MeuPerfilPage>().ClicarCadastrar();
        }

        [Then(@"devo ver a mensagem de validação ""(.*)""")]
        public void EntaoDevoVerAMensagemDeValidacao(string msg)
        {
            GetInstance<MeuPerfilPage>().VerificarMensagemSenha(msg);
        }

        [When(@"seleciono em interesses ""(.*)""")]
        public void QuandoSelecionoEmInteresses(string interesse)
        {
            GetInstance<MeuPerfilPage>().ClicarInteresses(interesse);
        }

        [When(@"eu clico Interesses")]
        [When(@"eu clico em Especialidades e Interesses")]
        public void QuandoEuClicoEmEspecialidadesEInteresses()
        {
            GetInstance<MeuPerfilPage>().ClicarEspecialidadeInteresses();
        }

        [When(@"eu escolho a Especialidade primária ""(.*)""")]
        public void QuandoEuEscolhoAEspecialidadePrimaria(string primaria)
        {
            GetInstance<MeuPerfilPage>().SelecionarEspecialidadePrimaria(primaria);
        }

        [When(@"eu escolho a Especialidade secundária ""(.*)""")]
        public void QuandoEuEscolhoAEspecialidadeSecundaria(string secundaria)
        {
            GetInstance<MeuPerfilPage>().SelecionarEspecialidadeSecundaria(secundaria);
        }

        [When(@"clico em Personalizar")]
        public void QuandoClicoEmPersonalizar()
        {
            GetInstance<MeuPerfilPage>().ClicarPersonalizar();

        }

        [When(@"seleciono ""(.*)"" em Empresa onde trabalha")]
        public void QuandoSelecionoEmEmpresaOndeTrabalha(string empresa)
        {
            GetInstance<MeuPerfilPage>().SelecionarEmpresaOndeTrabalha(empresa);
        }

        [When(@"Preencho o campo cidade com ""(.*)""")]
        public void QuandoPreenchoOCampoCidadeCom(string cid)
        {
            GetInstance<MeuPerfilPage>().PreencherCidade(cid);
        }


        [When(@"seleciono a cidade ""(.*)""")]
        public void QuandoSelecionoACidade(string cid)
        {
            GetInstance<MeuPerfilPage>().SelecionarCidade(cid);
        }

        [Then(@"eu não devo ver o campo Cidade")]
        public void EntaoEuNaoDevoVerOCampoCidade()
        {
            GetInstance<MeuPerfilPage>().VerificarVisibilidadeCampoCidade();
        }

        [When(@"preencho o campo Nome do local onde trabalha com ""(.*)""")]
        public void QuandoPreenchoOCampoNomeDoLocalOndeTrabalhaCom(string localTrab)
        {
            GetInstance<MeuPerfilPage>().PreencherNomeLocalTrabalho(localTrab);
        }

        [Then(@"devo ver a mensagem de obrigatoriedade ""(.*)""")]
        public void EntaoDevoVerAMensagemDeObrigatoriedade(string msg)
        {
            GetInstance<MeuPerfilPage>().ValidarObrigatoriedade(msg);
        }

    }
}
