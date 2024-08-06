using Microsoft.Maui.Controls;

namespace ProjetoAdiministracao;

    public partial class Cadastro : ContentPage
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Confirmar(object sender, EventArgs e)
        {
            string email = EmailEntry.Text;
            string senha = SenhaEntry.Text;
            string confirmarSenha = ConfirmarSenha.Text;

            // Lógica de validação e processamento do cadastro
            if (senha == null || confirmarSenha == null || email == null || senha == confirmarSenha)
            {
                ErroCadastro.IsVisible = true;
            }
            else
            {
                Application.Current.MainPage = new Menu();
            }
        }

         
        private void TentarDeNovo(object sender, EventArgs e)
        {
            ErroCadastro.IsVisible = false;

        }
    }

