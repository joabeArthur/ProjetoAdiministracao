using LiteDBExample.Modelos;
using Microsoft.Maui.Controls;
using System;

namespace ProjetoAdiministracao;

public partial class Funcionarios : ContentPage
{
    CadastroFuncionarios cf;
    Cliente cliente;
    ClienteControle clienteControle;
    public Funcionarios()
    {
        InitializeComponent();
        cf = new CadastroFuncionarios();
        cliente = new Cliente();
        clienteControle = new ClienteControle();
        ListaClientes.ItemsSource = clienteControle.LerTodos();
    }

    private void SelecionarNaTelaFuncionarios(object sender, EventArgs e)
    {
        Application.Current.MainPage = new CadastroFuncionarios();
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

