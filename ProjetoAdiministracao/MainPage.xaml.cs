namespace ProjetoAdiministracao;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void TrocaDeTela(object sender, EventArgs args)
	{
		Application.Current.MainPage = new Login();
	}

}