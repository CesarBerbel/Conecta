using ValTestAT.Base;

namespace ValTestAT
{
	partial class FavoritosPage : BasePage
	{
		public void VerificarEstaEmFavoritos()
		{
			CheckForURL(BaseUrl);
		}

		public void RemoverFavoritos()
		{
			Click(FindByXPath(ItemRemover));
		}
	}
}