using ValTestAT.Base;

namespace ValTestAT
{
	partial class LoginModal : BasePage
	{
		public void RealizarPreLogin()
		{
			EnterTextInto(FindByName(PreLoginNome), "sanoficonecta");
			EnterTextInto(FindByName(PreLoginSenha), "previewconecta");
			Click(FindByXPath(PreLoginEnviar));
		}

		public void EscolherLoginPorEmail()
		{
			SelectRadioButton(FindById(PorEmail));
		}

		public void PreencherEmail(string email)
		{
			EnterTextInto(FindByXPath(CampoEmail), email);
		}

		public void PreencherSenha(string senha)
		{
			EnterTextInto(FindByXPath(CampoSenha), senha);
		}

		public void ClicarLogar()
		{
			Click(FindById(BotaoLogar));
		}

		public void LogarPorEmail(string email, string senha)
		{			
			EscolherLoginPorEmail();
			PreencherEmail(email);
			PreencherSenha(senha);
			ClicarLogar();
		}

		public void LogarValidacao(string email, string senha)
		{
			PreencherEmail(email);
			ClicarEmProsseguir();
			PreencherSenha(senha);
			ClicarLogar();
		}

		public void ClicarEmProsseguir()
		{
			Click(FindById(BotaoProsseguir));
		}

		public void VerificarMensagemContaJaCriada(string msg)
		{
			CheckElementText(FindByCss(MensagemContaJaCriada), msg);
		}
	}
}