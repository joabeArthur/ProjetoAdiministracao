using LiteDBExample.Modelos;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;

namespace ProjetoAdiministracao;

public partial class DicionarDividas : ContentPage
{
  public DividasControle dividasControle;
  public Divida divida;

  public DicionarDividas()
  {
    InitializeComponent();
    divida = new Divida();
    dividasControle = new DividasControle();
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
    dividasControle.Apagar(divida.Id);
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

    if (divida != null)
    {
      IdLabel.Text = divida.Id.ToString();
      NameEntry.Text = divida.Nome;
      ValorEntry.Text = divida.Valor;
      DataEntry.Text = divida.Data;
      CPFEntry.Text = divida.CPF;
    }
  }


  //---------------------------------------------------------------------------------------------------------------------\\

  private async void Salvar(object sender, EventArgs e)
  {
    if (await VerificaSeDadosEstaoCorretos()) 
    {


      if (!String.IsNullOrEmpty(IdLabel.Text))
        divida.Id = int.Parse(IdLabel.Text);
      else
        divida.Id = 0;
      divida.Nome = NameEntry.Text;
      divida.Data = DataEntry.Text;
      divida.CPF = CPFEntry.Text;
      divida.Valor = ValorEntry.Text;


      
      dividasControle.CriarOuAtualizar(divida);

      await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");

      if (divida.Nome == null || divida.CPF == null)
      {
        FrameErro.IsVisible = true;
      }
      else
      {
        Application.Current.MainPage = new Dividas();
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

