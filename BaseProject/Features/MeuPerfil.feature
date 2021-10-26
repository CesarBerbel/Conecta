#language: pt-BR

Funcionalidade:  Meu Perfil
                 Como usuario do sistema
				 devo conseguir alterar minhas preferências e dados pessoais 
				 Para deixar minha conta personalizada


Cenario: Alterar numero do celular
Dado que eu acesse o sistema
E eu logue como "Medico" com o e-mail "testemedico@grr.la" e a senha "123456"
Quando eu clico no menu profile Logado para expandir
E eu clico em Meu Perfil
Então devo ser direcionado para pagina de Perfil
Quando eu clico em Minha conta
E eu altero o Celular para um numero valido
E eu clico em Salvar
Então devo visualizar a mensagem "Dados alterados com sucesso"

Cenario: Alterar numero do celular utilizando um numero inválido
Dado que eu acesse o sistema
E eu logue como "Medico" com o e-mail "testemedico@grr.la" e a senha "123456"
Quando eu clico no menu profile Logado para expandir
E eu clico em Meu Perfil
Então devo ser direcionado para pagina de Perfil
Quando eu clico em Minha conta 
E eu altero o Celular para "00111111111"
Então eu nao devo ver o botao Salvar  

Cenario: Alterar email
Dado que eu acesse o sistema
E eu logue como "Maria" com o e-mail "maria@teste.com" e a senha "123456"
Quando eu clico no menu profile Logado para expandir
E eu clico em Meu Perfil
Então devo ser direcionado para pagina de Perfil
Quando eu clico em Minha conta 
E altero o Email com email válido
E eu clico em Salvar
Então devo visualizar a mensagem "Dados alterados com sucesso"
Quando altero o Email para "maria@teste.com"
E eu clico em Salvar
Então devo visualizar a mensagem "Dados alterados com sucesso"

Cenario: Tentar alterar email ja existente
Dado que eu acesse o sistema
E eu logue como "Maria" com o e-mail "maria@teste.com" e a senha "123456"
Quando eu clico no menu profile Logado para expandir
E eu clico em Meu Perfil
Então devo ser direcionado para pagina de Perfil
Quando eu clico em Minha conta 
E altero o Email para "testemedico@grr.la"
E eu clico em Salvar
Então devo ver a mensagem de validação de email "Email já cadastrado"

Cenario: Tentar alterar email utilizando um email inválido
Dado que eu acesse o sistema
E eu logue como "Dentista" com o e-mail "dentista01@teste.com" e a senha "123456"
Quando eu clico no menu profile Logado para expandir
E eu clico em Meu Perfil
Então devo ser direcionado para pagina de Perfil
Quando eu clico em Minha conta 
E altero o Email para "dentista@teste.c"
Então devo ver a mensagem de validação de email inválido "E-mail inválido"

Cenario: Alterar senha
Dado que eu acesse o sistema
E eu logue como "Dentista" com o e-mail "dentista01@teste.com" e a senha "123456"
Quando eu clico no menu profile Logado para expandir
E eu clico em Meu Perfil
Então devo ser direcionado para pagina de Perfil
Quando eu clico em Minha conta 
E eu clico em Alterar senha
E preencho o campo Senha com "abc@123"
E confirmo a senha "abc@123" no campo Repetir Senha
E eu clico em Cadastrar
Então devo visualizar a mensagem "Dados alterados com sucesso"
Quando eu clico em Alterar senha
E preencho o campo Senha com "123456"
E confirmo a senha "123456" no campo Repetir Senha
E eu clico em Cadastrar
Então devo visualizar a mensagem "Dados alterados com sucesso"

Cenario: Tentar alterar senha, utilizando uma senha com menos de seis caracteres
Dado que eu acesse o sistema
E eu logue como "Medico" com o e-mail "testemedico@grr.la" e a senha "123456"
Quando eu clico no menu profile Logado para expandir
E eu clico em Meu Perfil
Então devo ser direcionado para pagina de Perfil
Quando eu clico em Minha conta 
E eu clico em Alterar senha
E preencho o campo Senha com "abc@"
E confirmo a senha "abc@" no campo Repetir Senha
E eu clico em Cadastrar
Então devo ver a mensagem de validação "Senha inválida"

Cenario: Tentar alterar senha, utilizando a senha de confirmacao diferente
Dado que eu acesse o sistema
E eu logue como "Medico" com o e-mail "testemedico@grr.la" e a senha "123456"
Quando eu clico no menu profile Logado para expandir
E eu clico em Meu Perfil
Então devo ser direcionado para pagina de Perfil
Quando eu clico em Minha conta 
E eu clico em Alterar senha
E preencho o campo Senha com "abc@123"
E confirmo a senha "abc@126" no campo Repetir Senha
E eu clico em Cadastrar
Então devo ver a mensagem de validação "Os Passwords digitados estão diferentes."

Cenario: Alterar especialidades para usuário perfil médico ou dentista
Dado que eu acesse o sistema
E eu logue como "Doctor" com o e-mail "medico01@teste.com" e a senha "123456"
Quando eu clico no menu profile Logado para expandir
E eu clico em Meu Perfil
Então devo ser direcionado para pagina de Perfil
Quando eu clico em Especialidades e Interesses
E eu escolho a Especialidade primária "Acupuntura"
E eu escolho a Especialidade secundária "Cardiologia"
E eu clico em Salvar
Então devo visualizar a mensagem "Dados alterados com sucesso"
Quando eu escolho a Especialidade primária "Angiologia"
E eu escolho a Especialidade secundária "Cirurgia geral"
E eu clico em Salvar
Então devo visualizar a mensagem "Dados alterados com sucesso"

Cenario: Adicionar Interesse e Especialidade 
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Criar Conta
Quando escolho tipo de HCP "Medico (CRM)"
E escolho o Estado "BA"
E preencho o campo Número do registro com registro aleatório
E preencho o Email com email aleatório
E marco a opcao Li e concordo com os Termos e Condições
E clico em Continuar
Quando Eu preencho o campo Nome com "Medico"
E preencho o campo Sobrenome com "Automacao"
E eu preencho o Celular com "79987165507"
E preencho o campo Adicionar Senha com "123456"
E preencho o campo Repetir Senha com "123456"
E clico em Finalizar
Entao devo ver a mensagem de conta criada com sucesso "Sua conta foi criada com sucesso!"
Quando clico em Personalizar
Então devo ser direcionado para pagina de Perfil
Quando eu clico em Especialidades e Interesses
Então devo ver a Mensagem de personalização da conta "Finalize a personalização da sua conta. Selecione uma especialidade primária e selecione um ou mais interesses."
Quando eu escolho a Especialidade primária "Cardiologia"
E eu escolho a Especialidade secundária "Pediatria"
E seleciono em interesses "Amostras de Medicamentos"
E eu clico em Salvar
Então devo visualizar a mensagem "Dados alterados com sucesso"

Cenario: Alterar interesses para usuário com perfil farmaceutico
Dado que eu acesse o sistema
E eu logue como "Maria" com o e-mail "maria@teste.com" e a senha "123456"
Quando eu clico no menu profile Logado para expandir
E eu clico em Meu Perfil
Então devo ser direcionado para pagina de Perfil
Quando eu clico Interesses
E seleciono em interesses "Aulas Médicas"
E eu clico em Salvar
Então devo visualizar a mensagem "Dados alterados com sucesso"
Quando seleciono em interesses "Artigos Científicos"
E seleciono em interesses "Aulas Médicas"
E eu clico em Salvar
Então devo visualizar a mensagem "Dados alterados com sucesso"

#só seleciona o primeiro registro no dropdown
Cenario: Alterar Cidade e Empresa onde trabalha
Dado que eu acesse o sistema
E eu logue como "Farma" com o e-mail "farmaceutico01@teste.com" e a senha "123456"
Quando eu clico no menu profile Logado para expandir
E eu clico em Meu Perfil
Então devo ser direcionado para pagina de Perfil
Quando eu clico em Minha conta 
E seleciono "Indiana" em Empresa onde trabalha
E Preencho o campo cidade com "Ariquem"
E seleciono a cidade "Ariquemes - RO"
E eu clico em Salvar
Então devo visualizar a mensagem "Dados alterados com sucesso"
Quando seleciono "Moderna" em Empresa onde trabalha
E Preencho o campo cidade com "Cabi"
E seleciono a cidade "Cabixi - RO"
E eu clico em Salvar
Então devo visualizar a mensagem "Dados alterados com sucesso"

Cenario: Selecionar "Não se Aplica" em Empresa onde trabalha
Dado que eu acesse o sistema
E eu logue como "Farma" com o e-mail "farmaceutico02@teste.com" e a senha "123456"
Quando eu clico no menu profile Logado para expandir
E eu clico em Meu Perfil
Então devo ser direcionado para pagina de Perfil
Quando eu clico em Minha conta 
E seleciono "Não Se Aplica" em Empresa onde trabalha
Então eu não devo ver o campo Cidade

#só seleciona o primeiro registro no dropdown
Cenario: Selecionar "Outra" em Empresa onde trabalha
Dado que eu acesse o sistema
E eu logue como "Farma" com o e-mail "farmaceutico01@teste.com" e a senha "123456"
Quando eu clico no menu profile Logado para expandir
E eu clico em Meu Perfil
Então devo ser direcionado para pagina de Perfil
Quando eu clico em Minha conta 
E seleciono "Outra" em Empresa onde trabalha
E preencho o campo Nome do local onde trabalha com "Aracaju"
E Preencho o campo cidade com "Cabi"
E seleciono a cidade "Cabixi - RO"  
E eu clico em Salvar
Então devo visualizar a mensagem "Dados alterados com sucesso"
Quando seleciono "Não Se Aplica" em Empresa onde trabalha
E eu clico em Salvar
Então devo visualizar a mensagem "Dados alterados com sucesso"

Cenario: Validar a obrigatoriedade dos campos Cidade e Nome do local onde trabalha
Dado que eu acesse o sistema
E eu logue como "Farma" com o e-mail "farma03@teste.com" e a senha "123456"
Quando eu clico no menu profile Logado para expandir
E eu clico em Meu Perfil
Então devo ser direcionado para pagina de Perfil
Quando eu clico em Minha conta 
E seleciono "Outra" em Empresa onde trabalha
E eu clico em Salvar
Então devo ver a mensagem de obrigatoriedade "Cidade inválida"

Cenario: Validar a obrigatoriedade do campo Empresa onde trabalha
Dado que eu acesse o sistema
E eu logue como "Farma" com o e-mail "farma03@teste.com" e a senha "123456"
Quando eu clico no menu profile Logado para expandir
E eu clico em Meu Perfil
Então devo ser direcionado para pagina de Perfil
Quando eu clico em Minha conta 
E eu altero o Celular para "(71) 9871-6550"
E eu clico em Salvar
Então devo ver a mensagem de obrigatoriedade "Selecione a empresa onde trabalha"