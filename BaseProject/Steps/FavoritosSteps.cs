using TechTalk.SpecFlow;
using ValTestAT;
using ValTestAT.Base;

namespace BaseProject.Steps
{
	[Binding]
    public class FavoritosSteps : BaseSteps
    {
		[Then(@"eu devo ser direcionado para página de Favoritos")]
		public void EntaoEuDevoSerDirecionadoParaPaginaDeFavoritos()
		{ 
			GetInstance<FavoritosPage>().VerificarEstaEmFavoritos();
		}

		[When(@"eu clico em Remover item dos favoritos")]
		public void QuandoEuClicoEmRemoverItemDosFavoritos()
		{
			GetInstance<FavoritosPage>().RemoverFavoritos();
		}
	}
}