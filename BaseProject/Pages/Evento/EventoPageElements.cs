using ValTestAT.Config;

namespace ValTestAT
{
	partial class EventoPage
	{
		private readonly string BaseUrl = Configurations.URL + "/eventos";
        private readonly string LinkCalendario = "//button[@class='c-button-schedule--basic']";
        private readonly string BotaoCalendario = "//button[contains(text(),'{0}')]";
        private readonly string BotaoAdicionado = "//span[normalize-space()='Adicionado']";        
        private readonly string OpcaoNoLinkSalvar = "//li[normalize-space()='{0}']";
        private readonly string BotaoAoVivo = "//div[@class='c-button-schedule c-button-schedule--live']/span";

    }
}
