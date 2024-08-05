using Microsoft.Maui.Controls;

namespace ProjetoAdiministracao
{
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Dividas(object sender, EventArgs args)
	{
		Application.Current.MainPage = new Dividas();
	}

	private void Recibo(object sender, EventArgs args)
	{
		Application.Current.MainPage = new Recibo();
	}

    private void Funcionarios(object sender, EventArgs args)
	{
		Application.Current.MainPage = new Funcionarios();
	}
    
    }
}
