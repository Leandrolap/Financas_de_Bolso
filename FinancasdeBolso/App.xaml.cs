using FinancasdeBolso.View;

namespace FinancasdeBolso
{
    public partial class App : Application
    {
        public App(TelaInicial telainicial)
        {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new NavigationPage(telainicial);
        }
    }
}
