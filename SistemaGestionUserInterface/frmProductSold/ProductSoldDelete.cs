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
    public partial class ProductSoldDelete : Form
    {
        private ProductSold _productSold;
        public ProductSoldDelete()
        {
            InitializeComponent();
        }
        public ProductSoldDelete(ProductSold productSold)
        {
            InitializeComponent();
            this._productSold = productSold;
        }

        private void ProductSoldDelete_Load(object sender, EventArgs e)
        {
            txtStock.Text = this._productSold.Stock.ToString();
            txtIdProduct.Text = this._productSold.IdProduct.ToString();
            txtIdSold.Text = this._productSold.IdSold.ToString();
        }

        private void btnDeleteProductSold_Click(object sender, EventArgs e)
        {
            ProductSoldBussines.DeleteProductSold(this._productSold);
            MessageBox.Show("Producto eliminado correctamente");
        }
    }
}
