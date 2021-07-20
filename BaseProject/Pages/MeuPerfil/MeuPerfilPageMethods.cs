using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
                      
            DriverTools.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(CampoCelular)));
            FindByXPath(CampoCelular).Clear();
            Random rdm = new Random();
            string numcel = rdm.Next(999).ToString();
            PreencherCelular("719871644" + numcel);
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
