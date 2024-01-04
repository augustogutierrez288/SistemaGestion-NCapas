using SistemaGestionBussines;
using SistemaGestionEntities;
using SistemaGestionUserInterface.Home;
using SistemaGestionUserInterface.frmProduct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Sockets;
using System.Net.Http.Json;

namespace SistemaGestionUserInterface.frmProduct
{
    public partial class ProductRead : Form
    {
        public ProductRead()
        {
            InitializeComponent();
        }

        private async Task LoadProduct()
        {
            HttpClient client = new HttpClient();

            List<Product>? listProduct = null;
            try
            {
                string path = @"https://localhost:7196/api/Product";
                HttpResponseMessage response = await client.GetAsync(path);

                if(response.IsSuccessStatusCode)
                {
                    listProduct = await response.Content.ReadFromJsonAsync<List<Product>>();
                    dtgbProduct.AutoGenerateColumns = false;
                    dtgbProduct.DataSource = listProduct;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de comunicacionn con la API");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var home = new Home.Home();
            home.Show();
            this.Close();

        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            var formProductCreate = new ProductCreate();
            formProductCreate.FormClosed += FormProductCreate_FormClosed;
            formProductCreate.ShowDialog();

        }
        private void Product_Load(object sender, EventArgs e)
        {
            this.LoadProduct();
        }

        private void FormProductCreate_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.LoadProduct();
        }

        private void dtgbProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            int Id = (int)this.dtgbProduct.Rows[e.RowIndex].Cells["Id"].Value;

            Product product = ProductBussines.LoadProduct().Where(x => x.Id == Id).FirstOrDefault();

            if (this.dtgbProduct.Columns[e.ColumnIndex].Name == "Update")
            {

                var frmUpdateProduct = new ProductUpdate(product);
                frmUpdateProduct.FormClosed += FormProductCreate_FormClosed;
                frmUpdateProduct.ShowDialog();
            }
            else if (this.dtgbProduct.Columns[e.ColumnIndex].Name == "Delete")
            {
                var frmDeleteProduct = new ProductDelete(product);
                frmDeleteProduct.FormClosed += FormProductCreate_FormClosed;
                frmDeleteProduct.ShowDialog();
            }
        }
    }
}
