namespace SistemaGestionUserInterface.frmProduct
{
    partial class ProductDelete
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
            txtCost = new TextBox();
            txtIdUser = new TextBox();
            txtPriceSale = new TextBox();
            txtStock = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnDeleteProduct = new Button();
            txtDescription = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtCost
            // 
            txtCost.Location = new Point(201, 97);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(347, 31);
            txtCost.TabIndex = 32;
            // 
            // txtIdUser
            // 
            txtIdUser.Location = new Point(201, 257);
            txtIdUser.Name = "txtIdUser";
            txtIdUser.Size = new Size(347, 31);
            txtIdUser.TabIndex = 31;
            // 
            // txtPriceSale
            // 
            txtPriceSale.Location = new Point(201, 148);
            txtPriceSale.Name = "txtPriceSale";
            txtPriceSale.Size = new Size(347, 31);
            txtPriceSale.TabIndex = 30;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(201, 201);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(347, 31);
            txtStock.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 263);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 28;
            label5.Text = "ID Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 207);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 27;
            label4.Text = "Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 154);
            label3.Name = "label3";
            label3.Size = new Size(133, 25);
            label3.TabIndex = 26;
            label3.Text = "Precio de venta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 103);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 25;
            label2.Text = "Costo";
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(50, 327);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(161, 46);
            btnDeleteProduct.TabIndex = 24;
            btnDeleteProduct.Text = "Eliminar";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(201, 50);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(347, 31);
            txtDescription.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 56);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 22;
            label1.Text = "Descripcion";
            // 
            // ProductDelete
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCost);
            Controls.Add(txtIdUser);
            Controls.Add(txtPriceSale);
            Controls.Add(txtStock);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnDeleteProduct);
            Controls.Add(txtDescription);
            Controls.Add(label1);
            Name = "ProductDelete";
            Text = "Eliminar Producto";
            Load += ProductDelete_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCost;
        private TextBox txtIdUser;
        private TextBox txtPriceSale;
        private TextBox txtStock;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnDeleteProduct;
        private TextBox txtDescription;
        private Label label1;
    }
}