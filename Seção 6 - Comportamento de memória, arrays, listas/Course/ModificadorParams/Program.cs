using System;

namespace ModificadorParams
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instânciação de array COM modificador "params"
            int s1 = Calculadora.Soma(2, 3);

            /*
             * Instânciação de array sem modificador "params"
             * int s2 = Calculadora.Soma(new int[] { 2, 4, 3 });
             */

            Console.WriteLine(s1);
        }
    }
}
