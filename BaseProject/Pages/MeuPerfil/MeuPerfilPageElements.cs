﻿using ValTestAT.Config;

namespace BaseProject.Pages.MeuPerfil
{
    partial class MeuPerfilPage
    {
        private readonly string BaseUrl = Configurations.URL + "/perfil";

        private readonly string MinhaConta = "//div[contains(text(),'Minha conta')]";

        private readonly string CampoCelular = "//input[@placeholder='Celular']";

        private readonly string BotaoSalvar = "//button[@class='c-my-profile__save-container--btn']/span";

        private readonly string MsgAlteracao = "//span[@class='c-text c-text--branco']";




    }
}
