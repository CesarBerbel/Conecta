#language: pt-BR
Funcionalidade: Artigo
	            Como usuario do sistema
				Preciso ter acesso aos Artigos 
				Para obter as informacoes que eu preciso

Cenario: Adicionar e Retirar Artigo dos favoritos
	Dado que eu acesse o sistema
	E eu logo por e-mail "testemedico@grr.la" e a senha "123456"
	Então devo ver meu nome "Medico Teste" no menu profile
	Quando eu acesso o artigo "/4-consenso-brasileiro-rinites"
	E eu clico em Favoritos
	Entao eu devo ver a mensagem dos favoritos "Artigo adicionado à sua área pessoal"
	Quando eu clico no menu profile Logado para expandir
	E eu clico em Itens Salvos
	Então eu devo ser direcionado para página de Favoritos
	Quando eu clico em Remover item dos favoritos
	Entao eu devo ver a mensagem dos favoritos "Item removido da sua área pessoal"

Cenario: Compartilhar Artigo nas redes sociais e Copiar link
	Dado que eu acesse o sistema
	E eu logo por e-mail "testemedico@grr.la" e a senha "123456"
	Então devo ver meu nome "Medico Teste" no menu profile
	Quando eu acesso o artigo "/4-consenso-brasileiro-rinites"
	E eu clico em Compartilhar
	Entao devo ver os links "Whatsapp,Facebook,LinkedIn,Copiar link"

Cenario: Acessar artigo exclusivo
Dado que eu acesso artigo "/boletim-informacoes-medicas-servico-de-informacao-sobre-vacinacao-siv"
Entao devo ver a mensagem "Conteúdo exclusivo para a(s) área(s) Médica, Farmacêutica, Enfermagem e Odontológica" 
Quando eu valido com "Dentista (CRO),BA,21660,jose123@teste.com" 
E eu vejo a mensagem "Olá, identificamos que você já tem uma conta"
E eu me logando com "dentista@servidor.com" e "123456"
#Quando eu clico em SIM
#E eu clico em Prosseguir
#Entao eu devo ser direcionado para página de validacao
#Quando escolho tipo de HCP "Dentista (CRO)"
#E escolho o Estado "BA"
#E preencho o campo do registro com "21660"
#E preencho o Email com "jose123@teste.com"
#E marco a opcao Li e concordo com os Termos e Condições.
#E clico em Finalizar Validacao
#Quando preencho o campo de validação de Email com "dentista@servidor.com"
#E clico em Prosseguir
#E preencho o campo Adicionar Senha com "123456"
#E clico em Finalizar
Entao eu visualizo o artigo "/boletim-informacoes-medicas-servico-de-informacao-sobre-vacinacao-siv"