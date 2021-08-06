namespace ValTestAT
{
	partial class BuscaPage
	{       
        private readonly string CampoBusca = "search-text";
        private readonly string LupaBuscar = "//input[@name='search-text']/following-sibling::i";
        private readonly string Registros = "//div[contains(@class,'modal-search__result-area')]//a";
        private readonly string RegistrosAaZ = "//div[contains(@class,'modal-search__category modal-search--no-padding')]/div[text()='{0}']";
        private readonly string RegistroUnico = "//a[contains(@href,'{0}')]";
        private readonly string Paginas = "//div[contains(@class,'modal-search__category')]/div[text()='{0}']";           
        private readonly string ListaVazia = "//div[text()='Nenhum resultado para \"{0}\"']";
        private readonly string CampoBuscaFooter = "//button[text()='Busca']";

    }
}