using System;

namespace ExerciciosEstruturaCondicional.SegundoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b;
            double c;
            double x1;
            double x2;

            while (a == 0) {
                Console.WriteLine("Digite o valor de A!");
                a = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nDigite o valor de B!");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o valor de C!");
            c = double.Parse(Console.ReadLine());

            if ((b * b - 4 * a * c) >= 0)
            {
                x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

                Console.WriteLine("\nSaída:");
                Console.WriteLine($"\nX1 = {string.Format("{0:0.####}", x1)}");
                Console.WriteLine($"\nX2 = {string.Format("{0:0.####}", x2)}");
            }
            else
            {
                Console.WriteLine("\nImpossivel calcular!");
            }

            Console.Read();
        }
    }
}
