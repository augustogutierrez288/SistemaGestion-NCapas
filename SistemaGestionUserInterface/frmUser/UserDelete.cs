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
            UserBussines.DeleteUser(this._user);

            MessageBox.Show("Usuario borrado con exito");
        }
    }
}
