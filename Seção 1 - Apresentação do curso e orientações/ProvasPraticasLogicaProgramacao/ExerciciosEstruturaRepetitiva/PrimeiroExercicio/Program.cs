using System;

namespace ExerciciosEstruturaRepetitiva.PrimeiroExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int SenhaNumerica = 0;

            while (SenhaNumerica != 2002) {
                if (!ValidarSenha(SenhaNumerica))
                {
                    Console.WriteLine("Senha inválida!");

                    Console.WriteLine("\nDigite a sua senha!");
                    SenhaNumerica = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Acesso permitido!");

            Console.Read();
        }

        static private bool ValidarSenha(int senha)
        {
            if (senha == 2002)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
