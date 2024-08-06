using System;

namespace adivinhe_si_puder
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jogarNovamente = true;

            while (jogarNovamente)
            {
                Random random = new Random();
                int numeroSecreto = random.Next(1, 101);
                int tentativas = 10;
                bool acertou = false;

                Console.WriteLine("Bem-vindo ao jogo de adivinhação do Jonathan Eduardo de Oliveira!");
                Console.WriteLine("Adivinhe o número se puder. Você tem 10 tentativas apenas.");
                Console.WriteLine("Digite números de 1 a 100.");

                for (int i = 1; i <= tentativas; i++)
                {
                    Console.Write($"\nTentativa {i}: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int palpite))
                    {
                        if (palpite < 1 || palpite > 100)
                        {
                            Console.WriteLine("Por favor, insira um número entre 1 e 100.");
                            i--;
                            continue;
                        }

                        if (palpite == numeroSecreto)
                        {
                            Console.WriteLine("Parabéns! Você acertou o número secreto!");
                            acertou = true;
                            break;
                        }
                        else if (palpite < numeroSecreto)
                        {
                            Console.WriteLine("O número secreto é maior.");
                        }
                        else
                        {
                            Console.WriteLine("O número secreto é menor.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, insira um número.");
                        i--;
                    }
                }

                if (!acertou)
                {
                    Console.WriteLine($"\nVocê perdeu, perdeu mesmo. Não fique triste, você pode jogar mais uma vez. O número secreto era {numeroSecreto}.");
                }

                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Jogar o jogo do Jonathan Eduardo de Oliveira novamente");
                Console.WriteLine("2 - Fechar o jogo");

                Console.Write("Opção: ");
                string escolha = Console.ReadLine();

                while (escolha != "1" && escolha != "2")
                {
                    Console.WriteLine("Opção inválida. Escolha 1 ou 2.");
                    Console.Write("Opção: ");
                    escolha = Console.ReadLine();
                }

                if (escolha == "2")
                {
                    jogarNovamente = false;
                }

                Console.Clear(); // Limpa a tela para iniciar um novo jogo
            }

            Console.WriteLine("Obrigado por jogar o jogo de adivinhação do Jonathan Eduardo de Oliveira!");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
