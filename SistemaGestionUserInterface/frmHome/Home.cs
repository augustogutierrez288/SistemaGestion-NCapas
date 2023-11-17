using SistemaGestionUserInterface.frmProduct;
using SistemaGestionUserInterface.frmProductSold;
using SistemaGestionUserInterface.frmUser;
using SistemaGestionUserInterface.frmSold;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUserInterface.Home
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            var frmProduct = new ProductRead();
            frmProduct.Show();
            this.Close();
        }

        private void btnProductSold_Click(object sender, EventArgs e)
        {
            var frmProductSold = new ProductSold();
            frmProductSold.Show();
            this.Close();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            var frmUser = new User();
            frmUser.Show();
            this.Close();
        }

        private void btnSold_Click(object sender, EventArgs e)
        {
            var frmSold = new Sold();
            frmSold.Show();
            this.Close();
        }
    }
}
