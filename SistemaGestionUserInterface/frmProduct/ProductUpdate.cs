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
    public partial class ProductUpdate : Form
    {
        private Product _product;
        public ProductUpdate()
        {
            InitializeComponent();
        }
        public ProductUpdate(Product product)
        {
            InitializeComponent();
            this._product = product;
        }


        private async Task<bool> UpdateProduct(Product product)
        {
            try
            {
                HttpClient client = new HttpClient();
                string path = @"https://localhost:7196/api/Product";
                HttpResponseMessage response = await client.PutAsJsonAsync(path, product);
                response.EnsureSuccessStatusCode();
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Se actualizo correctamente el producto");
                    this.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al intentar actualizar el producto");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }

        }
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            this._product.Description = txtDescription.Text;
            this._product.Cost = Convert.ToDecimal(txtCost.Text);
            this._product.SalePrice = Convert.ToDecimal(txtPriceSale.Text);
            this._product.Stock = Convert.ToInt32(txtStock.Text);
            this._product.IdUser = Convert.ToInt32(txtIdUser.Text);

            this.UpdateProduct(this._product);
        }

        private void ProductUpdate_Load(object sender, EventArgs e)
        {
            
            this.txtDescription.Text = this._product.Description;
            this.txtCost.Text = this._product.Cost.ToString();
            this.txtPriceSale.Text = this._product.SalePrice.ToString();
            this.txtStock.Text = this._product.Stock.ToString();
            this.txtIdUser.Text = this._product.IdUser.ToString();
        }
    }
}
