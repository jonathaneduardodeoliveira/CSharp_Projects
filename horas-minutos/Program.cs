using System;

namespace horas_minutos
{
    class Program
    {
        static void Main()
        {
            Console.Write("Insira o número de horas: ");
            int horas = Convert.ToInt32(Console.ReadLine());

            int minutos = horas * 60;

            Console.WriteLine($"{horas} horas equivalem a {minutos} minutos.");

            Console.ReadLine();
        }
    }
}
