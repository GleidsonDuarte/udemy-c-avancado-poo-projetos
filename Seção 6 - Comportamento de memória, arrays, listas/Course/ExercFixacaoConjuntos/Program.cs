using System;
using System.Collections.Generic;

namespace ExercFixacaoConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O curso A possui quantos alunos?");
            int cursoA = int.Parse(Console.ReadLine());

            HashSet<int> conjuntoA = new HashSet<int>();

            for (int i = 0; i < cursoA; i++)
            {
                Console.WriteLine($"Digite o número do {i + 1}º aluno!");
                int alunoA = int.Parse(Console.ReadLine());

                conjuntoA.Add(alunoA);
            }

            Console.WriteLine();

            HashSet<int> conjuntoB = new HashSet<int>();

            Console.WriteLine("O curso B possui quantos alunos?");
            int cursoB = int.Parse(Console.ReadLine());

            for (int i = 0; i < cursoB; i++)
            {
                Console.WriteLine($"Digite o número do {i + 1}º aluno!");
                int alunoB = int.Parse(Console.ReadLine());

                conjuntoB.Add(alunoB);
            }

            Console.WriteLine();

            HashSet<int> conjuntoC = new HashSet<int>();

            Console.WriteLine("O curso C possui quantos alunos?");
            int cursoC = int.Parse(Console.ReadLine());

            for (int i = 0; i < cursoC; i++)
            {
                Console.WriteLine($"Digite o número do {i + 1}º aluno!");
                int alunoC = int.Parse(Console.ReadLine());

                conjuntoC.Add(alunoC);
            }

            Console.WriteLine();

            conjuntoA.UnionWith(conjuntoB);
            conjuntoA.UnionWith(conjuntoC);

            Console.WriteLine($"Total de alunos: {conjuntoA.Count}");
        }
    }
}
