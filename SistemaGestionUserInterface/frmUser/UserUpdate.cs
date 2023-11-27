using SistemaGestionBussines;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            UserBussines.UpdateUser(_user);
            MessageBox.Show("Usuario modificado con exito");
        }
    }
}
