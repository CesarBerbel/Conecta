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
            DriverTools.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(CampoCelular)));
            FindByXPath(CampoCelular).Clear();
            EnterTextInto(FindByXPath(CampoCelular), cel);
        }

        public void PreencherCelularAleatorio()
        {           
            DriverTools.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(CampoCelular)));
            FindByXPath(CampoCelular).Clear();
            Random rdm = new Random();
            string numcel = rdm.Next(999).ToString();
            PreencherCelular("719871666" + numcel);
        }

        public void ClicarSalvar()
        {
            Click(FindByXPath(BotaoSalvar));
        }

        public void VerificarMensagemAlteracao(string msg)
        {
            CheckElementText(FindByXPath(MsgAlteracao), msg);
        }

        //public void ValidarMensagemEmail(string msg)
        //{
        //    CheckElementText(FindByXPath(MsgValidacaoEmail), msg);
        //}

        public void PreencherEmail(string email)
        {
            DriverTools.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(Email)));
            FindByName(Email).Clear();
            EnterTextInto(FindByName(Email), email);
        }

        public void PreencherEmailAleatorio()
        {
            DriverTools.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(Email)));
            FindByName(Email).Clear();
            string EmailAleatorio = DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString();
            PreencherEmail(EmailAleatorio + "@server.com");
        }

        //public void VerificarVisibilidadeBotao()
        //{
        //    CheckIfElementNotExists(FindByXPath(BotaoSalvar), "Botão visível na página");
        //}
    }
}
