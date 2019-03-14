using System;
using System.Globalization;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            AulaVetor1();
            AulaVetor2();
        }

        private static void AulaVetor1()
        {
            Console.WriteLine("Digite o tamanho do vetor!");
            int tamanho = int.Parse(Console.ReadLine());

            double[] vetor = new double[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Digite a altura!");
                double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vetor[i] = altura;

                Console.WriteLine();
            }

            double soma = 0.0;

            for (int i = 0; i < tamanho; i++)
            {
                soma += vetor[i];
            }

            double media = soma / tamanho;

            Console.WriteLine("Média = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }

        private static void AulaVetor2()
        {
            Console.WriteLine("Digite o tamanho do vetor!");
            int tamanho = int.Parse(Console.ReadLine());

            Produto[] vetor = new Produto[tamanho];

            Console.WriteLine();

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vetor[i] = new Produto { Nome = nome, Preco = preco };

                Console.WriteLine();
            }

            double soma = 0.0;

            for (int i = 0; i < tamanho; i++)
            {
                soma += vetor[i].Preco;
            }

            double media = soma / tamanho;

            Console.WriteLine("AVERAGE PRICE = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
