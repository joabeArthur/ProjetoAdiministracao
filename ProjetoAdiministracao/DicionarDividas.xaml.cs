using LiteDBExample.Modelos;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;

namespace ProjetoAdiministracao;

public partial class DicionarDividas : ContentPage
{
  public Cliente cliente;
  public ClienteControle clienteControle;

  public DicionarDividas()
  {
    InitializeComponent();
    cliente = new Cliente();
    clienteControle = new ClienteControle();
  }

  //---------------------------------------------------------------------------------------------------------------------\\

  private void Apagar(object sender, EventArgs e)
  {
    // Handle the trash button click event
    NameEntry.Text = string.Empty;
    CPFEntry.Text = string.Empty;
    DataEntry.Text = string.Empty;
    ValorEntry.Text = string.Empty;

  }

  private void Excluir(object sender, EventArgs e)
  {
    FrameAviso.IsVisible = true;
  }

  private void Certeza(object sender, EventArgs e)
  {
    clienteControle.Apagar(cliente.Id);
    FrameAviso.IsVisible = false;
    Application.Current.MainPage = new Funcionarios();
  }

  private void NaoExcluir(object sender, EventArgs e)
  {
    FrameAviso.IsVisible = false;
  }
  //---------------------------------------------------------------------------------------------------------------------\\

  protected override void OnAppearing()
  {
    base.OnAppearing();

    if (cliente != null)
    {
      IdLabel.Text = cliente.Id.ToString();
      NameEntry.Text = cliente.Nome;
      ValorEntry.Text = cliente.Valor;
      DataEntry.Text = cliente.Data;
      CPFEntry.Text = cliente.CPF;
    }
  }


  //---------------------------------------------------------------------------------------------------------------------\\

  private async void Salvar(object sender, EventArgs e)
  {
    if (await VerificaSeDadosEstaoCorretos()) 
    {


      if (!String.IsNullOrEmpty(IdLabel.Text))
        cliente.Id = int.Parse(IdLabel.Text);
      else
        cliente.Id = 0;
      cliente.Nome = NameEntry.Text;
      cliente.Data = DataEntry.Text;
      cliente.CPF = CPFEntry.Text;
      cliente.Valor = ValorEntry.Text;


      
      clienteControle.CriarOuAtualizar(cliente);

      await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");

      if (cliente.Nome == null || cliente.CPF == null)
      {
        FrameErro.IsVisible = true;
      }
      else
      {
        clienteControle.Ler(cliente.Id);
        Application.Current.MainPage = new Funcionarios();
      }

    }
  }

  //---------------------------------------------------------------------------------------------------------------------\\

  private async Task<bool> VerificaSeDadosEstaoCorretos()
  {
    // Verifica se a Entry do Nome está vazia
    if (String.IsNullOrEmpty(NameEntry.Text))
    {
      await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
      return false;
    }
    else if (String.IsNullOrEmpty(DataEntry.Text))
    {
      await DisplayAlert("Cadastrar", "O campo RG é obrigatório", "OK");
      return false;
    }
    else if (String.IsNullOrEmpty(CPFEntry.Text))
    {
      await DisplayAlert("Cadastrar", "O campo CPF é obrigatório", "OK");
      return false;
    }
    else if (String.IsNullOrEmpty(ValorEntry.Text))
    {
      await DisplayAlert("Cadastrar", "O campo Horario é obrigatório", "OK");
      return false;
    }
    else
      return true;
  }

  private void TentarDeNovo(object sender, EventArgs e)
  {
    FrameErro.IsVisible = false;
  }

  private void Voltar(object sender, EventArgs e)
  {
    Application.Current.MainPage = new Menu();
  }
}

