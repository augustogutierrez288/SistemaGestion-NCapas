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
    public partial class UserDelete : Form
    {
        private User _user;
        public UserDelete()
        {
            InitializeComponent();
        }

        public UserDelete(User user)
        {
            InitializeComponent();
            this._user = user;
        }

        private async Task<bool> DeleteUser(User user)
        {
            HttpClient client = new HttpClient();
            string path = @"https://localhost:7196/api/User";
            try
            {
                HttpRequestMessage request = new HttpRequestMessage
                {
                    Content = JsonContent.Create(user),
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri(path, UriKind.Absolute)
                };
                HttpResponseMessage response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Se elimino correctamente al cliente");
                    this.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al intentar eliminar al cliente");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }
        private void UserDelete_Load(object sender, EventArgs e)
        {
            txtName.Text = this._user.NameUser;
            txtSurname.Text = this._user.Surname;
            txtUser.Text = this._user.Username;
            txtEmail.Text = this._user.Email;
            txtPassword.Text = this._user.Password;
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            this.DeleteUser(this._user);
        }
    }
}
