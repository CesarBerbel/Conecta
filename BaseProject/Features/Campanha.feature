#language: pt-BR
Funcionalidade:Campanhas
			   Como usuario do sistema
			   Preciso ter acesso as Campanhas 
			   Para obter as informacoes que eu preciso

Cenario: Acessar campanha exclusiva
Dado que eu acesse a campanha "/pasteur"
Entao devo ver a mensagem "Conteúdo exclusivo para Médico e Farmacêutico" 
Quando eu valido com "Medico (CRM),SC,11655,testemedico@grr.la" 
#E fecho a modal
Entao devo ver a mensagem de conta identificada "Olá, identificamos que você já tem uma conta!"
Quando preencho o campo Adicionar Senha com "123456"
E clico em Finalizar
Entao eu visualizo a campanha "/farmaceuticos"

Cenario: Tentar acessar campanha exclusiva, utilizando perfil sem permissão
Dado que eu acesse a campanha "/pasteur"
Entao devo ver a mensagem "Conteúdo exclusivo para Médico e Farmacêutico" 
Quando eu valido com "Nutricionista (CRN),BA,6666666,nutricionista@teste.com" 
Entao devo ver a mensagem de acesso exclusivo "Olá,Esse conteúdo é exclusivo para Médico e Farmacêutico."

Cenario: Tentar acessar campanha exclusiva para outro perfil, a partir do SoftLogin
Dado que eu acesse a campanha "/dupilumabe-dermatite-atopica"
Entao devo ver a mensagem "Conteúdo exclusivo para Médico" 

Dado que eu retorne para home
Quando eu acesso a campanha "/pasteur"
Entao devo ver a mensagem de acesso exclusivo "Olá,Esse conteúdo é exclusivo para Médico e Farmacêutico."

Cenario: Adicionar e Retirar Campanha dos favoritos
Dado que eu acesse o sistema
E eu logue como "Dentista" com o e-mail "dentista06@teste.com" e a senha "123456"
Então devo ver meu nome "Dentista" na Home 
Quando eu acesso a campanha "/dupilumabe-dermatite-atopica"
E eu clico em Favoritos
Entao eu devo ver a mensagem dos favoritos "Campanha adicionada à sua área pessoal"
Quando eu clico no menu profile Logado para expandir
E eu clico em Itens Salvos
Então eu devo ser direcionado para página de Favoritos
Quando eu clico em Remover item dos favoritos
Entao eu devo ver a mensagem dos favoritos "Item removido da sua área pessoal"

Cenario: Tentar adicionar Campanha aos favoritos sem estar logado no sistema
Dado que eu acesse a campanha "/dupilumabe-dermatite-atopica"
Entao devo ver a mensagem "Conteúdo exclusivo para Médico" 
Quando clico em Fechar
######### Não tem favoritos
E eu clico em Favoritos
Entao devo ver a mensagem "Conteúdo exclusivo para a(s) área(s) Odontológica e Médica" 

Cenario: Tentar adicionar Campanha aos favoritos com SoftLogin 
Dado que eu acesse a campanha "/dupilumabe-dermatite-atopica"
Entao devo ver a mensagem "Conteúdo exclusivo para Médico" 
Quando eu valido com "Nutricionista (CRN),BA,7912345678,nutri19@teste.com" 
Entao devo ver a mensagem de acesso exclusivo "Olá Nutri, Esse conteúdo é exclusivo para Médico." 

Cenario: Compartilhar Campanha nas redes sociais e Copiar Link
Dado que eu acesse o sistema
E eu logue como "farmaceutico" com o e-mail "farma_ce@teste.com" e a senha "123456"
Então devo ver meu nome "farmaceutico" na Home 
Quando eu acesso a campanha "/pasteur"
E eu clico em Compartilhar
Entao devo ver os links "Whatsapp,Facebook,LinkedIn,Copiar link"