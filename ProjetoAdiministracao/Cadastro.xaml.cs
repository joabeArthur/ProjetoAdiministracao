using Microsoft.Maui.Controls;

namespace ProjetoAdiministracao
{
    public partial class Cadastro : ContentPage
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void OnConfirmarClicked(object sender, EventArgs e)
        {
            string email = EmailEntry.Text;
            string senha = SenhaEntry.Text;
            string confirmarSenha = ConfirmarSenhaEntry.Text;

            // Lógica de validação e processamento do cadastro
            if (senha == confirmarSenha)
            {
                DisplayAlert("Sucesso", "Cadastro realizado com sucesso", "OK");
            }
            else
            {
                DisplayAlert("Erro", "As senhas não coincidem", "OK");
            }
        }
    }
}
