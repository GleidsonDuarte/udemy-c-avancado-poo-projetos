using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            lista.Add("Maria");
            lista.Add("Alex");
            lista.Add("Bob");
            lista.Add("Anna");
            lista.Insert(2, "Marco");

            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + lista.Count);

            //string s1 = lista.Find(Teste);

            string s1 = lista.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            string s2 = lista.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = lista.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = lista.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            List<string> lista2 = lista.FindAll(x => x.Length == 5);
            Console.WriteLine("--------------");
            foreach (string obj in lista2)
            {
                Console.WriteLine(obj);
            }

            lista.Remove("Alex");
            Console.WriteLine("--------------");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }

            lista.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("--------------");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }

            lista.RemoveAt(0);
            Console.WriteLine("--------------");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }

            lista.Add("João");
            lista.Add("Jaqueline com J");
            lista.Add("Peterson");
            lista.Add("Alice");
            Console.WriteLine("--------------");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }

            lista.RemoveRange(3, 2);
            Console.WriteLine("--------------");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }
        }

        //static bool Teste(string s)
        //{
        //    return s[0] == 'A';
        //}
    }
}
