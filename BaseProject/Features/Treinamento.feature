#language: pt-BR
Funcionalidade: Treinamento
	            Como usuario do sistema
				Preciso ter acesso aos Treinamentos
				Para assistir os cursos


Cenario: Realizar Treinamento
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Criar Conta
Quando preencho o Cadastro com registro e email aleatórios "Nutricionista (CRN),BA" 
E preencho os dados finais do cadastro com "Nitri,Angry,7912345678,123456,123456"
E eu clico em Deixar para depois
Então devo ver meu nome "Doctor" na Home 
Quando eu acesso o Treinamento "/automation/automation-test-crm"
E clico em Abrir Módulo
E clico para baixar pdf
Então o conteúdo é marcado como concluído
Quando respondo "3" na pergunta "1" 
E Clico em Enviar resposta
Entao eu devo ver a mensagem de sucesso "Resposta Certa"
Quando eu clico em Proxima pergunta
E respondo "1" na pergunta "2" 
E Clico em Enviar resposta
Entao eu devo ver a mensagem de sucesso "Resposta Certa"
Quando eu clico em Proxima pergunta
Então devo ver a mensagem: "Você completou o Módulo Aula 01"
Quando eu clico em fechar
Então devo ver a mensagem de conclusão de curso "Sucesso! Você concluiu o curso. Faça o download do seu certificado no topo da página."

Cenario: Realizar Treinamento com perfil sem permissão
Dado que eu acesse o sistema
E eu logue como "Farma" com o e-mail "farmaceutico01@teste.com" e a senha "123456"
Então devo ver meu nome "Farma" na Home 
Quando eu acesso o Treinamento "/automation/automation-test-crm"
Entao devo ver a mensagem de conteúdo exclusivo "Olá Farma, Esse conteúdo é exclusivo para Médico e Dentista."

Cenario: Realizar Treinamento com softLogin
Dado que eu acesse o sistema
Quando eu acesso o artigo "/Hipotireoidismo-e-riscos-associados-modulo-III-dislipidemia"
Entao devo ver a mensagem "Conteúdo exclusivo para Médico"
Quando eu valido com "Farmacêutico (CRF),BA,4444444,farma04@teste.com" 
Entao devo ver a mensagem de acesso exclusivo "Olá,Esse conteúdo é exclusivo para Médico."
Quando eu acesso o Treinamento "/crf/farmaceuticos"
Entao eu devo ser direcionado para Home deslogada

Cenario: Responder Pesquisa de Satisfação
Dado que eu acesse o sistema
E eu logue como "Medico" com o e-mail "testemedico@grr.la" e a senha "123456"
Então devo ver meu nome "Medico" na Home 
Quando eu acesso o Treinamento "/automation/automation-test-crm"
E respondo "1" na questao "1" 
E respondo "2" na questao "2"
E respondo "3" na questao "3"
E clico em Proximo
E respondo "1" na questao "1" 
E respondo "2" na questao "2"
E clico em Enviar
Entao eu devo ver a mensagem: "Respostas enviadas! Obrigado!"

Cenario: Responder Quiz 
Dado que eu acesse o sistema
E eu logue como "Medico" com o e-mail "testemedico@grr.la" e a senha "123456"
Então devo ver meu nome "Medico" na Home 
Quando eu acesso o Treinamento "/crm/t2i-leaders"
E clico em Abrir o Módulo Comunicação Eficiente
E respondo "3" na pergunta "1" 
E Clico em Enviar resposta
Entao eu devo ver a mensagem de sucesso "Resposta Certa"
Quando eu clico em Proxima pergunta
E respondo "1" na pergunta "2" 
E Clico em Enviar resposta
Entao eu devo ver a mensagem de sucesso "Resposta Certa"
Quando eu clico em Proxima pergunta
E respondo "3" na pergunta "3" 
E Clico em Enviar resposta
Entao eu devo ver a mensagem de sucesso "Resposta Certa"
Quando eu clico em Proxima pergunta
E respondo "1" na pergunta "4" 
E Clico em Enviar resposta
Entao eu devo ver a mensagem de sucesso "Resposta Certa"
Quando eu clico em Proxima pergunta
E respondo "4" na pergunta "5" 
E Clico em Enviar resposta
Entao eu devo ver a mensagem de sucesso "Resposta Certa"
Quando eu clico em Proxima pergunta
Então devo ver a mensagem: "Você completou o Módulo 3. Comunicação Eficiente"

Cenario: Fazer download do Certificado
Dado que eu acesse o sistema
E eu logue como "Doctor" com o e-mail "medico05@teste.com" e a senha "123456"
Então devo ver meu nome "Doctor" na Home 
Quando eu acesso o Treinamento "/automation/automation-test-crm"
E clico em Fazer download do Certificado
Então eu devo visualizar o arquivo ".pdf" em outra janela
# Bug: 7077
Cenario: Adicionar e Retirar Treinamentos dos favoritos
Dado que eu acesse o sistema
E eu logue como "Doctor" com o e-mail "medico05@teste.com" e a senha "123456"
Então devo ver meu nome "Doctor" na Home 
Quando eu acesso o Treinamento "/crm/cec"
E eu clico em Favoritos
Entao eu devo ver a mensagem dos favoritos "Treinamento adicionado à sua área pessoal" 
Quando eu clico no menu profile Logado para expandir
E eu clico em Itens Salvos
Então eu devo ser direcionado para página de Favoritos
Quando eu clico em Remover item dos favoritos
Então eu devo ver a mensagem dos favoritos "Item removido da sua área pessoal"

Cenario: Compartilhar Treinamentos nas redes sociais e Copiar link
Dado que eu acesse o sistema
E eu logue como "Doctor" com o e-mail "medico05@teste.com" e a senha "123456"
Então devo ver meu nome "Doctor" na Home 
Quando eu clico no menu profile Logado para expandir
E eu clico em Treinamentos
E eu clico em Compartilhar 
Entao devo ver os links "Whatsapp,Facebook,LinkedIn,Copiar link"