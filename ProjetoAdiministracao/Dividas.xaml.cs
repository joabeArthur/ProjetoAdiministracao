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
            FrameApagar.IsVisible = true;

            //Application.Current.MainPage = new Recibo();

        }

        private void Voltar(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Menu();
        }

        private void Adicionar(object sender, EventArgs e)
        {
            Application.Current.MainPage = new DicionarDividas();
        }

        private void ApagarSIM(object sender, EventArgs e)
        {
            //
        }

        private void ApagarNAO(object sender, EventArgs e)
        {
            FrameApagar.IsVisible = false;
        }

       
    }

