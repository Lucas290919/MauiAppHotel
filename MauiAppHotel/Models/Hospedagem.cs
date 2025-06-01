namespace MauiAppHotel.Models
{
    public class Hospedagem
    {
        public Quarto Quartoselecioado { get; set; }
        public int qntAdultos { get; set; }
        public int qntCrianças { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }

        public int Estadia 
        { 
            get => DataCheckOut.Subtract(DataCheckIn).Days;
        }

        public double ValorTotal
        {
            get
            {
                double valor_adultos = qntAdultos * Quartoselecioado.ValorDiariaAdulto;
                double valor_criancas = qntCrianças * Quartoselecioado.ValorDiariaCrianca;

                double total = (valor_adultos +  valor_criancas) * Estadia;

                return total;
            }
        }
    }
}
