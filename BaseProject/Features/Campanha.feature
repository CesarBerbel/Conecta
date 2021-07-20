#language: pt-BR
Funcionalidade:Campanhas
			   Como usuario do sistema
			   Preciso ter acesso as Campanhas 
			   Para obter as informacoes que eu preciso

Cenario: Compartilhar Campanha nas redes sociais e Copiar Link
	Dado que eu acesse o sistema
	E eu logo por e-mail "farma_ce@teste.com" e a senha "123456"
	Então devo ver meu nome "farmaceutico teste" no menu profile
	Quando eu acesso a campanha "pasteur"
	Quando eu clico em Compartilhar
	Entao devo ver os links "Whatsapp,Facebook,LinkedIn,Copiar link"