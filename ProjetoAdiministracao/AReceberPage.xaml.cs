using LiteDBExample.Modelos;
using Microsoft.Maui.Controls;
using System;

namespace ProjetoAdiministracao;

public partial class AReceberPage : ContentPage
{
    CadastroFuncionarios cf;
    AReceber receber;
    AReceberControle receberControle;
    public AReceberPage()
    {
        InitializeComponent();
        cf = new CadastroFuncionarios();
        receber = new AReceber();
        receberControle = new AReceberControle();
        ListaAReceberPage.ItemsSource = receberControle.LerTodos();
    }

    private void SelecionarNaTelaFuncionarios(object sender, EventArgs e)
    {
        Application.Current.MainPage = new DicionarAReceber();
    }
    //-----------------------------Comprender o do professor-----------------------\\


    void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
    {
        var page = new DicionarAReceber();

        page.receber = e.SelectedItem as AReceber;

        Application.Current.MainPage = page;
    }

    //-----------------------------Comprender o do professor-----------------------\\

    private void Voltar(object sender, EventArgs e)
    {
        Application.Current.MainPage = new Menu();
    }
}



