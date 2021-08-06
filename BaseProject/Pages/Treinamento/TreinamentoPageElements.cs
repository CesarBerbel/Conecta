using ValTestAT.Config;

namespace ValTestAT
{
	partial class TreinamentoPage
	{
		private readonly string BaseUrl = Configurations.URL + "/treinamentos";
		private readonly string MenuTreinamento = "//i[@class='icon menu-profile__indicator icon-chevron-aberto']//following-sibling::div//a[text()='Treinamentos']";
        private readonly string LinkCertificado = "//a[@target='_black']";
        private readonly string BotaoAbrirModuloDermatite = "//button[normalize-space()='Abrir']";
        private readonly string BotaoAbrirModuloComunicacaoEfic = "//div[3]//div[2]//div[1]//div[3]//div[1]//footer[1]//button[1]";
        private readonly string BotaoProximo = "//button[@class='c-survey__button c-survey__button--active']";
        private readonly string BaixarPdf = "//a[@class='c-icon--pdf']";
        private readonly string IconeModuloConcluido = "//p[@class='icon icon-check']";
        private readonly string RespostaQuizz = "//li[{0}]//span[1]";
        private readonly string RespostaPesquisaSatisfacao = "//div[contains(@class,'c-survey__questions')]//div[{0}]//input[@value='{1}']";
        private readonly string BotaoEnviarResposta = "//button[@class='c-quizz-form-container-vert__button']";
        private readonly string BotaoProximaPergunta = "//button[@class='c-quizz-form-container-vert__button']";
        private readonly string MensagemRespCerta = "//span[@class='c-quizz-form-container-vert__right']";
        private readonly string MensagemModuloCompleto = "//h3[@class='c-text--h3']/span";
        private readonly string MensagemCursoCompleto = "//span[@class='c-text c-text--branco']";
        private readonly string MensagemPesqSatisf = "//h1[@class='c-text c-text--h1 c-text--h1-event-desk c-text--bold']";
        private readonly string IconeFecharModulo = "//div[@class='classes']//div[@class='c-modal__close icon icon-close']";




    }
}
