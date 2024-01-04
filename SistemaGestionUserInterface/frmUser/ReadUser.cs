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
    public partial class ReadUser : Form
    {
        public ReadUser()
        {
            InitializeComponent();
        }

        private async Task LoadUser()
        {
            HttpClient client = new HttpClient();

            List<User>? listUser = null;
            try
            {
                string path = @"https://localhost:7196/api/User";
                HttpResponseMessage response = await client.GetAsync(path);

                if (response.IsSuccessStatusCode)
                {
                    listUser = await response.Content.ReadFromJsonAsync<List<User>>();
                    dtgvUsers.AutoGenerateColumns = false;
                    dtgvUsers.DataSource = listUser;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de comunicacionn con la API");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var formHome = new Home.Home();
            formHome.Show();
            this.Close();
        }
        private void ReadUser_Load(object sender, EventArgs e)
        {
            this.LoadUser();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            var formUserCreate = new UserCreate();
            formUserCreate.FormClosed += FormUserCreate_FormClosed;
            formUserCreate.ShowDialog();
        }

        private void FormUserCreate_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.LoadUser();
        }

        private void dtgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            int Id = (int)this.dtgvUsers.Rows[e.RowIndex].Cells["Id"].Value;

            User user = UserBussines.LoadUser().Where(x => x.Id == Id).FirstOrDefault();

            if (this.dtgvUsers.Columns[e.ColumnIndex].Name == "Update")
            {

                var frmUpdateUser = new UserUpdate(user);
                frmUpdateUser.FormClosed += FormUserCreate_FormClosed;
                frmUpdateUser.ShowDialog();
            }
            else if (this.dtgvUsers.Columns[e.ColumnIndex].Name == "Delete")
            {
                var frmDeleteUser = new UserDelete(user);
                frmDeleteUser.FormClosed += FormUserCreate_FormClosed;
                frmDeleteUser.ShowDialog();
            }
        }
    }
}
