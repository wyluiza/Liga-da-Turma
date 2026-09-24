using System;

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
                string? entrada2 = Console.ReadLine();

                if (entrada2 == "")
                {

                }
                continue;
            }

            switch (opcao)
            {

                case 1:
                    Console.WriteLine("Cadastro de Equipes");
                    Console.WriteLine("Digite o nome da equipe:");
                    string? nomeEquipe = Console.ReadLine();
                    gerenciadorEquipes.CadastrarEquipe(nomeEquipe);
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

                    break;

                case 4:

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
                    Console.ReadKey(true);

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