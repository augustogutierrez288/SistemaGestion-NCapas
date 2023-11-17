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
    public partial class ProductDelete : Form
    {
        private Product _product;
        public ProductDelete()
        {
            InitializeComponent();
        }
        public ProductDelete(Product product)
        {
            InitializeComponent();
            this._product = product;
        }
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            ProductBussines.DeleteProduct(this._product);
            MessageBox.Show("Producto eliminado correctamente");
        }

        private void ProductDelete_Load(object sender, EventArgs e)
        {
            this.txtDescription.Text = this._product.Description;
            this.txtCost.Text = this._product.Cost.ToString();
            this.txtPriceSale.Text = this._product.SalePrice.ToString();
            this.txtStock.Text = this._product.Stock.ToString();
            this.txtIdUser.Text = this._product.IdUser.ToString();
        }
    }
}
