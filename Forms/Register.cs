using SenacPDV.Context;
using SenacPDV.Models;
using SenacPDV.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SenacPDV.Forms
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            LoadRoles();
        }
        private void LoadRoles()
        {
            using var db = new PdvDbContext();
            var roles = db.Roles.ToList();
            cmbTipo.DataSource = roles;
            cmbTipo.DisplayMember = "Name";
            cmbTipo.ValueMember = "Id";
        }


        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void BTNRegister_Click(object sender, EventArgs e)
        {
            string username = TxtUsername.Text.Trim();
            string email = TxtEmail.Text.Trim();
            string password = TxtSenha.Text.Trim();
            string confirm = TxtConfirmarSenha.Text.Trim();
            string selectedRole = (cmbTipo.SelectedItem as Role)?.Name;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Todos os campos são obrigatórios");
                return;
            }
            bool success = AuthService.registerUser(username, email, password, selectedRole);
            if (success)
            {
                MessageBox.Show("Usuário cadastrado com sucesso! Faça Login");
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar usuário. Verifique os dados e tente novamente.");

            }


        }
    }
}
