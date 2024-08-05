using Microsoft.Maui.Controls;

namespace ProjetoAdiministracao;

    public partial class Dividas : ContentPage
    {
        public Int64 IdDividas;
        public Dividas()
        {
            InitializeComponent();
        }

        private void Apagar(object sender, EventArgs e)
        {
            Certeza.IsVisible = true;

            //Application.Current.MainPage = new Recibo();

        }

        private void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            // Handle the Voltar button click event
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            // Handle the add button click event
        }

        private void ApagarSIM(object sender, EventArgs e)
        {
            //
        }

        private void ApagarNAO(object sender, EventArgs e)
        {
            //
        }

       
    }

