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

namespace SistemaGestionUserInterface.frmProductSold
{
    public partial class ProductSoldDelete : Form
    {
        private ProductSold _productSold;
        public ProductSoldDelete()
        {
            InitializeComponent();
        }
        public ProductSoldDelete(ProductSold productSold)
        {
            InitializeComponent();
            this._productSold = productSold;
        }

        private async Task<bool> DeleteProductSold(ProductSold productSold)
        {
            HttpClient client = new HttpClient();
            string path = @"https://localhost:7196/api/ProductSold";
            try
            {
                HttpRequestMessage request = new HttpRequestMessage
                {
                    Content = JsonContent.Create(productSold),
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri(path, UriKind.Absolute)
                };
                HttpResponseMessage response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Se elimino correctamente el producto vendido");
                    this.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al intentar eliminar el producto vendido");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }
        private void ProductSoldDelete_Load(object sender, EventArgs e)
        {
            txtStock.Text = this._productSold.Stock.ToString();
            txtIdProduct.Text = this._productSold.IdProduct.ToString();
            txtIdSold.Text = this._productSold.IdSold.ToString();
        }

        private void btnDeleteProductSold_Click(object sender, EventArgs e)
        {
            this.DeleteProductSold(this._productSold);
        }
    }
}
