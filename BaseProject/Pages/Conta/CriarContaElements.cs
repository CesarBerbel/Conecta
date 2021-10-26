namespace ValTestAT
{
	partial class CriarConta
	{
		private readonly string TipoHCP = "hcp-type";
		private readonly string UF = "uf";
		private readonly string NumeroRegistro = "sf-register-2";
		private readonly string CampoEmail = "//input[contains(@id,'email')]";
		private readonly string TermosCheckBox = "opt-in";
        private readonly string BotaoContinuar = "sf-continue-validation";
        public readonly string CampoNome = "sf-name";
		public readonly string CampoSobrenome = "sf-lastname";
		public readonly string CampoCelular = "sf-cellphone";
		public readonly string CampoAdicionarSenha = "sf-password";
		public readonly string CampoRepetirSenha = "sf-password-confirm";
		public readonly string MensagemSucesso = "//div[@class='c-text c-text--h4 c-modal-sf-hcp__subtitle']";
        public readonly string MensagemObrigatoria = "//div[contains(@class,'text-error') and text()!='']";
        public readonly string MensagemErro = "//*[@id='modal-soft-login']/div/div/div[2]/div[2]";
        public readonly string MensagemFinalCadastro = "//p[@class='c-text']";
		public readonly string ProSim = "sf-is-hcp";
        public readonly string BotaoDeixarParaDepois = "//button[@class='c-base-modal-content__button--link']";
	}
}