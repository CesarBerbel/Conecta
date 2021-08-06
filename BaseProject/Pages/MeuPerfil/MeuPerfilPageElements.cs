using BaseProject.Steps;
using ValTestAT.Config;

namespace BaseProject.Pages.MeuPerfil
{
    partial class MeuPerfilPage
    {
        private readonly string BaseUrl = Configurations.URL + "/perfil";
        private readonly string MinhaConta = "//div[contains(text(),'Minha conta')]";
        private readonly string CampoCelular = "//input[@placeholder='Celular']";
        private readonly string CampoEmail = "email";
        private readonly string BotaoSalvar = "//button[@class='c-my-profile__save-container--btn']";
        private readonly string MsgAlteracao = "//span[@class='c-text c-text--branco']";
        private readonly string MsgValidacaoEmail = "//div[@class='c-my-profile__section-form-field grid-lg-12']//*[text()='{0}']";
        private readonly string MsgObrigatoriedade = "//span[text()='{0}']";
        private readonly string MsgValidacaoSenha = "//span[text()='{0}']";
        private readonly string MsgPersonalizacaoConta = "//p[@class='c-my-profile__section-title--error']";
        private readonly string BotaoAlterarSenha = "//button[normalize-space()='Alterar senha']";
        private readonly string BotaoPersonalizar = "//button[@class='c-base-modal-content__button']";
        private readonly string CampoSenha = "new_password";
        private readonly string CampoRepetirSenha = "new_password_confirmation";
        private readonly string BotaoCadastrar = "//div[@class='modal-change-password__form-buttons']//button";
        private readonly string Interesses = "//div[contains(@class,'c-select-list__container')]//li[contains(text(),'{0}')]";
        private readonly string EspecInteresse = "//div[@class='c-my-profile__section'][2]";
        private readonly string EspecPrimaria = "expertiseprimary";
        private readonly string EspecSecundaria = "expertisesecondary";
        private readonly string CampoEmpresa = "workplacetype";
        private readonly string CampoCidade = "//div[@name='Cidade']//div[@class='input-wrapper']//input";
        private readonly string CampoCidadeList = "//div[@class='dropdown-content']/div[contains(text(),'{0}')]";
        private readonly string CampoLocalOndeTrabalha = "//input[@placeholder='Local onde trabalha']";


    }
}
