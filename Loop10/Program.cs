using System;
using System.Threading;

namespace Loop10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("-");
                }

                Console.WriteLine();

                // Adiciona um atraso de 1 segundo (1000 milissegundos)
                Thread.Sleep(1000);
            }
        }
    }
}
