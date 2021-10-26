using OpenQA.Selenium;
using System;
using System.Threading;
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

        public void PreencherCelularAleatorio()
		{
            Random rdm = new Random();
            string numcel = "719871644" + rdm.Next(999).ToString();
            AlterarCelular(numcel);            
        }

        public void AlterarCelular(string numcel)
        {
            ReplaceTextInto(WaitTools.WaitForVisibility("xpath", CampoCelular), numcel);
        }

        public void ClicarSalvar()
        {
            Click(FindByXPath(BotaoSalvar));
        }

        public void VerificarMensagemAlteracao(string msg)
        {
            CheckIfListContainsText(FindByXPath(MsgAlteracao), msg);
        }

        public void ValidarMensagemEmail(string msg)
        {
            CheckIfListContainsText(FindByXPath(string.Format(MsgValidacaoEmail, msg)), msg);
        }

        public void ValidarObrigatoriedade(string msg)
        {
            CheckIfListContainsText(FindByXPath(string.Format(MsgObrigatoriedade, msg)), msg);
        }

        public void VerificarMensagemSenha(string msg)
        {
            CheckIfListContainsText(FindByXPath(string.Format(MsgValidacaoSenha, msg)), msg);
        }

        public void VerificarMensagemPersonalizacaoConta(string msg)
        {
            CheckIfListContainsText(FindByXPath(MsgPersonalizacaoConta), msg);
        }

        public void AlterarEmail(string email)
        {
            ReplaceTextInto(WaitTools.WaitForVisibility("name", CampoEmail), email);
        }

        public void PreencherEmailAleatorio()
        {
            string EmailAleatorio = DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString();
            AlterarEmail(EmailAleatorio + "@server.com");
        }

        public void VerificarVisibilidadeBotao()
        {
            CheckIfElementNotExists(ElementsByXPath(BotaoSalvar, false));
        }

        public void ClicarAlterarSenha()
        {
            JClick(FindByXPath(BotaoAlterarSenha));
        }

        public void PreencherSenha(string senha)
        {
            EnterTextInto(WaitTools.WaitForVisibility("name", CampoSenha), senha);
        }

        public void ConfirmarSenha(string senha)
        {
            EnterTextInto(FindByName(CampoRepetirSenha), senha);
        }

        public void ClicarCadastrar()
        {
            Click(FindByXPath(BotaoCadastrar));
        }

        public void ClicarEspecialidadeInteresses()
        {
            Click(WaitTools.WaitForVisibility("xpath", EspecInteresse));
        }

        public void SelecionarEspecialidadePrimaria(string primaria)
        {
            SelectDropDownValue(WaitTools.WaitForVisibility("id", EspecPrimaria), primaria);
        }

        public void SelecionarEspecialidadeSecundaria(string secundaria)
        {
            SelectDropDownValue(FindById(EspecSecundaria), secundaria);
        }

        public void ClicarPersonalizar()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            JClick(FindByXPath(BotaoPersonalizar));
        }

        public void ClicarInteresses(string interesse)
        {
            JClick(FindByXPath(string.Format(Interesses, interesse)));
        }

        public void SelecionarEmpresaOndeTrabalha(string empresa)
        {
            SelectDropDownValue(WaitTools.WaitForVisibility("id", CampoEmpresa), empresa);
        }

        public void PreencherCidade(string cid)
        {
             Thread.Sleep(TimeSpan.FromSeconds(1));
             EnterTextInto(FindByXPath(CampoCidade), cid);

            //EnterTextInto(WaitTools.WaitForVisibility("xpath", CampoCidade), cid);

            Thread.Sleep(TimeSpan.FromSeconds(1));
            PerformClick(FindByXPath(CampoCidade));
        }

        public void SelecionarCidade(string cid)
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));

            PerformClick(FindByXPath(string.Format(CampoCidadeList, cid)));
        }

        public void VerificarVisibilidadeCampoCidade()
        {
            CheckIfElementNotExists(ElementsByXPath(CampoCidade, false));
        }

        public void PreencherNomeLocalTrabalho(string localTrab)
        {
            EnterTextInto(FindByXPath(CampoLocalOndeTrabalha), localTrab);           
        }
    }
}
