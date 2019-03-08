using System;
using System.Globalization;

namespace ExercPOOCotacaoMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dólar em reais?");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Quantos dólares você vai comprar?");
            int qtdComprarDolar = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"Valor a ser pago em reais = {ConversorDeMoeda.CalcularCotacao(cotacaoDolar, qtdComprarDolar)}");
        }
    }
}
