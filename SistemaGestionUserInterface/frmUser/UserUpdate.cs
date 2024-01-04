using SistemaGestionBussines;
using SistemaGestionEntities;
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

namespace SistemaGestionUserInterface.frmUser
{
    public partial class UserUpdate : Form
    {
        private User _user;
        public UserUpdate()
        {
            InitializeComponent();
        }

        public UserUpdate(User user)
        {
            InitializeComponent();
            this._user = user;
        }

        private async Task<bool> UpdateUser(User user)
        {
            try
            {
                HttpClient client = new HttpClient();
                string path = @"https://localhost:7196/api/User";
                HttpResponseMessage response = await client.PutAsJsonAsync(path, user);
                response.EnsureSuccessStatusCode();
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Se actualizo correctamente los datos del cliente");
                    this.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al intentar actualizar los datos del cliente");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }

        }

        private void UserUpdate_Load(object sender, EventArgs e)
        {
            txtName.Text = this._user.NameUser;
            txtSurname.Text = this._user.Surname;
            txtUser.Text = this._user.Username;
            txtEmail.Text = this._user.Email;
            txtPassword.Text = this._user.Password;
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {   
            this._user.NameUser = txtName.Text;
            this._user.Surname = txtSurname.Text;
            this._user.Username = txtUser.Text;
            this._user.Email = txtEmail.Text;
            this._user.Password = txtPassword.Text;

            this.UpdateUser(this._user);
        }
    }
}
