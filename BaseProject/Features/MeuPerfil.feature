#language: pt-BR

Funcionalidade:  Meu Perfil
                 Como usuario do sistema
				 devo conseguir alterar minhas preferências e dados pessoais 
				 Para deixar minha conta personalizada


Cenario: Alterar numero do celular
Dado que eu acesse o sistema
E eu logo por e-mail "testemedico@grr.la" e a senha "123456"
Então devo ver meu nome "Medico Teste" no menu profile
Quando eu clico no menu profile Logado para expandir
E eu clico em Meu Perfil
Então devo ser direcionado para pagina de Perfil
Quando eu clico em Minha conta
E eu altero o Celular para um numero valido
E eu clico em Salvar
Então devo visualizar a mensagem "Dados alterados com sucesso"