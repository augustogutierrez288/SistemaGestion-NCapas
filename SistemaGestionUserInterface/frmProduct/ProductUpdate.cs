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

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            this._product.Description = txtDescription.Text;
            this._product.Cost = Convert.ToDecimal(txtCost.Text);
            this._product.SalePrice = Convert.ToDecimal(txtPriceSale.Text);
            this._product.Stock = Convert.ToInt32(txtStock.Text);
            this._product.IdUser = Convert.ToInt32(txtIdUser.Text);

            ProductBussines.UpdateProduct(this._product);
            MessageBox.Show("Producto modificado correctamente");
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
