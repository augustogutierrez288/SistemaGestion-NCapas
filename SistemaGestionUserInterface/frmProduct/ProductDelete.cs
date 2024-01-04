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

namespace SistemaGestionUserInterface.frmProduct
{
    public partial class ProductDelete : Form
    {
        private Product _product;
        public ProductDelete()
        {
            InitializeComponent();
        }
        public ProductDelete(Product product)
        {
            InitializeComponent();
            this._product = product;
        }

        private async Task<bool> DeleteProduct(Product product)
        {
            HttpClient client = new HttpClient();
            string path = @"https://localhost:7196/api/Product";
            try
            {
                HttpRequestMessage request = new HttpRequestMessage
                {
                    Content = JsonContent.Create(product),
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri(path, UriKind.Absolute)
                };
                HttpResponseMessage response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                if(response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Se elimino correctamente el producto");
                    this.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al intentar eliminar el producto");
                    return false;
                }
            }catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            this.DeleteProduct(this._product);
        }

        private void ProductDelete_Load(object sender, EventArgs e)
        {
            this.txtDescription.Text = this._product.Description;
            this.txtCost.Text = this._product.Cost.ToString();
            this.txtPriceSale.Text = this._product.SalePrice.ToString();
            this.txtStock.Text = this._product.Stock.ToString();
            this.txtIdUser.Text = this._product.IdUser.ToString();
        }
    }
}
