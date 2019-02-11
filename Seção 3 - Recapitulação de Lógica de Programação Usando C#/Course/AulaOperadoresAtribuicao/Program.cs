using System;

namespace AulaOperadoresAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            int b = 10;
            b++;
            Console.WriteLine(b);

            b--;
            Console.WriteLine(b);

            int c = 10;

            // Primeiro passa o valor de c para b e depois incrementa o valor de c
            int d = c++;
            // Saída: c = 11, b = 10

            /*
             * Primeiro incrementa o valor de c e depois passa o valor do mesmo para b
             * int d = c++;
             * Saída: c = 11, b = 11
            */

            Console.WriteLine(c);
            Console.WriteLine(d);
}
}
}
