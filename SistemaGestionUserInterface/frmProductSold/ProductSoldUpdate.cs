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

            ProductSoldBussines.UpdateProductSold(this._productSold);

            MessageBox.Show("Producto modificado correctamente");
        }
    }
}
