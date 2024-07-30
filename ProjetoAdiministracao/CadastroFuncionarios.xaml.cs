using Microsoft.Maui.Controls;
using System;

namespace ProjetoAdiministracao
{
    public partial class CadastroFuncionarios : ContentPage
    {
        public CadastroFuncionarios()
        {
            InitializeComponent();
        }

        private void OnTrashButtonClicked(object sender, EventArgs e)
        {
            // Handle the trash button click event
            NameEntry.Text = string.Empty;
            CPFEntry.Text = string.Empty;
            RGEntry.Text = string.Empty;
            HorarioEntry.Text = string.Empty;
            SalarioEntry.Text = string.Empty;
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            // Handle the save button click event
            // Add your save logic here
        }

        private void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            // Handle the Voltar button click event
            // Add your navigation logic here
        }
    }
}
