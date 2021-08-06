namespace ValTestAT
{
	partial class HomePage
	{
		private readonly string ProfileMenu = "//div[@class='menu-profile menu-profile--avatar']";
		private readonly string ProfileMenuLogado = "//div[@class='menu-profile menu-profile--logged']";
        private readonly string ProfileMenuSoftLogin = "//div[@class='grid-lg-5 c-pb-0 c-navbar__area-after c-navbar__area-logged c-text--text-right']/div";
		private readonly string BotaoEntrar = "btnLogin";
        private readonly string BotaoCriarConta = "btnSignUp";
        private readonly string BotaoCriarContaValidado = "//div[@class='menu-profile menu-profile--open menu-profile--verified menu-profile--avatar']//a[1]";
        private readonly string MenuEncerrarSessao = "//a[@class='c-text menu-profile__panel-item menu-profile__panel-item--link menu-profile__panel-item--danger menu-profile__panel-item--text-left']";
        private readonly string MensagemBoasVindas = "//span[contains(text(),'{0}')]";        
        private readonly string ItensSalvosLink = "//a[@class='c-text menu-profile__panel-item menu-profile__panel-item--link menu-profile__panel-item--text-left']";
		private readonly string MenuMeuPerfil = "Meu Perfil";
        private readonly string MenuCalendario = "//p[text()='{0}']";
        private readonly string MenuBusca = "//p[contains(@class,'c-navbar__item c-text c-text--underline c-ml-40')]";

        
    }
}