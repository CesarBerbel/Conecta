using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using ValTestAT.Base;

namespace ValTestAT
{
	partial class BuscaPage : BasePage
	{
        public void PreencherBusca(string palavra)
        {
            EnterTextInto(FindByName(CampoBusca), palavra);
        }

        public void ClicarEmPesquisar()
        {
            JClick(FindByXPath(LupaBuscar));
            
        }

        public void VerificarResultadoDaBusca(string reg)
        {
            CheckIfListMatch(ElementsByXPath(Registros), reg.Split(','));
        }

        public void VerificarListaDeAaZ(string list)
        {
            CheckIfListContainsText(FindByXPath(string.Format(RegistrosAaZ, list)), list);
        }

        public void ClicarEmBuscaNoFooter()
        {
            JClick(FindByXPath(CampoBuscaFooter));
           
        }

        public void VerificarBuscaSemResultado(string result)
        {
            CheckElementTextContains(FindByXPath(string.Format(ListaVazia, result)), result);

        }

        public void VerificarRegistroEspecifico(string reg)
        {
            CheckElementTextContains(FindByXPath(string.Format(RegistroUnico, reg)), reg);

        }
        public void ClicarNoRegistro(string reg)
        {
            Click(FindByXPath(string.Format(RegistroUnico, reg)));

        }

        public void VerificarVisibilidadePaginas(string pag)
        {
            //CheckIfElementNotExists(ElementsByXPath(PaginasProdutos, false));
            CheckIfElementNotExists(ElementsByXPath(string.Format(Paginas, pag), false));

        }
    }
}