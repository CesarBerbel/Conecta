using System;
using System.Threading;
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
            Click(FindById(RejeitarCookies));
        }
        public void EscolherLoginPorEmail()
		{
			SelectRadioButton(FindById(PorEmail));
		}

        public void PreencherRegistro(string numRegistro)
        {
            EnterTextInto(FindById(CampoNumRegistro), numRegistro);
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

		public void LogarPorEmail(string nome, string email, string senha)
		{			
			EscolherLoginPorEmail();
			PreencherEmail(email);
			PreencherSenha(senha);
			ClicarLogar();
            GetInstance<HomePage>().VerificarNomeMensagem(nome);            
        }

        public void LogarComEmail(string email, string senha)
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

        public void LogarPorRegistro(string user)
        {
            string[] userInfo = user.Split(',');
            GetInstance<CriarConta>().SelecionarTipoHCP(userInfo[0]);
            GetInstance<CriarConta>().SelecionarEstado(userInfo[1]);
            PreencherRegistro(userInfo[2]);
            GetInstance<CriarConta>().PreencherAdcionarSenha(userInfo[3]);
            ClicarLogar();
        
        }
                
        public void ClicarEmProsseguir()
		{
			Click(FindById(BotaoProsseguir));
		}

		public void VerificarMensagemContaJaCriada(string msg)
		{
			CheckIfListContainsText(FindByCss(MensagemContaJaCriada), msg);
		}
        public void VerificarMensagemValidacao(string msg)
        {
            CheckIfListMatch(ElementsByXPath(MensagemValidacao), msg.Split(','));
        }

        public void ClicarEmDeixarParaDepois()
        {
            Click(FindById(BotaoDeixarParaDepois));
        }
        public void ClicarEsqueceuSenha()
        {
            Click(FindById(LinkEsqueciSenha));
        }

        public void VerificarTituloModalEsqueciSenha(string msg)
        {
            CheckElementTextContains(FindByXPath(ModalEsqueciSenha), msg);

        }

        public void ClicarReenviarEmail()
        {
            Click(FindById(LinkReenviarEmail));
        }

        public void ClicarNaoTenhoAcessoEmail()
        {
            Click(FindByXPath(LinkNaoTenhoAcessoEmail));
        }

        public void VerificarTelefone(string tel)
        {
            CheckElementTextContains(FindByXPath(LabelTelefone), tel);

        }

        public void PreencherCelular(string cel)
        {
            EnterTextInto(FindById(CampoCelular), cel);
        }
        public void ClicarFecharModal()
        {
            Click(FindByXPath(IconeFechar));
        }

    }
}