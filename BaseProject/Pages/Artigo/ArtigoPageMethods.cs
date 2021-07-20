using ValTestAT.Base;

namespace ValTestAT
{
	partial class ArtigoPage : BasePage
	{
		public void AcessarArtigo(string url)
		{
			NavigateTo(BaseUrl + url);
			CheckForURL(BaseUrl + url);
		}

		public void VerificarMensagemConteudoExclusivo(string msg)
		{
			CheckElementText(FindByXPath(MensagemConteudoExclusivo), msg);
		}

		public void VerificarArtigo(string artigo)
		{

			CheckForURL(BaseUrl + artigo);
		}
	}
}