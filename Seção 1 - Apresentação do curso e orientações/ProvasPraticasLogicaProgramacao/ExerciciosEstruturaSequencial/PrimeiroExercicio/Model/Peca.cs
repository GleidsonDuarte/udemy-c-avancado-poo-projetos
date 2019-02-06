using System;

namespace PrimeiroExercicio.Model
{
    public class Peca
    {
        private string Codigo { get; set; }
        private int Quantidade { get; set; }
        private decimal Valor { get; set; }
        private const string PULA_LINHA = "\n";

        private void PegaValores()
        {
            Console.WriteLine($"Informe os valores!");

            Console.WriteLine($"{PULA_LINHA}Código do produto!");
            Codigo = Console.ReadLine().ToString();

            Console.WriteLine($"{PULA_LINHA}Quantidade de peças!");
            Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"{PULA_LINHA}Valor por peça!");
            Valor = decimal.Parse(Console.ReadLine());
        }

        public decimal CalculaValor()
        {
            var total = Quantidade * Valor;

            return total;
        }

        private void ImprimeTotal()
        {
            Console.WriteLine($"{PULA_LINHA}Código: {Codigo}.{PULA_LINHA}Quantidade: {Quantidade}.{PULA_LINHA}Valor: {Valor}.{PULA_LINHA}Total: {CalculaValor()}.");
        }

        public void Executar()
        {
            PegaValores();
            CalculaValor();
            ImprimeTotal();
        }
    }
}
