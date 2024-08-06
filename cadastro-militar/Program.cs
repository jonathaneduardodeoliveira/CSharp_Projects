using System;

namespace cadastro_militar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao cadastro militar. Vamos ver se você pode se alistar.");

            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade:");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite sua altura em metros:");
            double altura = Convert.ToDouble(Console.ReadLine());

            if (idade >= 18 && altura >= 1.70)
            {
                Console.WriteLine($"Parabéns, {nome}! Você está aprovado para o alistamento militar.");
            }
            else
            {
                Console.WriteLine($"Desculpe, {nome}. Você não atende aos critérios para o alistamento militar.");
            }
        }
    }
}
