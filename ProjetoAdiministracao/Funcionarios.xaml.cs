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
        }

        private void Apagar(object sender, EventArgs e)
        {
            NomeLabel.Text = string.Empty;
            CPFLabel.Text = string.Empty;
            RGLabel.Text = string.Empty;
            HorarioLabel.Text = string.Empty;
            SalarioLabel.Text = string.Empty;
        }
                                      
        public void Registrar(object sender, EventArgs e)
        {
           clienteControle.Ler(cliente.Id);
           

           IdLabel.Text = cliente.Id.ToString();
           cliente.Nome = NomeLabel.Text;
           cliente.CPF = CPFLabel.Text;
           cliente.RG = RGLabel.Text;
           cliente.Horario = HorarioLabel.Text;
           cliente.Salario = SalarioLabel.Text;

           
        }

        private void Voltar(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Menu();
        }
    }

