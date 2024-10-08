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
    //-----------------------------Comprender o do professor-----------------------\\


    void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
    {
        var page = new DicionarDividas();

        page.divida = e.SelectedItem as Divida;

        Application.Current.MainPage = page;
    }

    //-----------------------------Comprender o do professor-----------------------\\

    private void Voltar(object sender, EventArgs e)
    {
        Application.Current.MainPage = new Menu();
    }
}



