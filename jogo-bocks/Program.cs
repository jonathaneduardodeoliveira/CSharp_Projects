using System;
using System.Text.RegularExpressions;

namespace jogo_bocks
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            while (true)
            {
                Console.WriteLine("Digite o nome do jogador:");
                nome = Console.ReadLine();

                if (verificarNome(nome))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nome inválido! Digite o nome somente com letras.");
                }
            }

            Console.WriteLine($"Bem-vindo, {nome}!");

            while (true) // Loop do jogo
            {
                JogarJogo();

                Console.WriteLine("\nDeseja jogar novamente?");
                Console.WriteLine("1 - Sim");
                Console.WriteLine("2 - Fechar o jogo");

                int opcao;
                while (!int.TryParse(Console.ReadLine(), out opcao) || (opcao != 1 && opcao != 2))
                {
                    Console.WriteLine("Opção inválida. Escolha 1 para jogar novamente ou 2 para fechar o jogo.");
                }

                if (opcao == 2)
                {
                    Console.WriteLine("Obrigado por jogar! Até mais.");
                    break;
                }
            }
        }

        static void JogarJogo()
        {
            Random random = new Random();
            int pontosJogador = 0;
            int pontosMaquina = 0;

            Console.WriteLine("\nBem-vindo ao jogo de luta!");

            while (pontosJogador < 1000 && pontosMaquina < 1000)
            {
                Console.WriteLine("\nOpções:");
                Console.WriteLine("1 - Jab");
                Console.WriteLine("2 - Direto");
                Console.WriteLine("3 - Cruzado");
                Console.WriteLine("4 - Gancho");
                Console.WriteLine("5 - Uppercut");
                Console.WriteLine("6 - Chute");

                Console.WriteLine("Escolha sua opção (1-6):");

                int escolhaJogador;
                while (!int.TryParse(Console.ReadLine(), out escolhaJogador) || escolhaJogador < 1 || escolhaJogador > 6)
                {
                    Console.WriteLine("Opção inválida. Escolha um número de 1 a 6.");
                }

                int pontos = random.Next(50, 151); // Pontuação aleatória entre 50 e 150 pontos

                string nomeSoco = ObterNomeSoco(escolhaJogador);

                pontosJogador += pontos;
                Console.WriteLine($"Você deu um {nomeSoco}! Fez {pontos} pontos. Pontuação total: {pontosJogador}. Faltam {1000 - pontosJogador} pontos para vencer.");

                if (pontosJogador >= 1000)
                {
                    Console.WriteLine("Parabéns! Você ganhou!");
                    return; // Retorna ao menu principal
                }

                int escolhaMaquina = random.Next(1, 7);
                nomeSoco = ObterNomeSoco(escolhaMaquina);

                pontos = random.Next(50, 151);
                pontosMaquina += pontos;
                Console.WriteLine($"A máquina deu um {nomeSoco}! Fez {pontos} pontos. Pontuação total da máquina: {pontosMaquina}. Faltam {1000 - pontosMaquina} pontos para vencer.");

                if (pontosMaquina >= 1000)
                {
                    Console.WriteLine("Você perdeu. A máquina venceu!");
                    return; // Retorna ao menu principal
                }
            }
        }

        static bool verificarNome(string nome)
        {
            return Regex.IsMatch(nome, @"^[a-zA-ZáÁéÉíÍóÓúÚ]+$");
        }

        static string ObterNomeSoco(int escolha)
        {
            switch (escolha)
            {
                case 1:
                    return "Jab";
                case 2:
                    return "Direto";
                case 3:
                    return "Cruzado";
                case 4:
                    return "Gancho";
                case 5:
                    return "Uppercut";
                case 6:
                    return "Chute";
                default:
                    return "";
            }
        }
    }
}
