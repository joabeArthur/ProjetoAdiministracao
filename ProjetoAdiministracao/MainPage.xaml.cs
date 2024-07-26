namespace ProjetoAdiministracao;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void Menu(object sender, EventArgs args)
	{
		Application.Current.MainPage = new Menu();
	}

	private void Login(object sender, EventArgs args)
	{
		Application.Current.MainPage = new Login();
	}

	private void TelaInicial(object sender, EventArgs args)
	{
		Application.Current.MainPage = new TelaInicial();
	}

	private void Cadastro(object sender, EventArgs args)
	{
		Application.Current.MainPage = new Cadastro();
	}

	private void ContasApagagar(object sender, EventArgs args)
	{
		Application.Current.MainPage = new ContasApagagar();
	}

}