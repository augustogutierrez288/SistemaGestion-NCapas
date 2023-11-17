using SistemaGestionBussines;
using SistemaGestionEntities;
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
    public partial class ProductCreate : Form
    {
        public ProductCreate()
        {
            InitializeComponent();
        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Description = txtDescription.Text;
            product.Cost = Convert.ToDecimal(txtCost.Text);
            product.SalePrice = Convert.ToDecimal(txtPriceSale.Text);
            product.Stock = Convert.ToInt32(txtStock.Text);
            product.IdUser = Convert.ToInt32(txtIdUser.Text);

            ProductBussines.CreateProduct(product);

            MessageBox.Show("Producto cargado correctamente");
        }
    }
}
