using Microsoft.Maui.Controls;

namespace ProjetoAdiministracao;

    public partial class ContasApagagar : ContentPage
    {
    
        public ContasApagagar()
        {
            InitializeComponent();
        }

        private void OnContasAPagarButtonClicked(object sender, EventArgs e)
        {
            // Handle "Contas a Pagar" button click
            DisplayAlert("Contas a Pagar", "Contas a Pagar button clicked", "OK");
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            // Handle back button click
            Navigation.PopAsync();
        }

        private void OnSettingsButtonClicked(object sender, EventArgs e)
        {
            // Handle settings button click
            DisplayAlert("Settings", "Settings button clicked", "OK");
        }

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            // Handle delete button click
            DisplayAlert("Delete", "Delete button clicked", "OK");
        }
    }
    

