using System;

namespace ExercFixacaoMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            NumerosDiagonal();
            EncontraNumero();
        }

        static void NumerosDiagonal()
        {
            Console.WriteLine("Digite um valor para criar a matriz!");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Digite {n} valores separados por um espaço!");
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(matriz[i, i] + " ");
            }
            Console.WriteLine();

            int cont = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        cont++;
                    }
                }
            }
            Console.WriteLine("Números negativos: " + cont);
        }

        static void EncontraNumero()
        {
            Console.WriteLine("Digite a quantidade de colunas da matriz!");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite a quantidade de linhas da matriz!");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[,] matriz = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"Digite {n} valores separados por um espaço!");
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Digite o número a ser encontradona matriz!");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        Console.WriteLine("Posição " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Esquerda: " + matriz[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Acima: " + matriz[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Direita: " + matriz[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Abaixo: " + matriz[i + 1, j]);
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
