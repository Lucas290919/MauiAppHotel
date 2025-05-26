using System.Net.Security;
using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quarto = new List<Quarto>()
        {
            new Quarto()
            {
                descricao = "Suite Super Luxo", ValorDiariaAdulto = 110.0,
                ValorDiariaCrianca = 55.0
            },
            new Quarto()
            {
                descricao = "Suite Luxo", ValorDiariaAdulto = 88.0,
                ValorDiariaCrianca = 40.0
            },
            new Quarto()
            {
                descricao = "Suite Single", ValorDiariaAdulto = 50.0,
                ValorDiariaCrianca = 25.0
            },
            new Quarto()
            {
                descricao = "Suite Crise", ValorDiariaAdulto = 25.0,
                ValorDiariaCrianca = 12.5
            }
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
