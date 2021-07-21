using System;
using ValTestAT.Base;
using ValTestAT.Tools;

namespace BaseProject.Pages.MeuPerfil
{
	partial class MeuPerfilPage : BasePage
    {
        public void VerificarPaginaPerfil()
        {
            CheckForURL(BaseUrl);
        }

        public void ClicarMinhaConta()
        {
            Click(FindByXPath(MinhaConta));
        }

        public void PreencherCelular(string cel)
        {
            EnterTextInto(FindByXPath(CampoCelular), cel);
        }

        public void PreencherCelularAleatorio()
		{
            Random rdm = new Random();
            string numcel = rdm.Next(999).ToString();

			ReplaceTextInto(WaitTools.WaitForVisibility("xpath", CampoCelular), "719871644" + numcel);
        }

        public void ClicarSalvar()
        {
            Click(FindByXPath(BotaoSalvar));
        }

        public void VerificarMensagemAlteracao(string msg)
        {
            CheckElementText(FindByXPath(MsgAlteracao), msg);
        }
    }
}
