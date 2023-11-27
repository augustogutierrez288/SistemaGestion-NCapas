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

namespace SistemaGestionUserInterface.frmSold
{
    public partial class SoldDelete : Form
    {
        private Sold _sale;
        public SoldDelete()
        {
            InitializeComponent();
        }

        public SoldDelete(Sold sale)
        {
            InitializeComponent();
            this._sale = sale;
        }
        private void SoldDelete_Load(object sender, EventArgs e)
        {
            txtCommit.Text = this._sale.Commit;
            txtIDUser.Text = this._sale.IdUser.ToString();
        }

        private void btnDeleteSold_Click(object sender, EventArgs e)
        {
            SoldBussines.DeleteSold(this._sale);
            MessageBox.Show("Venta eliminada con exito");
        }
    }
}
