namespace ExercFixacaoVetore
{
    class Quarto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int NumeroQuarto { get; set; }
        public int Alugado { get; set; }

        public override string ToString()
        {
            return $"{NumeroQuarto}: {Nome}, {Email}";
        }
    }
}
