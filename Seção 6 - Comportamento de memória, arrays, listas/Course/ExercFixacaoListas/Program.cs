using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercFixacaoListas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos empregados serão registrados?");
            int qtdEmpregados = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Empregado> listaEmpregados = new List<Empregado>();

            for (int i = 0; i < qtdEmpregados; i++)
            {
                Console.WriteLine("Digite o ID do empregado?");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o nome do empregado?");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o valor do salário?");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                listaEmpregados.Add(new Empregado(id, nome, salario));
            }

            Console.WriteLine("Digite o ID do funcionário a ter aumento de salário?");
            int idEmpregado = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Empregado empregado = listaEmpregados.Find(x => x.Id == idEmpregado);

            if (empregado != null) {
                Console.WriteLine("Digite a porcentagem do almento de salário?");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                empregado.AumentaSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado!");
            }

            foreach (var emp in listaEmpregados)
            {
                Console.WriteLine(emp.ToString());
            }
        }
    }
}
