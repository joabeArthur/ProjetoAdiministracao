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
            NameEntry.Text = string.Empty;
            CPFEntry.Text = string.Empty;
            RGEntry.Text = string.Empty;
            WorkHoursEntry.Text = string.Empty;
            SalaryEntry.Text = string.Empty;
        }
                                      
        public void Registrar()
        {
            base.OnAppearing();

           clienteControle.Ler(cliente.Id);
           

           IdEntry.Text = cliente.Id.ToString();
           cliente.Nome = NameEntry.Text;
           cliente.CPF = CPFEntry.Text;
           cliente.RG = RGEntry.Text;
           cliente.Horario = WorkHoursEntry.Text;
           cliente.Salario = SalaryEntry.Text;

           
        }

        private void Voltar(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Menu();
        }
    }

