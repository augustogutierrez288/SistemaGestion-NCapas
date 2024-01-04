using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestionBussines;
using SistemaGestionEntities;

namespace SistemaGestionUserInterface.frmUser
{
    public partial class UserCreate : Form
    {
        public UserCreate()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async Task<bool> CreateUser(User user)
        {
            try
            {
                HttpClient client = new HttpClient();
                string path = @"https://localhost:7196/api/User";
                HttpResponseMessage response = await client.PostAsJsonAsync(path, user);
                response.EnsureSuccessStatusCode();
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show($"Se cargo correctamente el cliente");
                    this.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al intentar cargar al cliente");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.NameUser = txtName.Text;
            user.Surname = txtSurname.Text;
            user.Username = txtUser.Text;
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;

            this.CreateUser(user);
        }
    }
}
