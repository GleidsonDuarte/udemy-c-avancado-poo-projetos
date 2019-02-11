using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            DeclaracoesVariaveis();
            PegarTamMinMaxNumeros();
            ImpressaoSimplesVariaveis();
            TiposImpressaoString();
        }

        // Básico sobre declaração de variáveis em C#
        private static void DeclaracoesVariaveis()
        {
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5F;
            double n6 = 4.5;
            string nome = "Maria Green";
            object obj1 = "Alex Brown";
            object obj2 = 4.5F;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
        }

        // Utilizar função .MinValue e .MaxValue para pegar menor ou maior valor possível de tipos de variáveis numéricas
        private static void PegarTamMinMaxNumeros()
        {
            int n1 = int.MinValue;
            int n2 = int.MaxValue;
            sbyte n3 = sbyte.MinValue;
            decimal n4 = decimal.MaxValue;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
        }

        // Forma simples para formatar a apresentação de numeros fracionados e também de imprimir variáveis na tela
        private static void ImpressaoSimplesVariaveis()
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");
            Console.WriteLine("----------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
        }

        // Formas de se imprimir uma string na tela
        private static void TiposImpressaoString()
        {
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            /*
            Console.WriteLine(nome);
            Console.WriteLine(" tem ");
            Console.WriteLine(idade);
            Console.WriteLine(" anos.");
            */

            // Placehoçder
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais.", nome, idade, saldo);

            // Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais.");

            // Concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais.");
        }
    }
}
