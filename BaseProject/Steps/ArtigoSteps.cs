using TechTalk.SpecFlow;
using ValTestAT;
using ValTestAT.Base;

namespace BaseProject.Steps
{
	[Binding]
    public class ArtigoSteps : BaseSteps
    {
		[Given(@"que eu acesso artigo ""(.*)""")]
		public void DadoEuAcessoOArtigo(string artigo)
		{
            GetInstance<ArtigoPage>().AcessarArtigo(artigo);
            GetInstance<LoginModal>().RealizarPreLogin();
		}

		[When(@"eu acesso o artigo ""(.*)""")]
		public void QuandoEuAcessoOArtigo(string artigo)
		{
			GetInstance<ArtigoPage>().AcessarArtigo(artigo);
		}

		[Then(@"devo ver a mensagem ""(.*)""")]
		public void EntaoDevoVerAMensagem(string msg)
		{
			GetInstance<ArtigoPage>().VerificarMensagemConteudoExclusivo(msg);
		}

		[When(@"eu vejo a mensagem ""(.*)""")]
		public void QuandoEuVejoAMensagem(string msg)
		{
			GetInstance<LoginModal>().VerificarMensagemContaJaCriada(msg);
		}

		[Then(@"eu visualizo o artigo ""(.*)""")]
		public void EntaoEuVisualizoOArtigo(string artigo)
		{
			GetInstance<ArtigoPage>().VerificarArtigo(artigo);
		}

        [Then(@"devo ver a mensagem de acesso exclusivo ""(.*)""")]
        public void EntaoDevoVerAMensagemDeAcessoExclusivo(string msg)
        {
            GetInstance<ArtigoPage>().VerificarMsgConteudoExclusivoOops(msg);
        }

        [When(@"eu clico em Ir para a página Inicial")]
        public void QuandoEuClicoEmIrParaAPaginaInicial()
        {
            GetInstance<ArtigoPage>().ClicarVoltarHome();
        }

       // [Then(@"eu devo ser direcionado para página de Favoritos")]
       // public void EntaoEuDevoSerDirecionadoParaPaginaDeFavoritos()
       // {
       //     GetInstance<FavoritosPage>().VerificarEstaEmFavoritos();
       // }

       // [When(@"eu clico em Remover item dos favoritos")]
       // public void QuandoEuClicoEmRemoverItemDosFavoritos()
       // {
      //      GetInstance<FavoritosPage>().RemoverFavoritos();
       // }
    }
}