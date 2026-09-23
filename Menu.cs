using System;

public class Menu
{
    public void ExibirMenu()
    {
        int opcao;

        do
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Purple;
            Console.WriteLine("╔════════════════════════════════════════════════════╗");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("║           Liga da Turma                            ║");
            Console.ForegroundColor = ConsoleColor.Purple;
            Console.WriteLine("╠════════════════════════════════════════════════════╣");


            // Opções principais do jogo.
            Console.ForegroundColor = ConsoleColor.Purple;
            Console.WriteLine("║ 1 - Cadastro de Equipes                            ║");
            Console.WriteLine("║ 2 - Registrar Partida                              ║");
            Console.WriteLine("║ 3 - Consultar Histórico                            ║");
            Console.WriteLine("║ 4 - Cadastrar Festival                             ║");
            Console.WriteLine("║ 5 - Gerar Convite                                  ║");
            Console.WriteLine("║ 6 - Cartão de Resultado                            ║");
            Console.WriteLine("║ 7 - Instruções de Funcionamento                    ║");
            Console.WriteLine("║ 8 - Créditos                                       ║");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("║ 0 - Sair                                           ║");
            Console.ForegroundColor = ConsoleColor.Purple;
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
                string entrada = Console.ReadLine();

                if (entrada == "")
                {

                }
                continue;
            }

            switch (opcao)
            {

                case 1:
                    //cadastrar equipes
                    break;

                case 2:

                    // registrar partida

                    break;

                case 3:

                    //consulta historico

                    break;

                case 4:

                    //cadastrar festival

                    break;
                
                case 5:
                    //gerar convite

                    break;

                case 6:
                    //cartão de resultado

                    break;

                case 7:
                    //mostrar instruções
                    MostrarInstrucoes();
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

        Console.ForegroundColor = ConsoleColor.Purple;
        Console.WriteLine("======================== INSTRUÇÕES ======================\n");

        Console.ForegroundColor = ConsoleColor.Pink;
        Console.WriteLine("FUTSAL:");

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Para registrar uma partida de futsal, você deve informar");
        Console.WriteLine("O nome das equipes;");
        Console.WriteLine("O número de gols de cada equipe;");
        Console.WriteLine("E o nome do festival em que a partida foi realizada.");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Pressione qualquer tecla para voltar...");
        Console.ResetColor();
        Console.ReadKey(true);
    }

void MostrarCreditos()
{
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("========================= CRÉDITOS ==========================\n");

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Liga da Turma");
    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Yellow;
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

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Curso: Técnico em Desenvolvimento de Sistemas");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Técnico em Desenvolvimento de Sistemas - 2026");
    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Professor:");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Alisson Zimmer");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Projeto desenvolvido no SENAI");
    Console.WriteLine("Disciplina de Programação de Aplicativos");
    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Obrigada!");
    Console.WriteLine();
    Console.WriteLine("Pressione ENTER para voltar ao menu.");

    Console.ResetColor();

    while (Console.ReadKey(true).Key != ConsoleKey.Enter)
    {
    }
}
}