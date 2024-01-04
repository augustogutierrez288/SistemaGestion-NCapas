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

namespace SistemaGestionUserInterface.frmSold
{
    public partial class SoldUpdate : Form
    {
        private Sold _sale;
        public SoldUpdate()
        {
            InitializeComponent();
        }

        public SoldUpdate(Sold sale)
        {
            InitializeComponent();
            this._sale = sale;
        }

        private async Task<bool> UpdateSold(Sold sold)
        {
            try
            {
                HttpClient client = new HttpClient();
                string path = @"https://localhost:7196/api/Sold";
                HttpResponseMessage response = await client.PutAsJsonAsync(path, sold);
                response.EnsureSuccessStatusCode();
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Se actualizo correctamente la venta");
                    this.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al intentar actualizar la venta");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }

        }

        private void SoldUpdate_Load(object sender, EventArgs e)
        {
            txtCommit.Text = this._sale.Commit;
            txtIDUser.Text = this._sale.IdUser.ToString();
        }

        private void btnUpdateSold_Click(object sender, EventArgs e)
        {
            this._sale.Commit = txtCommit.Text;
            this._sale.IdUser = Convert.ToInt32(txtIDUser.Text);

            this.UpdateSold(this._sale);
        }
    }
}
