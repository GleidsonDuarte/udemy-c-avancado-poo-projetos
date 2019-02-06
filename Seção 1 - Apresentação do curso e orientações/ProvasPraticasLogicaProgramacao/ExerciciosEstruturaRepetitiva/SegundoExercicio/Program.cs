using System;

namespace ExerciciosEstruturaRepetitiva.SegundoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor digite a quantidade de valores a serem lidos!");
            int quantidadeValores = int.Parse(Console.ReadLine());
            int cont = 1;
            int aux = 1;
            int dentro = 0;
            int fora = 0;

            while (cont <= quantidadeValores)
            {
                Console.WriteLine($"\nPor favor digite o {cont}º número!");
                aux = int.Parse(Console.ReadLine());

                if (aux >= 10 && aux <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }

                cont++;
            }

            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");
            Console.Read();
        }
    }
}
