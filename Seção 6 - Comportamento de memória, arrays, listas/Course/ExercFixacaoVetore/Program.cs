using System;

namespace ExercFixacaoVetore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos quartos serão alugados?");
            int qtdQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Quarto[] vetor = new Quarto[10];

            for (int i = 0; i < qtdQuartos; i++)
            {
                Console.Write("Digite o nome do inquilino: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o e-maio do inquilino: ");
                string email = Console.ReadLine();

                Console.Write("Digite o número do quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vetor[quarto] = new Quarto() { Nome = nome, Email = email, NumeroQuarto = quarto, Alugado = i + 1 };

                Console.WriteLine();
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] != null)
                {
                    Console.WriteLine(vetor[i].ToString());
                }
            }
        }
    }
}
