using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;


namespace ProjetoAdiministracao;

    public partial class CadastroFuncionarios : ContentPage
    {

        public string name;
        public string CPF;
        public string RG;
        public string horario;
        public string salario;
        public CadastroFuncionarios()
        {
            InitializeComponent();
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

        public void CadastroFuncionariosSalvar()
        {
            this.name = NameEntry.Text;
            this.CPF = CPFEntry.Text;
            this.RG = RGEntry.Text;
            this.horario = HorarioEntry.Text;
            this.salario = SalarioEntry.Text;

            if (name == null || CPF == null || RG == null || horario == null || salario == null)
            {
                FrameErro.IsVisible = true;
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

