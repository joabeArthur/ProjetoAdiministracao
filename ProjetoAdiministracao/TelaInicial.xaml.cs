using Microsoft.Maui.Controls;

namespace ProjetoAdiministracao;

    public partial class TelaInicial : ContentPage
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            // Handle login button click
            DisplayAlert("Login", "Login button clicked", "OK");
        }

        private void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            // Handle register button click
            DisplayAlert("Register", "Register button clicked", "OK");
        }
    }

