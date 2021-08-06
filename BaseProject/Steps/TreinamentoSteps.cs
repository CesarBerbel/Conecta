using TechTalk.SpecFlow;
using ValTestAT;
using ValTestAT.Base;

namespace BaseProject.Steps
{
	[Binding]
    public class TreinamentoSteps : BaseSteps
    {
        [When(@"eu clico em Deixar para depois")]
        public void QuandoEuClicoEmDeixarParaDepois()
        {
            GetInstance<CriarConta>().ClicarDeixarParaDepois();
        }
        [When(@"eu clico em Treinamentos")]
        public void QuandoEuClicoEmTreinamentos()
        {
            GetInstance<TreinamentoPage>().ClicarMenuTreinamento();
        }

        [When(@"eu acesso o Treinamento ""(.*)""")]
        public void QuandoEuAcessoOTreinamento(string treinamento)
        {
            GetInstance<TreinamentoPage>().AcessarTreinamento(treinamento);
        }

        [When(@"clico em Fazer download do Certificado")]
        public void QuandoClicoEmFazerDownloadDoCertificado()
        {
            GetInstance<TreinamentoPage>().ClicarBaixarCertificado();
        }

        [Then(@"eu devo visualizar o arquivo ""(.*)"" em outra janela")]
        public void EntaoEuDevoVisualizarOArquivoEmOutraJanela(string certificado)
        {
            GetInstance<TreinamentoPage>().VisualizarCertificado(certificado);
        }

        [When(@"clico em Abrir Módulo")]
        public void QuandoClicoEmAbrirModulo()
        {
            GetInstance<TreinamentoPage>().ClicarAbrirModuloDermatite();            
        }

        [When(@"clico para baixar pdf")]
        public void QuandoClicoParaBaixarPdf()
        {
            GetInstance<TreinamentoPage>().ClicarBaixarPdf();
        }

        [Then(@"o conteúdo é marcado como concluído")]
        public void EntaoOConteudoEMarcadoComoConcluido()
        {
            GetInstance<TreinamentoPage>().VerificarConclusaoModulo();
        }
        

        [When(@"Clico em Enviar resposta")]
        public void QuandoClicoEmEnviarResposta()
        {
            GetInstance<TreinamentoPage>().ClicarEnviarResposta();
        }

        [Then(@"eu devo ver a mensagem de sucesso ""(.*)""")]
        public void EntaoEuDevoVerAMensagemDeSucesso(string msg)
        {
            GetInstance<TreinamentoPage>().VerificarMensagemResposta(msg);
        }

        
        [Then(@"devo ver a mensagem: ""(.*)""")]
        public void EntaoDevoVerAMensagem(string msg)
        {
            GetInstance<TreinamentoPage>().VerificarMensagemModuloCompleto(msg);
        }

        [When(@"eu clico em Proxima pergunta")]
        public void QuandoEuClicoEmProximaPergunta()
        {
            GetInstance<TreinamentoPage>().ClicarProximaPergunta();
        }

        [When(@"eu clico em fechar")]
        public void QuandoEuClicoEmFechar()
        {
            GetInstance<TreinamentoPage>().ClicarFecharModulo();
        }

        [Then(@"devo ver a mensagem de conclusão de curso ""(.*)""")]
        public void EntaoDevoVerAMensagemDeConclusaoDeCurso(string msg)
        {
            GetInstance<TreinamentoPage>().VerificarMensagemConclusaoCurso(msg);
        }

        [Then(@"eu devo ver a mensagem: ""(.*)""")]
        public void EntaoEuDevoVerAMensagem(string msg)
        {
            GetInstance<TreinamentoPage>().VerificarMensagemPesquisaSatisfacao(msg);
        }


        [When(@"clico em Abrir o Módulo Comunicação Eficiente")]
        public void QuandoClicoEmAbrirOModuloComunicacaoEficiente()
        {
            GetInstance<TreinamentoPage>().ClicarAbrirModuloComunicacao();
        }

        [When(@"clico em Enviar")]
        [When(@"clico em Proximo")]
        public void QuandoClicoEmProximo()
        {
            GetInstance<TreinamentoPage>().ClicarBotaoProximo();
        }


        [When(@"respondo ""(.*)"" na pergunta ""(.*)""")]
        public void QuandoRespondoNaPergunta(string resposta, string pergunta)
        {
            GetInstance<TreinamentoPage>().ClicarRespostaQuizz(pergunta, resposta);
        }

        [When(@"respondo ""(.*)"" na questao ""(.*)""")]
        public void QuandoRespondoNaQuestao(string resposta, string questao)
        {
            GetInstance<TreinamentoPage>().ClicarRespostaPesquisaSatisfacao(questao, resposta);
        }

    }
}