using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestionEntities;
using SistemaGestionBussines;
using System.Net.Http.Json;

namespace SistemaGestionUserInterface.frmSold
{
    public partial class SoldCreate : Form
    {
        public SoldCreate()
        {
            InitializeComponent();
        }

        private async Task<bool> CreateSold(Sold sold)
        {
            try
            {
                HttpClient client = new HttpClient();
                string path = @"https://localhost:7196/api/Sold";
                HttpResponseMessage response = await client.PostAsJsonAsync(path, sold);
                response.EnsureSuccessStatusCode();
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show($"Se cargo correctamente la venta");
                    this.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al intentar cargar la venta");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }

        }
        private void btnCreateSold_Click(object sender, EventArgs e)
        {
            Sold sale = new Sold();
            
            sale.Commit = txtCommit.Text;
            sale.IdUser = Convert.ToInt32(txtIDUser.Text);

            this.CreateSold(sale);
        }
    }
}
