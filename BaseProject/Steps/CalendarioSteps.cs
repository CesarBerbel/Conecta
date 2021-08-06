using TechTalk.SpecFlow;
using ValTestAT;
using ValTestAT.Base;

namespace BaseProject.Steps
{
	[Binding]
    public class CalendarioSteps : BaseSteps
    {
        [Then(@"eu devo ser direcionado para página de ""(.*)""")]
        public void EntaoEuDevoSerDirecionadoParaPaginaDe(string cal)
        {
            GetInstance<CalendarioPage>().AcessarCalendario(cal);
        }

        [When(@"eu clico no evento ""(.*)""")]
        public void QuandoEuClicoNoEvento(string evento)
        {
            GetInstance<CalendarioPage>().ClicarEvento(evento);
        }

        [When(@"eu clico no botão Ao vivo")]
        public void QuandoEuClicoNoBotaoAoVivo()
        {
            GetInstance<CalendarioPage>().ClicarBotaoAoVivo();
        }

        [When(@"eu clico no botão Adicionar ao meu calendário")]
        public void QuandoEuClicoNoBotaoAdicionarAoMeuCalendario()
        {
            GetInstance<CalendarioPage>().ClicarBotaoAdicionarCalendario();
        }


    }
}