using ValTestAT.Config;

namespace ValTestAT
{
	partial class ArtigoPage
	{
		private readonly string BaseUrl = Configurations.URL + "/artigos";
		private readonly string MensagemConteudoExclusivo = "//div[@id='modal-soft-login']//h2";
        private readonly string MsgConteudoExclusivoOops = "//div[@class='c-text c-text--text-left c-text--wraped']";
        private readonly string BotaoVoltarHome = "btnHome";
        private readonly string UrlFavoritos = Configurations.URL + "/favoritos";
    }
}
