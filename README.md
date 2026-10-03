Liga da Turma

O Liga da Turma é um projeto desenvolvido em C# para ajudar na organização de um festival escolar com partidas de Futsal e eSports.

O sistema funciona pelo console e permite cadastrar equipes, registrar partidas, acompanhar os resultados e organizar as informações do festival. A ideia é reunir essas funções em um só lugar, de forma simples e fácil de usar.

O que o sistema faz?
Cadastra e mostra as equipes participantes.
Registra partidas entre duas equipes.
Permite escolher entre Futsal e eSports.
Armazena os placares das partidas.
Mostra o histórico dos confrontos realizados.
Permite cadastrar as informações do festival, como nome, local, data e horário.
Gera um convite com os dados do evento.
Cria cartões com os resultados das partidas.

Tecnologias utilizadas
C#, .NET, Visual Studio Code, Git e GitHub e apoio IA Generativa na hora de codar

Como executar

Para executar o projeto, é necessário ter o .NET SDK instalado no computador, clone o repositório, entre na pasta do projeto, execute o comando dotnet run no terminal e depois disso, o menu principal será exibido no console.


Programacao Orientada a Objetos
Durante o desenvolvimento do projeto, utilizamos os cinco conceitos de Programação Orientada a Objetos (POO) estudados em aula :D

Abstração: utilizamos a classe abstrata Partida como modelo para representar as características comuns das partidas, deixando os detalhes específicos para cada modalidade.
Encapsulamento: protegemos os dados das classes e controlamos o acesso a eles por meio de propriedades e métodos.
Herança: criamos as classes PartidaFutsal e PartidaEsports, que herdam características da classe Partida.
Interfaces: utilizamos a interface InterfaceResultadoPartida, que define o método ObterResultado(), implementado pelas duas classes de partida.
Polimorfismo: utilizamos o mesmo método ObterResultado() nas diferentes modalidades, permitindo que cada uma apresente seu resultado de acordo com suas próprias regras.


Desenvolvedoras
Luiza Triches, Milena Frey

SENAI — Técnico em Desenvolvimento de Sistemas | 2026