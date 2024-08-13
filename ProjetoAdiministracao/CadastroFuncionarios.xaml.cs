using LiteDBExample.Modelos;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;


namespace ProjetoAdiministracao;

    public partial class CadastroFuncionarios : ContentPage
    {
        Cliente cliente;
        public CadastroFuncionarios()
        {
            InitializeComponent();
             cliente = new Cliente();
        }

        private void Apagar(object sender, EventArgs e)
        {
            // Handle the trash button click event
            NameEntry.Text = string.Empty;
            CPFEntry.Text = string.Empty;
            RGEntry.Text = string.Empty;
            HorarioEntry.Text = string.Empty;
            SalarioEntry.Text = string.Empty;
            
        }

        public void Salvar(object sender, EventArgs e)
        {
             cliente.Nome = NameEntry.Text;
             cliente.CPF = CPFEntry.Text;
             cliente.RG = RGEntry.Text;
             cliente.Horario = HorarioEntry.Text;
             cliente.Salario = SalarioEntry.Text;

            if (cliente.Nome == null || cliente.CPF == null || cliente.RG == null || cliente.Horario == null || cliente.Salario == null)
            {
                FrameErro.IsVisible = true;
            } 
            else
            {
                Application.Current.MainPage = new Funcionarios();
            }
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

