#language: pt-BR
Funcionalidade: Artigo
	            Como usuario do sistema
				Preciso ter acesso aos Artigos 
				Para obter as informacoes que eu preciso

Cenario: Acessar artigo exclusivo
Dado que eu acesso artigo "/boletim-informacoes-medicas-servico-de-informacao-sobre-vacinacao-siv"
Entao devo ver a mensagem "Conteúdo exclusivo para Médico, Farmacêutico e Enfermeiro"
Quando eu valido com "Farmacêutico (CRF),BA,4444444,farma04@teste.com" 
E preencho o campo Adicionar Senha com "123456"
Quando clico em Finalizar
Entao eu visualizo o artigo "/boletim-informacoes-medicas-servico-de-informacao-sobre-vacinacao-siv"

Cenario: Acessar artigo exclusivo, utilizando perfil sem permissão
Dado que eu acesso artigo "/Hipotireoidismo-e-riscos-associados-modulo-III-dislipidemia"
Entao devo ver a mensagem "Conteúdo exclusivo para Médico" 
Quando eu valido com "Farmacêutico (CRF),BA,4444444,farma04@teste.com"
Entao devo ver a mensagem de acesso exclusivo "Olá,Esse conteúdo é exclusivo para Médico."

Cenario: Acessar artigo exclusivo, com Soft Login
Dado que eu acesso artigo "/Hipotireoidismo-e-riscos-associados-modulo-III-dislipidemia"
Entao devo ver a mensagem "Conteúdo exclusivo para Médico"
Quando eu valido com "Farmacêutico (CRF),BA,4444444,farma04@teste.com" 
Entao devo ver a mensagem de acesso exclusivo "Olá,Esse conteúdo é exclusivo para Médico."
Quando eu clico em Ir para a página Inicial
E eu acesso o artigo "/allenasal-na-rinite-alergica-pediatrica"
Entao eu visualizo o artigo "/allenasal-na-rinite-alergica-pediatrica"

Cenario: Adicionar e Retirar Artigo dos favoritos
Dado que eu acesse o sistema
E eu logue como "Medico" com o e-mail "testemedico@grr.la" e a senha "123456"
Então devo ver meu nome "Medico" na Home 
Quando eu acesso o artigo "/escore-febrasgo-2021"
E eu clico em Favoritos
Entao eu devo ver a mensagem dos favoritos "Artigo adicionado à sua área pessoal"
Quando eu clico no menu profile Logado para expandir
E eu clico em Itens Salvos
Então eu devo ser direcionado para página de Favoritos
Quando eu clico em Remover item dos favoritos
Entao eu devo ver a mensagem dos favoritos "Item removido da sua área pessoal"

Cenario: Compartilhar Artigo nas redes sociais e Copiar link
Dado que eu acesse o sistema
E eu logue como "Medico" com o e-mail "testemedico@grr.la" e a senha "123456"
Então devo ver meu nome "Medico" na Home 
Quando eu acesso o artigo "/4-consenso-brasileiro-rinites"
E eu clico em Compartilhar
Entao devo ver os links "Whatsapp,Facebook,LinkedIn,Copiar link"