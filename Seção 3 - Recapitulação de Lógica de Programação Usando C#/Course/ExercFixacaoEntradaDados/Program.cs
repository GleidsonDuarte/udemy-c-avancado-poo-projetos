using System;
using System.Globalization;

namespace ExercFixacaoEntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quantidadeQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] linha = Console.ReadLine().Split(' ');

            string sobrenomeLinha = linha[0];
            int idadeLinha = int.Parse(linha[1]);
            double alturaLinha = double.Parse(linha[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quantidadeQuartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(sobrenomeLinha);
            Console.WriteLine(idadeLinha);
            Console.WriteLine(alturaLinha.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
