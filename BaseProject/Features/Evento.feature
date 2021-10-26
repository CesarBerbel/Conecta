#language: pt-BR


Funcionalidade:  Evento
                 Como usuario do sistema
				 Preciso ter acesso aos Eventos 
				 Para obter as informacoes que eu preciso


Cenario: Salvar evento no calendário através de um Link no body 
Dado que eu acesse o sistema
Quando eu acesso o evento "/evento-zinpass-eze-2021-automacao-data-futura"
Entao devo ver a mensagem "Conteúdo exclusivo para Médico" 
Quando eu valido com "Medico (CRM),BA,0028852,medico01@teste.com" 
Entao devo ver a mensagem de conta identificada "Olá, identificamos que você já tem uma conta!"
Quando preencho o campo Adicionar Senha com "123456"
E clico em Finalizar
Entao eu visualizo o evento "/evento-zinpass-eze-2021-automacao-data-futura"
Quando clico no link Salvar no calendário dentro da palestra
E escolho "Apple" dentro da palestra

Cenario: Tentar acessar evento exclusivo, utilizando perfil sem permissão
Dado que eu acesse o sistema
Quando eu acesso o evento "/hipoplay-now-hipotireoidismo-e-o-coracao"
Entao devo ver a mensagem "Conteúdo exclusivo para Médico"
Quando eu valido com "Farmacêutico (CRF),BA,1111111,farmaceutico01@teste.com" 
Entao devo ver a mensagem de acesso exclusivo "Olá,Esse conteúdo é exclusivo para Médico."

Cenario: Tentar acessar evento exclusivo para outro perfil, a partir do SoftLogin 
Dado que eu acesse a campanha "/dits"
Entao devo ver a mensagem "Conteúdo exclusivo para Médico e Farmacêutico"
Quando eu valido com "Nutricionista (CRN),BA,6941,nutri01@teste.com" 
Entao devo ver a mensagem de acesso exclusivo "Olá,Esse conteúdo é exclusivo para Médico e Farmacêutico."
Quando eu acesso o evento "/evento-zinpass-eze-2021-automacao-data-futura"
Entao devo ver a mensagem de acesso exclusivo "Olá,Esse conteúdo é exclusivo para Médico." 

Cenario: Tentar adicionar evento aos favoritos, utilizando perfil sem permissão
Dado que eu acesse o sistema
Quando eu acesso o evento "/hipoplay-now-hipotireoidismo-e-o-coracao"
Entao devo ver a mensagem "Conteúdo exclusivo para Médico" 
Quando eu fecho o modal 
Dado eu logue como "Dentista" com o e-mail "dentista01@teste.com" e a senha "123456"
Então devo ver meu nome "Dentista" na Home 
E devo ver a mensagem de conteúdo exclusivo "Olá Dentista, Esse conteúdo é exclusivo para Médico."
Quando eu fecho o modal 
E eu clico em Favoritos 
Entao devo ver a mensagem de conteúdo exclusivo "Olá Dentista, Esse conteúdo é exclusivo para Médico."

Cenario: Adicionar e Retirar Evento dos favoritos
Dado que eu acesse o sistema
E eu logue como "Medico" com o e-mail "testemedico@grr.la" e a senha "123456"
Então devo ver meu nome "Medico" na Home 
Quando eu acesso o evento "/hipoplay-now-hipotireoidismo-e-o-coracao"
Entao eu visualizo o evento "/hipoplay-now-hipotireoidismo-e-o-coracao"
Quando eu clico em Favoritos
Entao eu devo ver a mensagem dos favoritos "Evento adicionado à sua área pessoal" 
Quando eu clico no menu profile Logado para expandir
E eu clico em Itens Salvos
Então eu devo ser direcionado para página de Favoritos
Quando eu clico em Remover item dos favoritos
Então eu devo ver a mensagem dos favoritos "Item removido da sua área pessoal" 

Cenario: Compartilhar evento nas redes sociais e Copiar link
Dado que eu acesse o sistema
E eu logue como "Medico" com o e-mail "testemedico@grr.la" e a senha "123456"
Então devo ver meu nome "Medico" na Home 
Quando eu acesso o evento "/hipoplay-now-hipotireoidismo-e-o-coracao"
Entao eu visualizo o evento "/hipoplay-now-hipotireoidismo-e-o-coracao"
Quando eu clico em Compartilhar
Entao devo ver os links "Whatsapp,Facebook,LinkedIn,Copiar link"

Cenario: Acessar evento exclusivo data passada
Dado que eu acesse o sistema
Quando eu acesso o evento "/hipoplay-now-hipotireoidismo-e-o-coracao"
Entao devo ver a mensagem "Conteúdo exclusivo para Médico" 
Quando eu valido com "Medico (CRM),BA,5808,medico02@teste.com" 
Entao devo ver a mensagem de conta identificada "Olá, identificamos que você já tem uma conta!"
Quando preencho o campo Adicionar Senha com "123456"
E clico em Finalizar
Entao eu visualizo o evento "/hipoplay-now-hipotireoidismo-e-o-coracao"
E não devo ver o botão de Adicionar a meu calendário

Cenario: Adicionar evento ao calendário
Dado que eu acesse o sistema
Quando eu acesso o evento "/evento-zinpass-eze-2021-automacao-data-futura"
Entao devo ver a mensagem "Conteúdo exclusivo para Médico" 
Quando eu valido com "Medico (CRM),BA,5808,medico02@teste.com" 
Entao devo ver a mensagem de conta identificada "Olá, identificamos que você já tem uma conta!"
Quando preencho o campo Adicionar Senha com "123456"
E clico em Finalizar
Entao eu visualizo o evento "/evento-zinpass-eze-2021-automacao-data-futura"
E eu visualizo o botão Adicionar a meu calendário
Quando eu clico em "Adicionar a meu calendário"
E seleciono a opcao "Google"
Entao eu vejo o botão "Adicionado"

Cenario: Acessar evento dentro do periodo do evento
Dado que eu acesse o sistema
Quando eu acesso o evento "/evento-zinpass-eze-2021-automacao-ao-vivo"
Entao devo ver a mensagem "Conteúdo exclusivo para Médico" 
Quando eu valido com "Medico (CRM),BA,0028852,medico01@teste.com" 
Entao devo ver a mensagem de conta identificada "Olá, identificamos que você já tem uma conta!"
Quando preencho o campo Adicionar Senha com "123456"
E clico em Finalizar
Entao devo ver o botão "Ao vivo agora!"