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
    public partial class ProductSoldCreate : Form
    {
        public ProductSoldCreate()
        {
            InitializeComponent();
        }

        private async Task<bool> CreateProductSold(ProductSold productSold)
        {
            try
            {
                HttpClient client = new HttpClient();
                string path = @"https://localhost:7196/api/ProductSold";
                HttpResponseMessage response = await client.PostAsJsonAsync(path, productSold);
                response.EnsureSuccessStatusCode();
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show($"Se cargo correctamente el producto vendido");
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
        private void btnCreateProductSold_Click(object sender, EventArgs e)
        {
            ProductSold productSold = new ProductSold();
            productSold.Stock = Convert.ToInt32(txtStock.Text);
            productSold.IdProduct = Convert.ToInt32(txtIdProduct.Text);
            productSold.IdSold = Convert.ToInt32(txtIdSold.Text);

            this.CreateProductSold(productSold);

        }

        private void ProductSoldCreate_Load(object sender, EventArgs e)
        {

        }
    }
}
