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

namespace SistemaGestionUserInterface.frmProduct
{
    public partial class ProductRead : Form
    {
        public ProductRead()
        {
            InitializeComponent();
        }

        private void ProductLoad()
        {
            List<Product> list = ProductBussines.LoadProduct();
            dtgbProduct.AutoGenerateColumns = false;
            dtgbProduct.DataSource = list;
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
            this.ProductLoad();
        }

        private void FormProductCreate_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.ProductLoad();
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
