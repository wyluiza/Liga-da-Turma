    using System;
    using System.Linq; // pra usar o firstOrDefault
    using System.Collections.Generic;
    using System.Globalization; // pra fazer as horas e datas

    public class Menu
    {
        Gerenciador gerenciadorEquipes = new Gerenciador();
        public void Exibir()
        {
            int opcao;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("╔════════════════════════════════════════════════════╗");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("║                  Liga da Turma                     ║");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("╠════════════════════════════════════════════════════╣");


                // Opções principais do jogo.
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("║ 1 - Cadastrar Equipes                              ║");
                Console.WriteLine("║ 2 - Consultar Equipes                              ║");
                Console.WriteLine("║ 3 - Registrar Partida                              ║");
                Console.WriteLine("║ 4 - Consultar Histórico                            ║");
                Console.WriteLine("║ 5 - Cadastrar Festival                             ║");
                Console.WriteLine("║ 6 - Gerar Convite                                  ║");
                Console.WriteLine("║ 7 - Cartão de Resultado                            ║");
                Console.WriteLine("║ 8 - Instruções de Funcionamento                    ║");
                Console.WriteLine("║ 9 - Créditos                                       ║");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("║ 0 - Sair                                           ║");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("╚════════════════════════════════════════════════════╝");

                Console.ResetColor();

                Console.Write("\nEscolha: ");
                string? entrada = Console.ReadLine();
                if (!int.TryParse(entrada, out opcao))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nOpção inválida!");

                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Pressione ENTER para continuar...");
                    Console.ResetColor();
                    Console.ReadLine();
                    opcao = -1; // Define uma opção inválida para continuar o loop
                    continue;


                }

                switch (opcao)
                {

                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("═══════════════ CADASTRAR EQUIPES ══════════════");
                        Console.ResetColor();
                        Console.WriteLine("Digite o nome da equipe:");
                        string? nomeEquipe = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(nomeEquipe))
                        {
                            gerenciadorEquipes.CadastrarEquipe(nomeEquipe);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O nome da equipe não pode ficar vazio.");
                            Console.ResetColor();
                        }
                        break;

                    case 2:
                        List<Equipe> equipes = gerenciadorEquipes.ConsultarEquipes();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("═══════════════ EQUIPES CADASTRADAS ══════════════");
                        Console.ResetColor();
                        foreach (Equipe equipe in equipes)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"- {equipe.Nome}");
                        }
                        Console.ResetColor();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey(true);
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("═══════════════ CADASTRAR PARTIDA ══════════════");
                        Console.ResetColor();
                        List<Equipe> listaDeEquipes = gerenciadorEquipes.ConsultarEquipes();
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Equipes cadastradas:");
                        Console.ResetColor();
                        foreach (Equipe equipe in listaDeEquipes)
                        {
                            Console.WriteLine($"- {equipe.Nome}");
                        }
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Digite o nome da primeira equipe:");
                        Console.ResetColor();
                        string? nomeEquipe1 = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Digite o nome da segunda equipe:");
                        Console.ResetColor();
                        string? nomeEquipe2 = Console.ReadLine();
                        Equipe? equipe1 = listaDeEquipes.FirstOrDefault(e => e.Nome == nomeEquipe1);
                        Equipe? equipe2 = listaDeEquipes.FirstOrDefault(e => e.Nome == nomeEquipe2);
                        Console.ResetColor();
                        if (equipe1 != null && equipe2 != null) //verifica se as duas equipes existem na lista
                        {
                            if (equipe1 != equipe2)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Equipes encontradas.");
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Selecione a modalidade da partida:");
                                Console.ResetColor();
                            
                                Console.WriteLine("1 - Futsal");
                                Console.WriteLine("2 - Esports");
                                string? entradaModalidade = Console.ReadLine();
                                int modalidadeEscolhida;
                                if (int.TryParse(entradaModalidade, out modalidadeEscolhida))
                                {
                                    if (modalidadeEscolhida == 1 || modalidadeEscolhida == 2)
                                    {
                                        Modalidade modalidade = (Modalidade)(modalidadeEscolhida - 1);
                                        Console.ResetColor();
                                        Console.WriteLine($"Quantos pontos a equipe {equipe1.Nome} fez?");

                                        int pontosEquipe1 = -1;
                                            bool entradaValida1 = false;

                                            while (!entradaValida1 || pontosEquipe1 < 0)
                                                {
                                                    entradaValida1 = int.TryParse(Console.ReadLine(), out pontosEquipe1);

                                                    if (!entradaValida1 || pontosEquipe1 < 0)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine("Digite uma pontuação válida (número inteiro igual ou maior que zero).");
                                                        Console.ResetColor();
                                                        Console.WriteLine("");
                                                        Console.WriteLine($"Quantos pontos a equipe {equipe1.Nome} fez?");
                                                    }
                                                }
                                            Console.WriteLine($"Quantos pontos a equipe {equipe2.Nome} fez?");
                                                int pontosEquipe2 = -1;
                                                bool entradaValida2 = false;

                                                while (!entradaValida2 || pontosEquipe2 < 0)
                                                {
                                                    entradaValida2 = int.TryParse(Console.ReadLine(), out pontosEquipe2);

                                                    if (!entradaValida2 || pontosEquipe2 < 0)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine("Digite uma pontuação válida (número inteiro igual ou maior que zero).");
                                                        Console.ResetColor();
                                                        Console.WriteLine("");
                                                        Console.WriteLine($"Quantos pontos a equipe {equipe2.Nome} fez?");
                                                    }
                                                }
                                                    Partida? partidaCadastrada = null;
                                                        try
                                                        {
                                                            partidaCadastrada = gerenciadorEquipes.CadastrarPartida(equipe1, equipe2, modalidade, pontosEquipe1, pontosEquipe2);

                                                            Console.WriteLine("\nPartida cadastrada com sucesso!");
                                                        }
                                                        catch (ArgumentException erro) // captura e trata um erro q acontece no progrwama
                                                        {
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.WriteLine($"\n{erro.Message}");
                                                            Console.ResetColor();
                                                        }
                                        if (partidaCadastrada != null)
                                        {
                                        if (partidaCadastrada.PlacarEquipe1 >= 0 && partidaCadastrada.PlacarEquipe2 >= 0)
                                        {
                                        string nomeEquipe1Formatado;

                                            if (partidaCadastrada.Equipe1.Nome.Length > 15)
                                            {
                                                nomeEquipe1Formatado = partidaCadastrada.Equipe1.Nome.Substring(0, 15);
                                            }
                                            else
                                            {
                                                nomeEquipe1Formatado = partidaCadastrada.Equipe1.Nome;
                                            }

                                            string nomeEquipe2Formatado;

                                            if (partidaCadastrada.Equipe2.Nome.Length > 15)
                                            {
                                                nomeEquipe2Formatado = partidaCadastrada.Equipe2.Nome.Substring(0, 15);
                                            }
                                            else
                                            {
                                                nomeEquipe2Formatado = partidaCadastrada.Equipe2.Nome;
                                            }
                                            nomeEquipe1Formatado = nomeEquipe1Formatado.PadRight(15);
                                            nomeEquipe2Formatado = nomeEquipe2Formatado.PadRight(15);
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("╔════════════════════════════════════════════════════╗");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("║                   PLACAR FINAL                     ║");
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("╠════════════════════════════════════════════════════╣");
                                            Console.WriteLine($"║ {nomeEquipe1Formatado} {partidaCadastrada.PlacarEquipe1,3} X {nomeEquipe2Formatado} {partidaCadastrada.PlacarEquipe2,3} ".PadRight(53) + "║");                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("╚════════════════════════════════════════════════════╝");
                                        }
                                            if (partidaCadastrada.PlacarEquipe1 > partidaCadastrada.PlacarEquipe2)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Magenta;
                                                Console.WriteLine($"A equipe {partidaCadastrada.Equipe1.Nome} venceu a partida! Parabéns!");
                                            }
                                            else if (partidaCadastrada.PlacarEquipe1 < partidaCadastrada.PlacarEquipe2)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Magenta;
                                                Console.WriteLine($"A equipe {partidaCadastrada.Equipe2.Nome} venceu a partida! Parabéns!");
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Magenta;
                                                Console.WriteLine("A partida terminou em um empate.");
                                            }
                                            Console.ResetColor();
                                    }
                                    }
                                    
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Digite uma opção válida.");
                                    Console.ResetColor();
                                }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Digite um número válido.");
                                    Console.ResetColor();
                                }  
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Escolha duas equipes diferentes."); 
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Uma ou as duas equipes não foram encontradas.");
                            Console.ResetColor();
                            
                        }
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                        Console.ReadKey(true);
                        Console.ResetColor();
                        break;

                    case 4:
                        List<Partida> historico = gerenciadorEquipes.ConsultarPartidas();

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("═══════════════ HISTÓRICO DE PARTIDAS ══════════════\n");
                        Console.ResetColor();

                        if (historico.Count == 0)
                        {
                            Console.WriteLine("Nenhuma partida foi registrada ainda.");
                        }
                        else
                        {
                            foreach (Partida partida in historico)
                            {
                                Console.WriteLine($"Modalidade: {partida.Modalidade}");
                                Console.WriteLine($"{partida.Equipe1.Nome} {partida.PlacarEquipe1} X {partida.PlacarEquipe2} {partida.Equipe2.Nome}");
                                Console.ResetColor();

                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine(partida.ObterResultado());
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("════════════════════════════════════════════════════");
                                Console.ResetColor();
                            }
                        }

                        Console.WriteLine("\nPressione qualquer tecla para voltar...");
                        Console.ReadKey(true);
                        break;
                    
                    case 5:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("═══════════════ CADASTRO DO FESTIVAL ════════════════");
                        Console.ResetColor();

                        Console.Write("Digite o nome do festival: ");
                        string? nome = Console.ReadLine();

                        Console.Write("Digite o local do festival: ");
                        string? local = Console.ReadLine();

                        Console.Write("Digite a data do festival: ");
                        string? data = Console.ReadLine();

                        Console.Write("Digite o horário do festival: ");
                        string? horario = Console.ReadLine();

                        //validacao de datas e horarios
                        bool dataValida = DateTime.TryParseExact( data, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _
                        );
                        bool horarioValido = DateTime.TryParseExact( horario, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out _
                        );
                        if (!string.IsNullOrWhiteSpace(nome) && !string.IsNullOrWhiteSpace(local) && !string.IsNullOrWhiteSpace(data) && !string.IsNullOrWhiteSpace(horario) && dataValida && horarioValido)
                        {
                            gerenciadorEquipes.CadastrarFestival(nome, local, data, horario);

                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("\nFestival cadastrado com sucesso!");
                            Console.ResetColor();
                        }
                        else
                        {   
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Algo deu errado ao cadastrar o festival.");
                            Console.WriteLine("\nPreencha todos os campos corretamente. Use DD/MM/AAAA para a data e HH:MM para o horário.");
                            Console.ResetColor();
                        }

                        Console.WriteLine("\nPressione qualquer tecla para continuar...");
                        Console.ReadKey(true);

                        break;

                    case 6:
                        Console.Clear();

                        Festival? festivalCadastrado = gerenciadorEquipes.ConsultarFestival();

                        if (festivalCadastrado == null)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Nenhum festival foi cadastrado ainda.");
                            Console.ResetColor(); 
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;

                            Console.WriteLine("╔════════════════════════════════════════════════════╗");
                            Console.WriteLine("║                   CONVITE ESPECIAL                 ║");
                            Console.WriteLine("╠════════════════════════════════════════════════════╣");

                            Console.ForegroundColor = ConsoleColor.White;

                            Console.WriteLine("║                                                    ║");
                            Console.WriteLine($"║  Festival: {festivalCadastrado.Nome,-39} ║");
                            Console.WriteLine($"║  Local:    {festivalCadastrado.Local,-39} ║");
                            Console.WriteLine($"║  Data:     {festivalCadastrado.Data,-39} ║");
                            Console.WriteLine($"║  Horário:  {festivalCadastrado.Horario,-39} ║");
                            Console.WriteLine("║                                                    ║");

                            Console.ForegroundColor = ConsoleColor.DarkMagenta;

                            Console.WriteLine("╠════════════════════════════════════════════════════╣");
                            Console.WriteLine("║            Aguardamos você no festival :)          ║");
                            Console.WriteLine("╚════════════════════════════════════════════════════╝");

                            Console.ResetColor();
                        }

                        Console.WriteLine("\nPressione qualquer tecla para continuar...");
                        Console.ReadKey(true);

                        
                        break;

                        case 7:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("═══════════════ CARTÃO DE RESULTADO ═══════════════\n");
                            Console.ResetColor();
                            List<Partida> listaDePartidas = gerenciadorEquipes.ConsultarPartidas();

                            if (listaDePartidas.Count == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Nenhuma partida foi cadastrada ainda.");
                                Console.ResetColor();
                            }
                            else
                            {
                                foreach (Partida partida in listaDePartidas)
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine($"Modalidade: {partida.Modalidade}");
                                    Console.WriteLine($"{partida.Equipe1.Nome} {partida.PlacarEquipe1} X {partida.PlacarEquipe2} {partida.Equipe2.Nome}");
                                    if (partida.PlacarEquipe1 > partida.PlacarEquipe2)
                                    {
                                        Console.WriteLine($"Equipe vencedora: {partida.Equipe1.Nome}");
                                    }
                                    else if (partida.PlacarEquipe1 < partida.PlacarEquipe2)
                                    {
                                        Console.WriteLine($"Equipe vencedora: {partida.Equipe2.Nome}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("A partida terminou em empate.");
                                    }
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("════════════════════════════════════════════════════");
                                    Console.ResetColor();
                                }
                            }
                        Console.WriteLine("\nPressione qualquer tecla para continuar...");
                        Console.ReadKey(true);

                        break;

                    case 8:
                        MostrarInstrucoes();
                        break;
                    
                    case 9:
                        MostrarCreditos();
                        break;

                    case 0:
                        Console.WriteLine("Aperte qualquer tecla para sair...");
                        Console.ReadKey(true);

                        break;

                    default:

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nOpção inválida!");

                        Console.ResetColor();

                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();

                        break;
                }


            }
            // Enquanto a opção escolhida for diferente de 0,
            // o menu continua aparecendo.
            while (opcao != 0);
        }

        void MostrarInstrucoes()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("══════════════════ INSTRUÇÕES ══════════════════                 \n");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("FUTSAL:");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Para registrar uma partida de futsal, você deve informar");
            Console.WriteLine("O nome das equipes;");
            Console.WriteLine("E o número de pontos de cada equipe.");
            Console.WriteLine();
            
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("ESPORTS:");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Para registrar uma partida de esports (qualquer modalidade online), você deve informar");
            Console.WriteLine("O nome das equipes;");
            Console.WriteLine("E o número de pontos de cada equipe.");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Pressione qualquer tecla para voltar...");
            Console.ResetColor();
            Console.ReadKey(true);
        }

    void MostrarCreditos()
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("══════════════════ CRÉDITOS ══════════════════\n");

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Liga da Turma");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Desenvolvedores:");
            string[] equipe =
            {
                "Luiza Triches",
                "Milena Frey",
            };

            Console.ForegroundColor = ConsoleColor.White;
            foreach (string integrante in equipe)
            {
                Console.WriteLine($"• {integrante}");
            }

            Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Curso: Técnico em Desenvolvimento de Sistemas");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Técnico em Desenvolvimento de Sistemas - 2026");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Professor:");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Alisson Zimmer");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Projeto desenvolvido no SENAI");
        Console.WriteLine("Disciplina de Programação de Aplicativos");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Obrigada!");
        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para voltar ao menu.");

        Console.ResetColor();

        while (Console.ReadKey(true).Key != ConsoleKey.Enter)
        {
        }
    }
    }