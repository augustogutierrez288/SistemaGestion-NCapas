namespace SistemaGestionUserInterface.frmProduct
{
    partial class ProductRead
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
            label1 = new Label();
            btnBack = new Button();
            btnCreateProduct = new Button();
            dtgbProduct = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Cost = new DataGridViewTextBoxColumn();
            SalePrice = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            IdUser = new DataGridViewTextBoxColumn();
            Update = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dtgbProduct).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(629, 31);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 0;
            label1.Text = "Productos";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(36, 26);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 1;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnCreateProduct
            // 
            btnCreateProduct.Location = new Point(1175, 26);
            btnCreateProduct.Name = "btnCreateProduct";
            btnCreateProduct.Size = new Size(112, 34);
            btnCreateProduct.TabIndex = 2;
            btnCreateProduct.Text = "Crear Producto";
            btnCreateProduct.UseVisualStyleBackColor = true;
            btnCreateProduct.Click += btnCreateProduct_Click;
            // 
            // dtgbProduct
            // 
            dtgbProduct.AllowUserToAddRows = false;
            dtgbProduct.AllowUserToDeleteRows = false;
            dtgbProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgbProduct.Columns.AddRange(new DataGridViewColumn[] { Id, Description, Cost, SalePrice, Stock, IdUser, Update, Delete });
            dtgbProduct.Location = new Point(36, 121);
            dtgbProduct.Name = "dtgbProduct";
            dtgbProduct.ReadOnly = true;
            dtgbProduct.RowHeadersWidth = 62;
            dtgbProduct.RowTemplate.Height = 33;
            dtgbProduct.Size = new Size(1251, 468);
            dtgbProduct.TabIndex = 3;
            dtgbProduct.CellContentClick += dtgbProduct_CellContentClick;
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
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Descripciones";
            Description.MinimumWidth = 8;
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Width = 150;
            // 
            // Cost
            // 
            Cost.DataPropertyName = "Cost";
            Cost.HeaderText = "Costo";
            Cost.MinimumWidth = 8;
            Cost.Name = "Cost";
            Cost.ReadOnly = true;
            Cost.Width = 150;
            // 
            // SalePrice
            // 
            SalePrice.DataPropertyName = "SalePrice";
            SalePrice.HeaderText = "Precio de Venta";
            SalePrice.MinimumWidth = 8;
            SalePrice.Name = "SalePrice";
            SalePrice.ReadOnly = true;
            SalePrice.Width = 150;
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
            // IdUser
            // 
            IdUser.DataPropertyName = "IdUser";
            IdUser.HeaderText = "ID Usuario";
            IdUser.MinimumWidth = 8;
            IdUser.Name = "IdUser";
            IdUser.ReadOnly = true;
            IdUser.Width = 150;
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
            // ProductRead
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 620);
            Controls.Add(dtgbProduct);
            Controls.Add(btnCreateProduct);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Name = "ProductRead";
            Text = "Gestor de productos";
            Load += Product_Load;
            ((System.ComponentModel.ISupportInitialize)dtgbProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBack;
        private Button btnCreateProduct;
        private DataGridView dtgbProduct;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Cost;
        private DataGridViewTextBoxColumn SalePrice;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn IdUser;
        private DataGridViewButtonColumn Update;
        private DataGridViewButtonColumn Delete;
    }
}