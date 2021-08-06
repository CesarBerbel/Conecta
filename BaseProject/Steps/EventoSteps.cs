using TechTalk.SpecFlow;
using ValTestAT;
using ValTestAT.Base;

namespace BaseProject.Steps
{
	[Binding]
    public class EventoSteps : BaseSteps
    {
        [When(@"eu acesso o evento ""(.*)""")]
        public void QuandoEuAcessoOEvento(string evento)
        {
            GetInstance<EventoPage>().AcessarEvento(evento);
        }

        [Then(@"eu visualizo o evento ""(.*)""")]
        public void EntaoEuVisualizoOEvento(string evento)
        {
            GetInstance<EventoPage>().VerificarEvento(evento);

        }

        [When(@"clico no link Salvar no calendário dentro da palestra")]
        public void QuandoClicoNoLinkSalvarNoCalendarioDentroDaPalestra()
        {
            GetInstance<EventoPage>().ClicarNoLinkSalvar();
        }

        [When(@"escolho ""(.*)"" dentro da palestra")]
        public void QuandoEscolhoDentroDaPalestra(string opcao)
        {
            GetInstance<EventoPage>().SelecionarOpcaoNoLinkSalvar(opcao);
            
        }
        [When(@"eu fecho o modal")]
        public void QuandoEuFechoOModal()
        {
            GetInstance<LoginModal>().ClicarFecharModal();
        }
        [Then(@"devo ver a mensagem de conteúdo exclusivo ""(.*)""")]
        public void EntaoDevoVerAMensagemDeConteudoExclusivo(string msg)
        {
            GetInstance<ArtigoPage>().VerificarMensagemOops(msg);
        }

        [Then(@"eu visualizo o botão Adicionar a meu calendário")]          
        [Then(@"não devo ver o botão de Adicionar a meu calendário")]
        public void EntaoNaoDevoVerOBotaoDeAdicionarAMeuCalendario()
        {
            GetInstance<EventoPage>().VerificarVisibilidadeBotaoAdicionarCal();
        }

        [Then(@"devo ver o botão ""(.*)""")]
        public void EntaoDevoVerOBotao(string botao)
        {
            GetInstance<EventoPage>().VerificarVisibilidadeBotaoAoVivo(botao);
        }

        [Then(@"eu vejo o botão ""(.*)""")]
        public void EntaoEuVejoOBotao(string BtnAdicionado)
        {
            GetInstance<EventoPage>().VerificarVisibilidadeBotaoAdicionado(BtnAdicionado);
        }


        [When(@"eu clico em ""(.*)""")]
        public void QuandoEuClicoEm(string botaoCal)
        {
            GetInstance<EventoPage>().ClicarAdicionarCal(botaoCal);
        }

        [When(@"seleciono a opcao ""(.*)""")]
        public void QuandoSelecionoAOpcao(string opcao)
        {
            GetInstance<EventoPage>().SelecionarOpcaoNoLinkSalvar(opcao);
        }

    }
}