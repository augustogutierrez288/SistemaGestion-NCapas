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
    public partial class ProductSoldUpdate : Form
    {
        private ProductSold _productSold;
        public ProductSoldUpdate()
        {
            InitializeComponent();
        }

        public ProductSoldUpdate(ProductSold productSold)
        {
            InitializeComponent();
            this._productSold = productSold;
        }

        private async Task<bool> UpdateProductSold(ProductSold productSold)
        {
            try
            {
                HttpClient client = new HttpClient();
                string path = @"https://localhost:7196/api/ProductSold";
                HttpResponseMessage response = await client.PutAsJsonAsync(path, productSold);
                response.EnsureSuccessStatusCode();
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Se actualizo correctamente el producto vendido");
                    this.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al intentar actualizar el producto vendido");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }

        }
        private void ProductSoldUpdate_Load(object sender, EventArgs e)
        {
            txtStock.Text = this._productSold.Stock.ToString();
            txtIdProduct.Text = this._productSold.IdProduct.ToString();
            txtIdSold.Text = this._productSold.IdSold.ToString();
        }

        private void btnUpdateProductSold_Click(object sender, EventArgs e)
        {
            this._productSold.Stock = Convert.ToInt32(txtStock.Text);
            this._productSold.IdProduct = Convert.ToInt32(txtIdProduct.Text);
            this._productSold.IdSold = Convert.ToInt32(txtIdSold.Text);

            this.UpdateProductSold(this._productSold);
        }
    }
}
