﻿using SistemaGestionBussines;
using SistemaGestionEntities;
using SistemaGestionUserInterface.frmProductSold;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUserInterface.frmSold
{
    public partial class SoldRead : Form
    {
        public SoldRead()
        {
            InitializeComponent();
        }

        private async Task LoadSold()
        {
            HttpClient client = new HttpClient();

            List<Sold>? listSold = null;
            try
            {
                string path = @"https://localhost:7196/api/Sold";
                HttpResponseMessage response = await client.GetAsync(path);

                if (response.IsSuccessStatusCode)
                {
                    listSold = await response.Content.ReadFromJsonAsync<List<Sold>>();
                    dtgvSold.AutoGenerateColumns = false;
                    dtgvSold.DataSource = listSold;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de comunicacionn con la API");
            }
        }

        private void SoldRead_Load(object sender, EventArgs e)
        {
            this.LoadSold();
        }

        private void btnCreateSold_Click(object sender, EventArgs e)
        {
            var formSoldCreate = new SoldCreate();
            formSoldCreate.FormClosed += FormSoldCreate_FormClosed;
            formSoldCreate.ShowDialog();
        }

        private void FormSoldCreate_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.LoadSold();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var formHome = new Home.Home();
            formHome.Show();
            this.Close();
        }

        private void dtgvSold_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            int Id = (int)this.dtgvSold.Rows[e.RowIndex].Cells["Id"].Value;

            Sold sale = SoldBussines.LoadSold().Where(x => x.Id == Id).FirstOrDefault();

            if (this.dtgvSold.Columns[e.ColumnIndex].Name == "Update")
            {

                var frmUpdateSold = new SoldUpdate(sale);
                frmUpdateSold.FormClosed += FormSoldCreate_FormClosed;
                frmUpdateSold.ShowDialog();
            }
            else if (this.dtgvSold.Columns[e.ColumnIndex].Name == "Delete")
            {
                var frmDeleteSold = new SoldDelete(sale);
                frmDeleteSold.FormClosed += FormSoldCreate_FormClosed;
                frmDeleteSold.ShowDialog();
            }
        }
    }
}
