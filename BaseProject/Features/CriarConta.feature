#language: pt-BR
Funcionalidade: CriarConta
	Para garantir que a Criacao de Conta funciona
    Eu, como usuário do sistema
    Desejo Criar minha conta para ter acesso completo ao conteudo do sistema.

Cenario: Criar Conta  
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Criar Conta
Quando preencho o Cadastro completo com "Nutricionista (CRN),BA,Auto,QA,7912345678,123456,123456"
Entao devo ver a mensagem de conta criada com sucesso "Sua conta foi criada com sucesso!"

Cenario: Tentar Criar Conta utilizando Número do registro ja cadastrado
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Criar Conta
Quando preencho os dados iniciais do Cadastro com "Médico (CRM),BA,4163,abc12345@testing.com" 
Entao devo ver a mensagens de erro "O CRM BA4163 está vinculado ao email:"

Cenario: Criar Conta utilizando Email ja cadastrado
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Criar Conta
Quando preencho os dados iniciais do Cadastro com "Nutricionista (CRN),BA,1234567,medico04@teste.com" 
Entao devo ver as mensagens de erro "Este email já está cadastrado"

Cenario: Tentar criar conta utilizando um Numero de registro invalido
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Criar Conta
Quando preencho os dados iniciais do Cadastro com "Médico (CRM),BA,1234567,abc12345@testing.com" 
Entao devo ver as mensagens de erro "CRM inválido no CFM"

Cenario: Verificar obrigatoriedade dos campos ao criar conta
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Criar Conta
Quando clico em Continuar
Entao devo ver as mensagens de erro "Escolher Estado,Favor informar seu número de registro,Email inválido,Marcar o aceite"

Cenario: Tentar criar conta com Celular invalido
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Criar Conta
Quando preencho o Cadastro completo com "Nutricionista (CRN),BA,Auto,QA,99123,123456,123456"
Entao devo ver as mensagens de erro "Celular inválido"

Cenario: Criar conta com usuario Validado (SoftLogin)
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Criar Conta
Quando preencho o Cadastro com registro e email aleatórios "Nutricionista (CRN),BA" 
Entao eu devo ver a mensagem de finalizacao de cadastro "Para prosseguirmos, precisamos de mais algumas informações suas. Não se preocupe, levará menos de 1 minuto!"
Quando clico em Fechar
E eu clico no menu profile validado para expandir
E clico em Criar conta
E preencho o email aleatório
E clico em Logar
Entao eu devo ver a mensagem de finalizacao de cadastro "Para prosseguirmos, precisamos de mais algumas informações suas. Não se preocupe, levará menos de 1 minuto!"
Quando preencho os dados finais do cadastro com "Nutri,AutoQA,79987165507,123456,123456"
Entao devo ver a mensagem de conta criada com sucesso "Sua conta foi criada com sucesso!"