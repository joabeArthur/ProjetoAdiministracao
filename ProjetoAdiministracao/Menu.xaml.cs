using Microsoft.Maui.Controls;

namespace ProjetoAdiministracao
{
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void OnCadastroFuncionariosClicked(object sender, EventArgs e)
        {
            // Navegação ou lógica para Cadastro de Funcionarios
            DisplayAlert("Info", "Cadastro de Funcionarios", "OK");
        }

        private void OnFuncionariosClicked(object sender, EventArgs e)
        {
            // Navegação ou lógica para Funcionarios
            DisplayAlert("Info", "Funcionarios", "OK");
        }

        private void OnDividasClicked(object sender, EventArgs e)
        {
            // Navegação ou lógica para Dividas
            DisplayAlert("Info", "Dividas", "OK");
        }

        private void OnReceberClicked(object sender, EventArgs e)
        {
            // Navegação ou lógica para Receber
            DisplayAlert("Info", "Receber", "OK");
        }

        private void OnPagosClicked(object sender, EventArgs e)
        {
            // Navegação ou lógica para Pagos
            DisplayAlert("Info", "Pagos", "OK");
        }
    }
}
