using Microsoft.Maui.Controls;
using System;

namespace ProjetoAdiministracao
{
    public partial class Funcionarios : ContentPage
    {
        public Funcionarios()
        {
            InitializeComponent();
        }

        private void Apagar(object sender, EventArgs e)
        {
            // 
        }

        private void Voltar(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Menu();
        }
    }
}
