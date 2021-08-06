#language: pt-BR
Funcionalidade: Logar no sistema
                Para garantir que o login funciona
                Eu, como usuário já cadastrado
                Desejo me logar no sistema para ter acesso ao conteúdo para meu usuário.

Cenario: Logar no sistema com Número do registro
Dado que eu acesse o sistema
Quando eu logo pelo registro com "Medico (CRM),BA,4163,123456"
Então devo ver meu nome "Doctor" na Home 

 
Cenario: Realizar Login no sistema utilizando Email
Dado que eu acesse o sistema
E eu logue como "Doctor" com o e-mail "medico04@teste.com" e a senha "123456"
Então devo ver meu nome "Doctor" na Home 
Quando eu clico no menu profile Logado para expandir
E eu clico em Encerrar Sessao
Entao eu devo ser direcionado para Home deslogada

Cenario: Tentar Logar no sistema utilizando dados invalido 
Dado que eu acesse o sistema
Quando eu logo pelo registro com "Medico (CRM),TO,6666,1946852"
Então devo ver a mensagem de erro do login "Documento e/ou senha inválidos"
Quando eu logo pelo email com "nuumexiste@nuncavi.com" e "1946852"
Então devo ver a mensagem de erro do login "E-mail e/ou senha inválidos"

Cenario: Verificar obrigatoriedade dos campos no Login
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
Quando eu clico em Entrar
E clico em Logar
Então devo ver as mensagens de erro "Escolher Estado,Favor informar seu número de registro,Favor informar sua senha"
Quando Eu escolho o login por email
E clico em Logar
Então devo ver as mensagens de erro "Email inválido,Favor informar sua senha"