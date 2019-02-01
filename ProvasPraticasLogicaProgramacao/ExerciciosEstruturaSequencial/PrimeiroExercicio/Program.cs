using System;
using PrimeiroExercicio.Model;

namespace ExercicioEstruturaSequencial.PrimeiroExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Peca peca1 = new Peca();
            peca1.Executar();

            Peca peca2 = new Peca();
            peca2.Executar();

            Console.WriteLine($"\nVALOR A PAGAR: {peca1.CalculaValor() + peca2.CalculaValor()}");
            Console.Read();
        }
    }
}
