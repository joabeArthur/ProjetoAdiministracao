using Microsoft.Maui.Controls;

namespace ProjetoAdiministracao;

    public partial class TelaInicial : ContentPage
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void Login(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Login();
        }

        private void Cadastro(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Cadastro();
        }
    }

