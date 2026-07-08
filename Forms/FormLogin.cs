using SenacPDV.Models;
using SenacPDV.Services;

namespace SenacPDV.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = TxtUser.Text.Trim();
            string password = TxtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Preencha usuário e senha.");
                return;
            }

            var user = AuthService.Authenticate(username, password);
            if (user != null)
            {
                
                if (AuthService.IsInRole(user, "Admin"))
                {
                    var admin = new FormAdmin();
                    admin.ShowDialog();
                    this.Close();
                }
                else
                {
                    var userForm = new FormUser();
                    userForm.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos");
            }

        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
