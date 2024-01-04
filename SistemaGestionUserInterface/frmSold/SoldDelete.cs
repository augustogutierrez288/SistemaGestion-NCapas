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

namespace SistemaGestionUserInterface.frmSold
{
    public partial class SoldDelete : Form
    {
        private Sold _sale;
        public SoldDelete()
        {
            InitializeComponent();
        }

        public SoldDelete(Sold sale)
        {
            InitializeComponent();
            this._sale = sale;
        }

        private async Task<bool> DeleteSold(Sold sold)
        {
            HttpClient client = new HttpClient();
            string path = @"https://localhost:7196/api/Sold";
            try
            {
                HttpRequestMessage request = new HttpRequestMessage
                {
                    Content = JsonContent.Create(sold),
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri(path, UriKind.Absolute)
                };
                HttpResponseMessage response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Se elimino correctamente la venta");
                    this.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al intentar eliminar la venta");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }

        private void SoldDelete_Load(object sender, EventArgs e)
        {
            txtCommit.Text = this._sale.Commit;
            txtIDUser.Text = this._sale.IdUser.ToString();
        }

        private void btnDeleteSold_Click(object sender, EventArgs e)
        {
            this.DeleteSold(this._sale);
            
        }
    }
}
