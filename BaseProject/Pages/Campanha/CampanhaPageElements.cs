using ValTestAT.Config;

namespace ValTestAT
{
	partial class CampanhaPage
	{
		private readonly string BaseUrl = Configurations.URL + "/campanha";
        private readonly string MsgContaIdentificada = "//div[@class='c-text c-text--h3 c-modal-sf-hcp__title']";
        private readonly string BotaoFechar = "//span[@class='icon icon-close icon--hover-fade c-base-modal-content__icon']";
        private readonly string FecharModal = "/ html / body / div[4] / div[2] / div / div[1] / button / img";

    }
}
