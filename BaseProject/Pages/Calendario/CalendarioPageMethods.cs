using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using ValTestAT.Base;

namespace ValTestAT
{
	partial class CalendarioPage : BasePage
	{
        public void AcessarCalendario(string cal)
        {
            Assert.IsTrue(DriverContext.Driver.Url.Contains(cal));
        }

        public void ClicarEvento(string evento)
        {
            JClick(FindByXPath(string.Format(LinkEvento, evento)));
        }

        public void ClicarBotaoAoVivo()
        {
            JClick(FindByXPath(BotaoAoVivo));
        }

        public void ClicarBotaoAdicionarCalendario()
        {
            JClick(FindByXPath(BotaoAdicionarCal));
        }
    }
}