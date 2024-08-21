using LiteDBExample.Modelos;
using Microsoft.Maui.Controls;
using System;

namespace ProjetoAdiministracao;

public partial class Dividas : ContentPage
{
    public Int64 IdDividas;
    CadastroFuncionarios cf;
    Divida divida;
    ClienteControle clienteControle;
    public Dividas()
    {
        InitializeComponent();
        cf = new CadastroFuncionarios();
        divida = new Divida();
        clienteControle = new ClienteControle();
        ListaClientes.ItemsSource = clienteControle.LerTodos();
    }

    private void SelecionarNaTelaFuncionarios(object sender, EventArgs e)
    {
        Application.Current.MainPage = new DicionarDividas();
    }
    //-----------------------------Comprender o do professor-----------------------\\


    void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
    {
        var page = new CadastroFuncionarios();

        page.cliente = e.SelectedItem as Cliente;

        Application.Current.MainPage = page;
    }

    //-----------------------------Comprender o do professor-----------------------\\

    private void Voltar(object sender, EventArgs e)
    {
        Application.Current.MainPage = new Menu();
    }
}



