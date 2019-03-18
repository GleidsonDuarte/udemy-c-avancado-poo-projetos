using System;

namespace ModificadoresRefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Calculator.Triplo(ref a);
            Console.WriteLine(a);

            int b = 10;
            int triplo;
            Calculator.Triplo(b, out triplo);
            Console.WriteLine(triplo);
        }
    }
}
