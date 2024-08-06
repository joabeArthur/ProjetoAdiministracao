using Microsoft.Maui.Controls;

namespace ProjetoAdiministracao
{
    public partial class DicionarDividas : ContentPage
    {
        public DicionarDividas()
        {
            InitializeComponent();
        }

        private void Adicionar(object sender, EventArgs e)
        {
            // 
        }

        private void Voltar(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Dividas();
        }

        private void Apagar(object sender, EventArgs e)
        {
            // 
        }
    }
}
