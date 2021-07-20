using ValTestAT.Config;

namespace ValTestAT
{
	partial class FavoritosPage
	{
		private readonly string BaseUrl = Configurations.URL + "/favoritos";
		private readonly string ItemRemover = "//div[@class='c-favorites__list-item']//i";
	}
}
