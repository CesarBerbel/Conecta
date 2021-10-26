#language: pt-BR

Funcionalidade: Calendário
                Para ficar a par dos eventos 
                Eu, como usuário do sistema
                Devo visualizar e acessar meus eventos através do calendário

Cenario: Acessar evento com data passada 
Dado que eu acesse o sistema
E eu logue como "Doctor" com o e-mail "medico04@teste.com" e a senha "123456"
Então devo ver meu nome "Doctor" na Home 
Quando eu clico no Menu "Calendário"
Então eu devo ser direcionado para página de "calendario"
Quando eu clico no evento "top-experts-meeting"
Então eu devo ser direcionado para página de "top-experts-meeting"

Cenario: Acessar evento ao vivo
Dado que eu acesse o sistema
E eu logue como "Doctor" com o e-mail "medico04@teste.com" e a senha "123456"
Então devo ver meu nome "Doctor" na Home
Quando eu clico no Menu "Calendário"
Então eu devo ser direcionado para página de "calendario"
Quando eu clico no botão Ao vivo
Então eu devo visualizar o arquivo "webinarsanofi" em outra janela

Cenario: Adicionar evento ao calendário
Dado que eu acesse o sistema
E eu logue como "Doctor" com o e-mail "medico04@teste.com" e a senha "123456"
Então devo ver meu nome "Doctor" na Home
Quando eu clico no Menu "Calendário"
Então eu devo ser direcionado para página de "calendario"
Quando eu clico no botão Adicionar ao meu calendário
E seleciono a opcao "Google"
Entao eu vejo o botão "Adicionado"

