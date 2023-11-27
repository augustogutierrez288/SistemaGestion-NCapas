using SistemaGestionBussines;
using SistemaGestionEntities;
using SistemaGestionUserInterface;
using SistemaGestionUserInterface.frmProduct;
using SistemaGestionUserInterface.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUserInterface.frmProductSold
{
    public partial class ProductSoldRead : Form
    {
        public ProductSoldRead()
        {
            InitializeComponent();
        }

        private void LoadProductSold()
        {
            List<ProductSold> listProductSale = ProductSoldBussines.LoadProductSold();
            dtgvProductSold.AutoGenerateColumns = false;
            dtgvProductSold.DataSource = listProductSale;
        }
        private void ProductSoldRead_Load(object sender, EventArgs e)
        {
            this.LoadProductSold();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var formHome = new Home.Home();
            formHome.Show();
            this.Close();
        }

        private void btnCreateProductSold_Click(object sender, EventArgs e)
        {
            var formProductSoldCreate = new ProductSoldCreate();
            formProductSoldCreate.FormClosed += FormProductSoldCreate_FormClosed;
            formProductSoldCreate.ShowDialog();
        }

        private void FormProductSoldCreate_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.LoadProductSold();
        }

        private void dtgvProductSold_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            int Id = (int)this.dtgvProductSold.Rows[e.RowIndex].Cells["Id"].Value;

            ProductSold productSold = ProductSoldBussines.LoadProductSold().Where(x => x.Id == Id).FirstOrDefault();

            if (this.dtgvProductSold.Columns[e.ColumnIndex].Name == "Update")
            {

                var frmUpdateProduct = new ProductSoldUpdate(productSold);
                frmUpdateProduct.FormClosed += FormProductSoldCreate_FormClosed;
                frmUpdateProduct.ShowDialog();
            }
            else if (this.dtgvProductSold.Columns[e.ColumnIndex].Name == "Delete")
            {
                var frmDeleteProduct = new ProductSoldDelete(productSold);
                frmDeleteProduct.FormClosed += FormProductSoldCreate_FormClosed;
                frmDeleteProduct.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
