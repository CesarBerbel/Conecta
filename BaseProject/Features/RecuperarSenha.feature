#language: pt-BR
Funcionalidade: Recuperar Senha
                Para garantir que a recuperacao de senha funciona
                Eu, como usuário já cadastrado
                Desejo recuperar minha senha para continuar tendo acesso ao sistema.


Cenario: Recuperar Senha
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
Quando eu clico em Entrar
E clico em Esqueceu sua senha?
E escolho o Estado "SC"
E preencho o campo Número do registro com "11655"
E clico em Prosseguir
Entao eu devo ver a tela de envio de senha com o titulo "Esqueci minha senha"

Cenario: Tentar recuperar senha utilizando Número do registro invalido
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
Quando eu clico em Entrar
E clico em Esqueceu sua senha?
E escolho o Estado "TO"
E preencho o campo Número do registro com "7777"
E clico em Prosseguir
Entao devo ver a mensagem de erro do login "Registro não localizado"

Cenario: Reenviar email de recuperacao de senha
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
Quando eu clico em Entrar
E clico em Esqueceu sua senha?
E escolho o Estado "SC" 
E preencho o campo Número do registro com "11655"
E clico em Prosseguir
Entao eu devo ver a tela de envio de senha com o titulo "Esqueci minha senha"
Quando eu clico em Não recebeu? Reenviar email
Entao eu devo ver a tela de envio de senha com o titulo "Esqueci minha senha"

Cenario: Alterar email de recuperacao de senha
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
Quando eu clico em Entrar
E clico em Esqueceu sua senha?
E escolho tipo de HCP "Farmaceutico (CRF)"
E escolho o Estado "RS"
E preencho o campo Número do registro com "1234"
E clico em Prosseguir
Entao eu devo ver a tela de envio de senha com o titulo "Esqueci minha senha"
Quando eu clico em Não tenho mais acesso a este email
Entao eu devo ver o final do telefone "7777"
Quando eu preencho o campo Celular com "48997777777"
E eu preencho o campo Novo email com "medicorenovaemail@servidor.com"
E clico em Habilitar novo email 
Entao eu devo ver a tela de envio de senha com o titulo "Esqueci minha senha"
 
Cenario: Tentar alterar email de recuperacao de senha utilizando Email invalido
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
Quando eu clico em Entrar
Quando clico em Esqueceu sua senha?
E escolho tipo de HCP "Farmaceutico (CRF)"
E escolho o Estado "RS"
E preencho o campo Número do registro com "1234"
E clico em Prosseguir
Entao eu devo ver a tela de envio de senha com o titulo "Esqueci minha senha"
Quando eu clico em Não tenho mais acesso a este email
Entao eu devo ver o final do telefone "7777"
Quando eu preencho o campo Celular com "48997777777"
Quando eu preencho o campo Novo email com "abc123.com"
E clico em Habilitar novo email
Entao devo ver as mensagens de erro "Email inválido"

Cenario: Tentar alterar email de recuperacao de senha utilizando Email ja existente
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
Quando eu clico em Entrar
Quando clico em Esqueceu sua senha?
E escolho tipo de HCP "Farmaceutico (CRF)"
E escolho o Estado "RS"
E preencho o campo Número do registro com "1234"
E clico em Prosseguir
Entao eu devo ver a tela de envio de senha com o titulo "Esqueci minha senha"
Quando eu clico em Não tenho mais acesso a este email
Entao eu devo ver o final do telefone "7777"
Quando eu preencho o campo Celular com "48997777777"
Quando eu preencho o campo Novo email com "maria@teste.com"
E clico em Habilitar novo email
Entao devo ver as mensagens de erro "Já existe um usuário com este e-mail"

Cenario: Verificar obrigatoriedade dos campos ao Recuperar senha
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
Quando eu clico em Entrar
Quando clico em Esqueceu sua senha?
E clico em Prosseguir
Entao devo ver as mensagens de erro "Escolher Estado,Favor informar seu número de registro"