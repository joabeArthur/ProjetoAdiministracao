using Microsoft.Maui.Controls;
using System;

namespace ProjetoAdiministracao
{
    public partial class Recibo : ContentPage
    {
        public Recibo()
        {
            InitializeComponent();
        }

        private void Apagar(object sender, EventArgs e)
        {
            // 
        }

        private void OnRecibosButtonClicked(object sender, EventArgs e)
        {
            // Handle the Recibos button click event
        }

        private void Voltar(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Menu();
        }
    }
}
