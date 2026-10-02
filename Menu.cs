    using System;
    using System.Linq; // pra usar o firstOrDefault
    using System.Collections.Generic;

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

                    Console.WriteLine("Pressione ENTER para continuar...");
                    Console.ReadLine();
                    opcao = -1; // Define uma opção inválida para continuar o loop
                    continue;


                }

                switch (opcao)
                {

                    case 1:
                        Console.WriteLine("Cadastro de Equipes");
                        Console.WriteLine("Digite o nome da equipe:");
                        string? nomeEquipe = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(nomeEquipe))
                        {
                            gerenciadorEquipes.CadastrarEquipe(nomeEquipe);
                        }
                        else
                        {
                            Console.WriteLine("O nome da equipe não pode ficar vazio.");
                        }
                        break;

                    case 2:
                        List<Equipe> equipes = gerenciadorEquipes.ConsultarEquipes();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Equipes cadastradas:");
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
                        List<Equipe> listaDeEquipes = gerenciadorEquipes.ConsultarEquipes();
                        foreach (Equipe equipe in listaDeEquipes)
                        {
                            Console.WriteLine($"- {equipe.Nome}");
                        }
                        Console.WriteLine("Digite o nome da primeira equipe:");
                        string? nomeEquipe1 = Console.ReadLine();
                        Console.WriteLine("Digite o nome da segunda equipe:");
                        string? nomeEquipe2 = Console.ReadLine();
                        Equipe? equipe1 = listaDeEquipes.FirstOrDefault(e => e.Nome == nomeEquipe1);
                        Equipe? equipe2 = listaDeEquipes.FirstOrDefault(e => e.Nome == nomeEquipe2);
                        if (equipe1 != null && equipe2 != null) //verifica se as duas equipes existem na lista
                        {
                            if (equipe1 != equipe2)
                            {
                                Console.WriteLine("Equipes encontradas.");
                                Console.WriteLine("Selecione a modalidade da partida:");
                                Console.WriteLine("1 - Futsal");
                                Console.WriteLine("2 - Esports");
                                string? entradaModalidade = Console.ReadLine();
                                int modalidadeEscolhida;
                                if (int.TryParse(entradaModalidade, out modalidadeEscolhida))
                                {
                                    if (modalidadeEscolhida == 1 || modalidadeEscolhida == 2)
                                    {
                                        Modalidade modalidade = (Modalidade)(modalidadeEscolhida - 1);
                                        Partida partidaCadastrada = gerenciadorEquipes.CadastrarPartida(equipe1, equipe2, modalidade);
                                        Console.WriteLine("Partida cadastrada com sucesso.");
                                        Console.WriteLine($"Quantos pontos a equipe {partidaCadastrada.Equipe1.Nome} fez?");
                                        int pontosEquipe1 = int.Parse(Console.ReadLine()!);
                                        Console.WriteLine($"Quantos pontos a equipe {partidaCadastrada.Equipe2.Nome} fez?");
                                        int pontosEquipe2 = int.Parse(Console.ReadLine()!);
                                        partidaCadastrada.RegistrarPlacar(pontosEquipe1, pontosEquipe2);
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
                                            if (partidaCadastrada.PlacarEquipe1 > partidaCadastrada.PlacarEquipe2)
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                Console.WriteLine($"A equipe {partidaCadastrada.Equipe1.Nome} venceu a partida! Parabéns!");
                                            }
                                            else if (partidaCadastrada.PlacarEquipe1 < partidaCadastrada.PlacarEquipe2)
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                Console.WriteLine($"A equipe {partidaCadastrada.Equipe2.Nome} venceu a partida! Parabéns!");
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                Console.WriteLine("A partida terminou em um empate.");
                                            }
                                            Console.ResetColor();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Os pontos não podem ser negativos.");
                                    }
                                    }
                                    
                                else
                                {
                                    Console.WriteLine("Digite uma opção válida.");
                                
                                }
                                }
                                else
                                {
                                    Console.WriteLine("Digite um número válido.");
                                    
                                }  
                            }
                            else
                            {
                                Console.WriteLine("Escolha duas equipes diferentes.");
                                
                            }
                        }
                        else
                        {
                            Console.WriteLine("Uma ou as duas equipes não foram encontradas.");
                            
                        }
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey(true);
                        Console.ResetColor();
                        break;

                    case 4:
                        List<Partida> historico = gerenciadorEquipes.ConsultarPartidas();
                        
                        break;
                    
                    case 5:

                        break;

                    case 6:

                        break;

                    case 7:

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
            Console.WriteLine("======================== INSTRUÇÕES ======================\n");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("FUTSAL:");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Para registrar uma partida de futsal, você deve informar");
            Console.WriteLine("O nome das equipes;");
            Console.WriteLine("O número de gols de cada equipe;");
            Console.WriteLine("E o nome do festival em que a partida foi realizada.");
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
        Console.WriteLine("========================= CRÉDITOS ==========================\n");

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Liga da Turma");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Desenvolvedores:");

            //estamos utilizando vetores, ó
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