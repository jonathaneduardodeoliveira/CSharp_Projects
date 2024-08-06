using System;

namespace i_mc
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso, altura;
            bool pesoValido, alturaValida;

            do
            {
                Console.Write("Digite o seu peso em quilogramas: ");
                pesoValido = double.TryParse(Console.ReadLine(), out peso);
                if (!pesoValido || peso <= 0)
                {
                    Console.WriteLine("Por favor, insira um peso válido.");
                    pesoValido = false;
                }
            } while (!pesoValido);

            do
            {
                Console.Write("Digite a sua altura em metros: ");
                alturaValida = double.TryParse(Console.ReadLine(), out altura);
                if (!alturaValida || altura <= 0)
                {
                    Console.WriteLine("Por favor, insira uma altura válida.");
                    alturaValida = false;
                }
            } while (!alturaValida);

            double imc = peso / (altura * altura);

            Console.WriteLine($"Seu IMC é: {imc:F2}");

            if (imc < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso.");
            }
            else if (imc < 24.9)
            {
                Console.WriteLine("Seu peso está normal.");
            }
            else if (imc < 29.9)
            {
                Console.WriteLine("Você está com sobrepeso.");
            }
            else
            {
                Console.WriteLine("Você está obeso.");
            }
        }
    }
}
