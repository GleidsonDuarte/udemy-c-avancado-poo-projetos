using System.Globalization;

namespace ExercPOOCotacaoMoeda
{
    class ConversorDeMoeda
    {
        public static string CalcularCotacao(double dolar, int comprar)
        {
            double total = dolar * comprar * 1.06;
            return total.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
