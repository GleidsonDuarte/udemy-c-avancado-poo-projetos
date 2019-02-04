using PrimeiroExercicio.Model;
using System;

namespace PrimeiroExercicio
{
    class Program
    {
        public static int Codigo { get; set; }
        public static int Quantidade { get; set; }
        public static double ValorProduto { get; set; }

        static void Main(string[] args)
        {
            TabelaPrecos();
        }

        private static void TabelaPrecos()
        {
            Console.WriteLine("CÓDIGO |  ESPECIFICAÇÃO  | PREÇO");
            Console.WriteLine("  1    | Cachorro Quente | R$ 4,00");
            Console.WriteLine("  2    |    X-Salada     | R$ 4,50");
            Console.WriteLine("  3    |    X-Bacon      | R$ 5,00");
            Console.WriteLine("  4    | Torrada Simples | R$ 2,00");
            Console.WriteLine("  5    |  Refrigerante   | R$ 1,50");

            DigiteCodigo();
            ValidaCodigo();

            DigiteQuantidade();
            ValidaQuantidade();

            Produto produto = new Produto();
            var total = produto.Calcular(Quantidade, produto.ValorProduto(Codigo));

            Console.WriteLine($"Total: R$ { total }");
            Console.Read();
        }

        private static void DigiteCodigo()
        {
            Console.WriteLine("\nDigite o código do produto!");
            Codigo = int.Parse(Console.ReadLine());
        }

        private static void DigiteQuantidade()
        {
            Console.WriteLine("\nDigite a quantidade do produto!");
            Quantidade = int.Parse(Console.ReadLine());
        }

        private static void ValidaCodigo()
        {
            if (Codigo < 1 || Codigo > 5)
            {
                Console.WriteLine("Código do produto é inválido, por favor digite novamente!");

                DigiteCodigo();
                ValidaCodigo();
            }
        }

        private static void ValidaQuantidade()
        {
            if (Quantidade < 0)
            {
                Console.WriteLine("A quantidade não pode ser negativa, por favor digite novamente!");

                DigiteQuantidade();
                ValidaQuantidade();
            }
        }
    }
}
