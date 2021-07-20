using ValTestAT.Base;

namespace ValTestAT
{
	partial class HomePage : BasePage
	{
		public void ClicarNoMenuProfile()
		{
			Click(FindByXPath(ProfileMenu));
		}

		public void ClicarEntrar()
		{
			Click(FindById(BotaoEntrar));
		}

		public void VerificarNomeMensagem(string nome)
		{
			CheckElementTextContains(FindByXPath(MensagemBoasVindas), nome);
		}

		public void ClicarItensSalvos()
		{
			Click(FindByXPath(ItensSalvosLink));
		}

		public void ClicarNoMenuProfileLogado()
		{
			Click(FindByXPath(ProfileMenuLogado));
		}

		public void ClicarCriarConta()
		{
			Click(FindById(BotaoCriarConta));
		}

        public void ClicarMenuMeuPerfil()
        {
            Click(FindByPartialLinkText(MenuMeuPerfil));
        }
	}
}