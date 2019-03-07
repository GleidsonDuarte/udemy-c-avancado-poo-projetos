using System;
using System.Globalization;

namespace ExercEstruturaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            NumerosImpares();
            ValoresEntre10E20();
            CalculaMedia();
            Divisivel();
            Fatorial();
            CalculaDivisores();
            MostrarLinhas();
        }

        #region Exercício 1
        /*
         * Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha,
         * inclusive o X, se for o caso.
         */
        public static void NumerosImpares()
        {
            Console.Write("Digite um valor maior que 1 e menor que 1000: ");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 1; i <= valor; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        #endregion

        #region Exercício 2
        /*
         * Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
         * Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
         * essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
         */
        public static void ValoresEntre10E20()
        {
            Console.Write("Digite um número de valores a serem lidos: ");
            int valor = int.Parse(Console.ReadLine());

            int aux = 0;
            int dentro = 0;
            int fora = 0;

            for (int i = 1; i <= valor; i++)
            {
                Console.Write($"Digite o {i}º valor: ");
                aux = int.Parse(Console.ReadLine());

                if (aux >= 10 && aux <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }

            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");
        }
        #endregion

        #region Exercício 3
        /* 
         * Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
         * de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes conjuntos
         * de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.
         */
        public static void CalculaMedia()
        {
            Console.Write("Digite a quantidade de casos a serem testados: ");
            int casos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= casos; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                double b = double.Parse(line[1], CultureInfo.InvariantCulture);
                double c = double.Parse(line[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
        #endregion

        #region Exercício 4
        /*
         * Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
         * segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
         */
        public static void Divisivel()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                string[] line = Console.ReadLine().Split(' ');
                int x = int.Parse(line[0]);
                int y = int.Parse(line[1]);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double div = (double)x / y;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture);
                }
            }
        }
        #endregion

        #region Exercício 5
        /*
         * Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
         * Lembrando que, por definição, fatorial de 0 é 1.
         */
        public static void Fatorial()
        {
            int n = int.Parse(Console.ReadLine());

            int fat = 1;
            for (int i = 1; i <= n; i++)
            {
                fat = fat * i;
            }

            Console.WriteLine(fat);
        }
        #endregion

        #region Exercício 6
        /*
         * Ler um número inteiro N e calcular todos os seus divisores.
         */
        public static void CalculaDivisores()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        #endregion

        #region Exercício 7
        /*
         * Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas, começando de 1 até N.
         * Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme exemplo.
         */
        public static void MostrarLinhas()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine($"{primeiro} {segundo} {terceiro}");
            }
        }
        #endregion
    }
}