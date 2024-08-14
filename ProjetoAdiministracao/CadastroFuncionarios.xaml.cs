using LiteDBExample.Modelos;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;

namespace ProjetoAdiministracao;

public partial class CadastroFuncionarios : ContentPage
{
    public Cliente cliente;
    public ClienteControle clienteControle;
    
    public CadastroFuncionarios()
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
        RGEntry.Text = string.Empty;
        HorarioEntry.Text = string.Empty;
        SalarioEntry.Text = string.Empty;

    }

//---------------------------------------------------------------------------------------------------------------------\\

    private async void Salvar(object sender, EventArgs e)
    {
        if (await VerificaSeDadosEstaoCorretos()) // Verifica se os dados são válidos antes de salvar no banco
        {
            // O código abaixo preenche o objeto cliente (Modelo) com os dados das Entry's
            
            if (!String.IsNullOrEmpty(IdEntry.Text))
                cliente.Id = int.Parse(IdEntry.Text);
            else
                cliente.Id = 0;
            cliente.Nome = NameEntry.Text;
            cliente.RG = RGEntry.Text;
            cliente.CPF = CPFEntry.Text;
            cliente.Horario = HorarioEntry.Text;
            cliente.Salario = SalarioEntry.Text;


            // Com o objeto preenchido enviamos para o controle para criar/atualizar no Banco de Dados
            clienteControle.CriarOuAtualizar(cliente);
            // Mostra a mensagem de sucesso
            await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");

            if (cliente.Nome == null || cliente.CPF == null || cliente.RG == null || cliente.Horario == null || cliente.Salario == null)
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
    else if (String.IsNullOrEmpty(RGEntry.Text))
    {
      await DisplayAlert("Cadastrar", "O campo RG é obrigatório", "OK");
      return false;
    }
    else if (String.IsNullOrEmpty(CPFEntry.Text))
    {
      await DisplayAlert("Cadastrar", "O campo CPF é obrigatório", "OK");
      return false;
    }
    else if (String.IsNullOrEmpty(HorarioEntry.Text))
    {
      await DisplayAlert("Cadastrar", "O campo Horario é obrigatório", "OK");
      return false;
    }
    else if (String.IsNullOrEmpty(SalarioEntry.Text))
    {
      await DisplayAlert("Cadastrar", "O campo Salario é obrigatório", "OK");
      return false;
    }
    else
      return true;
    }

//---------------------------------------------------------------------------------------------------------------------\\
   // public void Salvar(object sender, EventArgs e)
  //  {
   //     cliente.Nome = NameEntry.Text;
    //    cliente.CPF = CPFEntry.Text;
    //    cliente.RG = RGEntry.Text;
    //    cliente.Horario = HorarioEntry.Text;
     //   cliente.Salario = SalarioEntry.Text;
//
    //    if (cliente.Nome == null || cliente.CPF == null || cliente.RG == null || cliente.Horario == null || cliente.Salario == null)
     //   {
    //        FrameErro.IsVisible = true;
     //   }
     //   else
     //   {
            
      //      clienteControle.CriarOuAtualizar(cliente);
      //      clienteControle.Ler(cliente.Id);
       //     Application.Current.MainPage = new Funcionarios();
     //   }
   // }

//---------------------------------------------------------------------------------------------------------------------\\

    private void TentarDeNovo(object sender, EventArgs e)
    {
        FrameErro.IsVisible = false;
    }

    private void Voltar(object sender, EventArgs e)
    {
        Application.Current.MainPage = new Menu();
    }
}

