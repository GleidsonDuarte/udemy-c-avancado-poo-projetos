using System;
using System.Globalization;

namespace ExercEstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            SomaDoisNumeros();
            AreaRaio();
            DiferencaEntreABeCD();
            CalculaSalario();
            ValorProdutosSerPago();
            CalculaAreas();
        }

        #region Exercício 1
        // Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números.
        public static void SomaDoisNumeros()
        {
            Console.WriteLine("Digite o primeiro número!");
            int primeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número!");
            int segundoNumero = int.Parse(Console.ReadLine());

            int soma = primeiroNumero + segundoNumero;

            Console.WriteLine($"SOMA = {soma}");
        }
        #endregion

        #region Exercício 2
        /*
         * Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo
         * com quatro casas decimais conforme exemplos.
         */

        public static void AreaRaio()
        {
            Console.WriteLine("Digite o valor do raio!");
            double raio = double.Parse(Console.ReadLine());

            double area = Math.Pow(raio, 2) * Math.PI;
            Console.WriteLine($"A = {area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
        #endregion

        #region Exercício 3
        /*
         * Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
         * de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
         */

        public static void DiferencaEntreABeCD()
        {
            Console.WriteLine("Digite o valor de A");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de D");
            int d = int.Parse(Console.ReadLine());

            int diferença = a * b - c * d;
            Console.WriteLine($"Diferença = {diferença}");
        }
        #endregion

        #region Exercício 4
        /*
         * Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
         * hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas
         * casas decimais.
         */

        public static void CalculaSalario()
        {
            Console.WriteLine("Digite o número do funcionário!");
            int numeroFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de horas trabalhadas pelo funcionário!");
            int numeroHorasTrabalhadas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da hora trabalhada do funcionário!");
            double horasTrabalhadas = double.Parse(Console.ReadLine());

            double salario = numeroHorasTrabalhadas * horasTrabalhadas;

            Console.WriteLine($"NUMBER = {numeroFuncionario}");
            Console.WriteLine($"SALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        #endregion

        #region Exercício 5
        /* Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
         * código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
         */

        public static void ValorProdutosSerPago()
        {
            Console.Write("Digite o códgio da peça: ");
            int peca1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de peças: ");
            int quantidade1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor unitário de cada peça: ");
            double valorUnitario1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.Write("Digite o códgio da peça: ");
            int peca2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de peças: ");
            int quantidade2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor unitário de cada peça: ");
            double valorUnitario2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = (quantidade1 * valorUnitario1) + (quantidade2 * valorUnitario2);

            Console.WriteLine();

            Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        #endregion

        #region Exercício 6
        /*
         * Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C.Em seguida, calcule e mostre:
         * a) a área do triângulo retângulo que tem A por base e C por altura.
         * b) a área do círculo de raio C. (pi = 3.14159)
         * c) a área do trapézio que tem A e B por bases e C por altura.
         * d) a área do quadrado que tem lado B.
         * e) a área do retângulo que tem lados A e B.
         */
        public static void CalculaAreas()
        {
            Console.Write("Digite o valor de A: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o valor de B: ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o valor de A: ");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaTrianguloRetangulo = a * c / 2;

            double areaCirculo = Math.PI * Math.Pow(c, 2);

            double areaTrapezio = (a + b) / 2 * c;

            double areaQuadrado = Math.Pow(b, 2);

            double areaRetangulo = a * b;

            Console.WriteLine();

            Console.WriteLine($"TRIÂNGULO: {areaTrianguloRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPÉZIO: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETÂNGULO: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        }
        #endregion
    }
}
