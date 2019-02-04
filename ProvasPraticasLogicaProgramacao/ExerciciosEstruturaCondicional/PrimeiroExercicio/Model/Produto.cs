namespace PrimeiroExercicio.Model
{
    public struct Produto
    {
        public int Codigo { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public double Total { get; set; }

        public double ValorProduto(int codigo)
        {
            switch (codigo)
            {
                case 1:
                    Valor = 4;
                    break;
                case 2:
                    Valor = 4.5;
                    break;
                case 3:
                    Valor = 5;
                    break;
                case 4:
                    Valor = 2;
                    break;
                case 5:
                    Valor = 1.5;
                    break;
            }

            return Valor;
        }

        public double Calcular(int quantidade, double valor)
        {
            return Total = quantidade * valor;
        }
    }
}
