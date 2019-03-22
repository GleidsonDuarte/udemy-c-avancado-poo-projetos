using System;
using System.Collections.Generic;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            B.Add(4);

            /*
             * Remoção
             * B.Remove(5);
             */

            /*
             * Exceção
             * A.ExceptWith(B);
             */

            /*
             * União
             * A.UnionWith(B);
             */

            /*
             * Intersecção
             * A.IntersectWith(B);
             */

            foreach (int x in A)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Digite um valor para ser procurado na coleção!");
            int valor = int.Parse(Console.ReadLine());

            if (B.Contains(valor))
            {
                Console.WriteLine($"{valor} pertence ao conjunto B!");
            }
            else
            {
                Console.WriteLine($"{valor} não pertence ao conjunto B!");
            }
        }
    }
}
