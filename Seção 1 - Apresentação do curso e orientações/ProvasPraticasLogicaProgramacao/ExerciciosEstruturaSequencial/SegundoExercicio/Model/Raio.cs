using System;

namespace SegundoExercicio.Model
{
    class Raio
    {
        public double TamanhoRaio { get; set; }
        public double Area { get; set; }

        private void PegarTamanhoRaio()
        {
            Console.WriteLine($"Informe o tamanho do raio!");
            TamanhoRaio = double.Parse(Console.ReadLine());
        }

        private double CalcularArea()
        {
            return Area = Math.PI * Math.Pow(TamanhoRaio, 2);
        }

        private void ImprimeArea()
        {
            Console.WriteLine($"Área: {string.Format("{0:0.####}", CalcularArea())}.");
            Console.Read();
        }

        public void Executar()
        {
            PegarTamanhoRaio();
            CalcularArea();
            ImprimeArea();
        }
    }
}
