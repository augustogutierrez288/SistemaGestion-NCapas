using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestionEntities;
using SistemaGestionBussines;

namespace SistemaGestionUserInterface.frmSold
{
    public partial class SoldCreate : Form
    {
        public SoldCreate()
        {
            InitializeComponent();
        }

        private void btnCreateSold_Click(object sender, EventArgs e)
        {
            Sold sale = new Sold();
            
            sale.Commit = txtCommit.Text;
            sale.IdUser = Convert.ToInt32(txtIDUser.Text);

            SoldBussines.CreateSold(sale);

            MessageBox.Show("Venta cargada con exito");

        }
    }
}
