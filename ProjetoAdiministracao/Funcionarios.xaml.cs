using Microsoft.Maui.Controls;
using System;

namespace ProjetoAdiministracao;

    public partial class Funcionarios : ContentPage
    {   
        CadastroFuncionarios cf;
        public Funcionarios()
        {
            InitializeComponent();
            cf = new CadastroFuncionarios();
        }

        private void Apagar(object sender, EventArgs e)
        {
            NameEntry.Text = string.Empty;
            CPFEntry.Text = string.Empty;
            RGEntry.Text = string.Empty;
            WorkHoursEntry.Text = string.Empty;
            SalaryEntry.Text = string.Empty;
        }
                                      
        private void Registrar(object sender, EventArgs e)
        {
            cf.CadastroFuncionariosSalvar();

            NameEntry.Text = cf.name.ToLower();
            CPFEntry.Text = cf.CPF.ToUpper();
            RGEntry.Text = cf.RG;
            WorkHoursEntry.Text = cf.horario;
            SalaryEntry.Text = cf.salario;
        }

        private void Voltar(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Menu();
        }
    }

