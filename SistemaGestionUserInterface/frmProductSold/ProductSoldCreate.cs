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

namespace SistemaGestionUserInterface.frmProductSold
{
    public partial class ProductSoldCreate : Form
    {
        public ProductSoldCreate()
        {
            InitializeComponent();
        }

        private void btnCreateProductSold_Click(object sender, EventArgs e)
        {
            ProductSold productSold = new ProductSold();
            productSold.Stock = Convert.ToInt32(txtStock.Text);
            productSold.IdProduct = Convert.ToInt32(txtIdProduct.Text);
            productSold.IdSold = Convert.ToInt32(txtIdSold.Text);

            ProductSoldBussines.CreateProductSold(productSold);

            MessageBox.Show("Producto cargado correctamente");
        }
    }
}
