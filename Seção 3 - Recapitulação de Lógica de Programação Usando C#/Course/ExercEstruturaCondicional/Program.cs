using System;
using System.Globalization;

namespace ExercEstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            DescobreNumeroNegativo();
            DescobreNumeroParImpar();
            DescobreMultiplo();
            TotalHorasJogadas();
            CalcularProduto();
            VerificaIntervalo();
            VerificaEixo();
            CalculaImpostoRenda();
        }

        #region Exercício 1
        // Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

        public static void DescobreNumeroNegativo()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NAO NEGATIVO");
            }
        }
        #endregion

        #region Exercício 2
        // Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.

        public static void DescobreNumeroParImpar()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
        #endregion

        #region Exercício 3
        /*
         *Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
         * Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
         * ordem crescente ou decrescente.
         */
        
        public static void DescobreMultiplo()
        {
            Console.Write("Digite o valor de A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int b = int.Parse(Console.ReadLine());

            if (a > b && a % b == 0)
            {
                Console.WriteLine("SÃO MULTIPLOS");
            }
            else if (b > a && b % a == 0)
            {
                Console.WriteLine("SÃO MULTIPLOS");
            }
            else
            {
                Console.WriteLine("NÃO SÃO MULTIPLOS");
            }
        }
        #endregion

        #region Exercício 4
        /*
         * Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
         * começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
         */
        
        public static void TotalHorasJogadas()
        {
            Console.Write("Digite a hora inicial: ");
            int horaInicial = int.Parse(Console.ReadLine());

            Console.Write("Digite a hora final: ");
            int horaFinal = int.Parse(Console.ReadLine());

            if (horaInicial < horaFinal)
            {
                int duracao = horaFinal - horaInicial;

                Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
            }
            else
            {
                int duracao = 24 - horaInicial + horaFinal;

                Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
            }
        }
        #endregion

        #region Exercício 5
        /*
         * Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item.
         * A seguir, calcule e mostre o valor da conta a pagar. 
         */
        
        public static void CalcularProduto()
        {
            Console.WriteLine(" CÓDIGO |  ESPECIFICAÇÃO  |  PREÇO ");
            Console.WriteLine("   1    | Cachorro Quente | R$ 4.00");
            Console.WriteLine("   2    |     X-Salada    | R$ 4.50");
            Console.WriteLine("   3    |     X-Bacon     | R$ 5.00");
            Console.WriteLine("   4    |Torradas Simples | R$ 2.00");
            Console.WriteLine("   5    |  Refrigerantes  | R$ 1.50");

            Console.WriteLine();

            Console.Write("Digite o código de um produto: ");
            int codigoProduto = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade do produto: ");
            int quantidadeProduto = int.Parse(Console.ReadLine());

            double total;

            switch (codigoProduto)
            {
                case 1:
                    total = quantidadeProduto * 4.00;
                    Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                case 2:
                    total = quantidadeProduto * 4.50;
                    Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                case 3:
                    total = quantidadeProduto * 5.00;
                    Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                case 4:
                    total = quantidadeProduto * 2.00;
                    Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                case 5:
                    total = quantidadeProduto * 1.50;
                    Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
            }
        }
        #endregion

        #region Exercício 6
        /*
         * Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
         * seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em
         * nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
        */

        public static void VerificaIntervalo()
        {
            Console.Write("Digite um número entre 0 e 100: ");
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero < 0.0 || numero > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (numero <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (numero <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (numero <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100])");
            }
        }
        #endregion

        #region Exercício 7
        /*
         * Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano.
         * A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
         * Se o ponto estiver na origem, escreva a mensagem “Origem”. Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”,
         * conforme for a situação.
         */

        public static void VerificaEixo()
        {
            Console.Write("Digite dois valores separados por um espaço: ");
            string[] valores = Console.ReadLine().Split(' ');

            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
        #endregion

        #region Exercício 8
        /*
         * Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem que nele não existem
         * políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem qualquer desvio. A moeda deste país é o
         * Rombus, cujo símbolo é o R$. Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida,
         * calcule e mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
         */

        public static void CalculaImpostoRenda()
        {
            Console.Write("Digite o valor do salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;
            if (salario <= 2000.0)
            {
                imposto = 0.0;
            }
            else if (salario <= 3000.0)
            {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0)
            {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
        #endregion
    }
}
