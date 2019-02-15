using System;
using System.Globalization;

namespace AulaEstruturaRepetitiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Enquanto for verdadeiro faça algo, se for falso, saia
            while (true)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));

                Console.WriteLine("Digite outro número: ");    
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
        }
    }
}
