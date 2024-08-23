using LiteDBExample.Modelos;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;

namespace ProjetoAdiministracao;

public partial class DicionarAReceber : ContentPage
{
  public AReceber receber;
  public AReceberControle receberControle;

  public DicionarAReceber()
  {
    InitializeComponent();
    receber = new AReceber();
    receberControle = new AReceberControle();
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
    receberControle.Apagar(receber.Id);
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

    if (receber != null)
    {
      IdLabel.Text = receber.Id.ToString();
      NameEntry.Text = receber.Nome;
      ValorEntry.Text = receber.Valor;
      DataEntry.Text = receber.Data;
      CPFEntry.Text = receber.CPF;
    }
  }


  //---------------------------------------------------------------------------------------------------------------------\\

  private async void Salvar(object sender, EventArgs e)
  {
    if (await VerificaSeDadosEstaoCorretos()) 
    {


      if (!String.IsNullOrEmpty(IdLabel.Text))
        receber.Id = int.Parse(IdLabel.Text);
      else
        receber.Id = 0;
      receber.Nome = NameEntry.Text;
      receber.Data = DataEntry.Text;
      receber.CPF = CPFEntry.Text;
      receber.Valor = ValorEntry.Text;


      
      receberControle.CriarOuAtualizar(receber);

      await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");

      if (receber.Nome == null || receber.CPF == null)
      {
        FrameErro.IsVisible = true;
      }
      else
      {
        Application.Current.MainPage = new AReceberPage();
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

