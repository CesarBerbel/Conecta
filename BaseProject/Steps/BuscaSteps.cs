using TechTalk.SpecFlow;
using ValTestAT;
using ValTestAT.Base;

namespace BaseProject.Steps
{
	[Binding]
    public class BuscaSteps : BaseSteps
    {
        [When(@"preencho o campo Buscar com ""(.*)""")]
        public void QuandoPreenchoOCampoBuscarCom(string palavra)
        {
            GetInstance<BuscaPage>().PreencherBusca(palavra);
        }

        [When(@"clico em Pesquisar")]
        public void QuandoClicoEmPesquisar()
        {
            GetInstance<BuscaPage>().ClicarEmPesquisar();
        }

        [Then(@"eu devo visualizar os registros ""(.*)""")]
        public void EntaoEuDevoVisualizarOsRegistros(string reg)
        {
            GetInstance<BuscaPage>().VerificarResultadoDaBusca(reg);
        }

        [When(@"eu clico em Busca no footer")]
        public void QuandoEuClicoEmBuscaNoFooter()
        {
            GetInstance<BuscaPage>().ClicarEmBuscaNoFooter();
        }

        [Then(@"eu devo visualizar a lista de A a Z com os Produtos ""(.*)""")]
        public void EntaoEuDevoVisualizarAListaDeAAZComOsProdutos(string list)
        {
            GetInstance<BuscaPage>().VerificarListaDeAaZ(list);
        }

        [Then(@"eu não devo visualizar o registro ""(.*)""")]
        public void EntaoEuNaoDevoVisualizarORegistro(string result)
        {
            GetInstance<BuscaPage>().VerificarBuscaSemResultado(result);
        }

        [Then(@"eu devo visualizar o registro ""(.*)""")]
        public void EntaoEuDevoVisualizarORegistro(string reg)
        {
            GetInstance<BuscaPage>().VerificarRegistroEspecifico(reg);
        }

        [When(@"eu clico no registro ""(.*)""")]
        public void QuandoEuClicoNoRegistro(string reg)
        {
            GetInstance<BuscaPage>().ClicarNoRegistro(reg);
        }

        [Then(@"eu não devo visualizar as páginas de ""(.*)""")]
        public void EntaoEuNaoDevoVisualizarAsPaginasDe(string pag)
        {
            GetInstance<BuscaPage>().VerificarVisibilidadePaginas(pag);
        }

        [Then(@"devo ver a seguinte mensagem ""(.*)""")]
        public void EntaoDevoVerASeguinteMensagemVingadores(string inv)
        {
            GetInstance<BuscaPage>().VerificarResultadoDaBuscaInvalida(inv);
        }
    }
}