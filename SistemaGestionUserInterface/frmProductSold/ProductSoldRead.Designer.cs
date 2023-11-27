namespace SistemaGestionUserInterface.frmProductSold
{
    partial class ProductSoldRead
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtgvProductSold = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            IdProduct = new DataGridViewTextBoxColumn();
            IdSold = new DataGridViewTextBoxColumn();
            Update = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            btnCreateProductSold = new Button();
            btnBack = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvProductSold).BeginInit();
            SuspendLayout();
            // 
            // dtgvProductSold
            // 
            dtgvProductSold.AllowUserToAddRows = false;
            dtgvProductSold.AllowUserToDeleteRows = false;
            dtgvProductSold.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvProductSold.Columns.AddRange(new DataGridViewColumn[] { Id, Stock, IdProduct, IdSold, Update, Delete });
            dtgvProductSold.Location = new Point(204, 109);
            dtgvProductSold.Name = "dtgvProductSold";
            dtgvProductSold.ReadOnly = true;
            dtgvProductSold.RowHeadersWidth = 62;
            dtgvProductSold.RowTemplate.Height = 33;
            dtgvProductSold.Size = new Size(967, 468);
            dtgvProductSold.TabIndex = 7;
            dtgvProductSold.CellContentClick += dtgvProductSold_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ID";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 150;
            // 
            // Stock
            // 
            Stock.DataPropertyName = "Stock";
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 8;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Width = 150;
            // 
            // IdProduct
            // 
            IdProduct.DataPropertyName = "IdProduct";
            IdProduct.HeaderText = "ID Producto";
            IdProduct.MinimumWidth = 8;
            IdProduct.Name = "IdProduct";
            IdProduct.ReadOnly = true;
            IdProduct.Width = 150;
            // 
            // IdSold
            // 
            IdSold.DataPropertyName = "IdSold";
            IdSold.HeaderText = "ID Venta";
            IdSold.MinimumWidth = 8;
            IdSold.Name = "IdSold";
            IdSold.ReadOnly = true;
            IdSold.Width = 150;
            // 
            // Update
            // 
            Update.HeaderText = "Editar";
            Update.MinimumWidth = 8;
            Update.Name = "Update";
            Update.ReadOnly = true;
            Update.Text = "Editar";
            Update.UseColumnTextForButtonValue = true;
            Update.Width = 150;
            // 
            // Delete
            // 
            Delete.HeaderText = "Eliminar";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Eliminar";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 150;
            // 
            // btnCreateProductSold
            // 
            btnCreateProductSold.Location = new Point(1070, 13);
            btnCreateProductSold.Name = "btnCreateProductSold";
            btnCreateProductSold.Size = new Size(112, 34);
            btnCreateProductSold.TabIndex = 6;
            btnCreateProductSold.Text = "Cargar";
            btnCreateProductSold.UseVisualStyleBackColor = true;
            btnCreateProductSold.Click += btnCreateProductSold_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(204, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 5;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(627, 22);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 4;
            label1.Text = "Productos Vendidos";
            label1.Click += label1_Click;
            // 
            // ProductSoldRead
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 589);
            Controls.Add(dtgvProductSold);
            Controls.Add(btnCreateProductSold);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Name = "ProductSoldRead";
            Text = "Gestor de productos vendidos";
            Load += ProductSoldRead_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvProductSold).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvProductSold;
        private Button btnCreateProductSold;
        private Button btnBack;
        private Label label1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn IdProduct;
        private DataGridViewTextBoxColumn IdSold;
        private DataGridViewButtonColumn Update;
        private DataGridViewButtonColumn Delete;
    }
}