using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestionBussines;
using SistemaGestionEntities;

namespace SistemaGestionUserInterface.frmSold
{
    public partial class SoldUpdate : Form
    {
        private Sold _sale;
        public SoldUpdate()
        {
            InitializeComponent();
        }

        public SoldUpdate(Sold sale)
        {
            InitializeComponent();
            this._sale = sale;
        }
        private void SoldUpdate_Load(object sender, EventArgs e)
        {
            txtCommit.Text = this._sale.Commit;
            txtIDUser.Text = this._sale.IdUser.ToString();
        }

        private void btnUpdateSold_Click(object sender, EventArgs e)
        {
            this._sale.Commit = txtCommit.Text;
            this._sale.IdUser = Convert.ToInt32(txtIDUser.Text);

            SoldBussines.UpdateSold(this._sale);
            MessageBox.Show("Venta modificada con exito");
        }
    }
}
