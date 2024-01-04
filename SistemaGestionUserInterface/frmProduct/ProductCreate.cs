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
    public partial class ProductCreate : Form
    {
        public ProductCreate()
        {
            InitializeComponent();
        }

        private async Task<bool> CreateProduct(Product product)
        {
            try
            {
                HttpClient client = new HttpClient();
                string path = @"https://localhost:7196/api/Product";
                HttpResponseMessage response = await client.PostAsJsonAsync(path, product);
                response.EnsureSuccessStatusCode();
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show($"Se creo correctamente el producto: {product.Description}");
                    this.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al intentar crear el producto");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }

        }
        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Description = txtDescription.Text;
            product.Cost = Convert.ToDecimal(txtCost.Text);
            product.SalePrice = Convert.ToDecimal(txtPriceSale.Text);
            product.Stock = Convert.ToInt32(txtStock.Text);
            product.IdUser = Convert.ToInt32(txtIdUser.Text);

            this.CreateProduct(product);
        }

        private void ProductCreate_Load(object sender, EventArgs e)
        {

        }
    }
}
