using System;
using System.Globalization;

namespace EntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            EntradaDadosParte1();
            EntradaDadosParte2();
        }

        public static void EntradaDadosParte1()
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            /*
             * string s = Console.ReadLine();
             * string[] v = s.Split(' ');
            */

            string[] v = Console.ReadLine().Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine("Você digitou:");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }

        public static void EntradaDadosParte2()
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
