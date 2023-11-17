using SistemaGestionUserInterface.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUserInterface.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string valueUser = txtUsername.Text;
            string valuePassword = txtPassword.Text;

            if (valueUser == "admin" && valuePassword == "1234")
            {
                var  home = new Home.Home();
                home.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
            }
        }
    }
}
