using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.NameUser = txtName.Text;
            user.Surname = txtSurname.Text;
            user.Username = txtUser.Text;
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;

            UserBussines.CreateUser(user);

            MessageBox.Show("Usuario creado con exito");
        }
    }
}
