using ValTestAT.Base;

namespace ValTestAT
{
	partial class CampanhaPage : BasePage
	{
		public void AcessarCampanha(string url)
		{
			NavigateTo(BaseUrl + url);
			CheckForURL(BaseUrl + url);
		}
	}
}