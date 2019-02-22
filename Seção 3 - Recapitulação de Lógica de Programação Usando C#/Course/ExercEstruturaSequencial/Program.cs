using System;
using System.Globalization;

namespace ExercEstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            
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

        public static void diferencaEntreABeCD()
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
    }
}
