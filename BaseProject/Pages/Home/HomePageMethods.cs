using ValTestAT.Base;

namespace ValTestAT
{
	partial class HomePage : BasePage
	{
		public void ClicarNoMenuProfile()
		{
			Click(FindByXPath(ProfileMenu));
		}

        public void ClicarMenuProfileSoftlogin()
        {
            Click(FindByXPath(ProfileMenuSoftLogin));
        }

        public void ClicarEntrar()
		{
			Click(FindById(BotaoEntrar));
		}

        public void ClicarMenuMeuPerfil()
        {
            Click(FindByPartialLinkText(MenuMeuPerfil));
        }

        public void ClicarEncerrarSessao()
        {
            Click(FindByXPath(MenuEncerrarSessao));
        }

        public void VerificarNomeMensagem(string nome)
		{
            CheckElementTextContains(FindByXPath(string.Format(MensagemBoasVindas, nome)), nome);
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
        public void ClicarCriarContaValidado()
        {
            Click(FindByXPath(BotaoCriarContaValidado));
        }
        public void ClicarCalendario(string cal)
        {
            Click(FindByXPath(string.Format(MenuCalendario, cal)));
        }

        public void ClicarMenuBusca()
        {
            Click(FindByXPath(MenuBusca));
        }
    }
}