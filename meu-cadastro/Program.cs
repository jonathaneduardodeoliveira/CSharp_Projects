using System;

namespace MeuCadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Meu Cadastro!");

            // Pedindo informações
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.Write("Digite a idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Possui RG? (s/n): ");
            bool possuiRg = Console.ReadLine().ToLower() == "s";

            Console.Write("Possui CPF? (s/n): ");
            bool possuiCpf = Console.ReadLine().ToLower() == "s";

            // Exibindo as informações
            Console.WriteLine("\nCadastro realizado com sucesso!");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Sobrenome: " + sobrenome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura);
            Console.WriteLine("Possui RG: " + (possuiRg ? "Sim" : "Não"));
            Console.WriteLine("Possui CPF: " + (possuiCpf ? "Sim" : "Não"));

            Console.WriteLine("\nPressione qualquer tecla para fechar o aplicativo...");
            Console.ReadKey();
        }
    }
}
