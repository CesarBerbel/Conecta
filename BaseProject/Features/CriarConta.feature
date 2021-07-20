#language: pt-BR
Funcionalidade: CriarConta
	Para garantir que a Criacao de Conta funciona
    Eu, como usuário do sistema
    Desejo Criar minha conta para ter acesso completo ao conteudo do sistema.

Cenario: Criar Conta  
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Criar Conta
Quando escolho tipo de HCP "Dentista (CRO)"
E escolho o Estado "BA"
E preencho o campo Número do registro com registro aleatório
E preencho o Email com email aleatório
E marco a opcao Li e concordo com os Termos e Condições
E eu clico em Continuar
E Eu preencho o campo Nome com "Doctor Angry"
E preencho o campo Sobrenome com "Birds"
E eu preencho o Celular com "7912345678"
E preencho o campo Adicionar Senha com "123456"
E preencho o campo Repetir Senha com "123456"
E clico em Finalizar
Entao devo ver a mensagem de conta criada com sucesso "Sua conta foi criada com sucesso!"