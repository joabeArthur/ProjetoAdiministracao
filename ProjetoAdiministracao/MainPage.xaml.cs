using Microsoft.Maui.Controls;

namespace ProjetoAdiministracao;

    public partial class MainPage : ContentPage
    {
        public MainPage()
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

