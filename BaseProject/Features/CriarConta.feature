#language: pt-BR
Funcionalidade: CriarConta
	Para garantir que a Criacao de Conta funciona
    Eu, como usuário do sistema
    Desejo Criar minha conta para ter acesso completo ao conteudo do sistema.

Cenario: Criar Conta  
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Criar Conta
Quando preencho o Cadastro completo com "Dentista (CRO),BA,Auto,QA,7912345678,123456,123456"
Entao devo ver a mensagem de conta criada com sucesso "Sua conta foi criada com sucesso!"

Cenario: Tentar Criar Conta utilizando Número do registro ja cadastrado
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Criar Conta
Quando preencho os dados iniciais do Cadastro com "Dentista (CRO),BA,1111111,abcd@automacao.com" 
E preencho o campo email com "dentista01@teste.com"
E clico em Prosseguir
E preencho o campo Adicionar Senha com "123456"
E clico em Finalizar
Então devo ver meu nome "Dentista" na Home 

Cenario: Criar Conta utilizando Email ja cadastrado
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Criar Conta
Quando preencho os dados iniciais do Cadastro com "Dentista (CRO),BA,3921,maria@teste.com" 
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
Quando preencho o Cadastro completo com "Dentista (CRO),BA,Dentist,AutoQA,00000,123456,123456"
Entao devo ver as mensagens de erro "Celular inválido"

Cenario: Criar conta com usuario Validado (SoftLogin)
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Criar Conta
Quando preencho o Cadastro com registro e email aleatórios "Nutricionista (CRN),BA" 
Entao eu devo ver a mensagem de finalizacao de cadastro "Aproveitando seus dados precisamos apenas de quatro informações:"
Quando clico em Fechar
E eu clico no menu profile validado para expandir
E clico em Criar conta
E preencho o email aleatório
E clico em Logar
Entao eu devo ver a mensagem de finalizacao de cadastro "Aproveitando seus dados precisamos apenas de quatro informações:"
Quando preencho os dados finais do cadastro com "Nutri,AutoQA,79987165507,123456,123456"
Entao devo ver a mensagem de conta criada com sucesso "Sua conta foi criada com sucesso!"