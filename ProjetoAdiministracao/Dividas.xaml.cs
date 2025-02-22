using LiteDBExample.Modelos;
using Microsoft.Maui.Controls;
using System;

namespace ProjetoAdiministracao;

public partial class Dividas : ContentPage
{
    CadastroFuncionarios cf;
    Divida divida;
    DividasControle dividasControle;

    public Dividas()
    {
        InitializeComponent();
        cf = new CadastroFuncionarios();
        divida = new Divida();
        dividasControle = new DividasControle();
        ListaDivida.ItemsSource = dividasControle.LerTodos();
    }

    private void SelecionarNaTelaFuncionarios(object sender, EventArgs e)
    {
        Application.Current.MainPage = new DicionarDividas();
    }

    void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
    {
        var page = new DicionarDividas();

        page.divida = e.SelectedItem as Divida;

        Application.Current.MainPage = page;
    }

    private void Voltar(object sender, EventArgs e)
    {
        Application.Current.MainPage = new Menu();
    }
}



