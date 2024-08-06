using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a primeira nota:");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota:");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a terceira nota:");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        double media = (nota1 + nota2 + nota3) / 3;

        double notaMinima = 6.0;

        Thread.Sleep(1000); // Pausa por 1 segundo

        if (media >= notaMinima)
        {
            Console.WriteLine($"O aluno foi aprovado com média {media:F2}.");
        }
        else
        {
            Console.WriteLine($"O aluno foi reprovado com média {media:F2}.");
        }
    }
}
