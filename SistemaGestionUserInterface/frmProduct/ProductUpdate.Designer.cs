namespace SistemaGestionUserInterface.frmProduct
{
    partial class ProductUpdate
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
            btnUpdateProduct = new Button();
            txtDescription = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtCost
            // 
            txtCost.Location = new Point(190, 92);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(347, 31);
            txtCost.TabIndex = 21;
            // 
            // txtIdUser
            // 
            txtIdUser.Location = new Point(190, 252);
            txtIdUser.Name = "txtIdUser";
            txtIdUser.Size = new Size(347, 31);
            txtIdUser.TabIndex = 20;
            // 
            // txtPriceSale
            // 
            txtPriceSale.Location = new Point(190, 143);
            txtPriceSale.Name = "txtPriceSale";
            txtPriceSale.Size = new Size(347, 31);
            txtPriceSale.TabIndex = 19;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(190, 196);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(347, 31);
            txtStock.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 258);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 17;
            label5.Text = "ID Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 202);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 16;
            label4.Text = "Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 149);
            label3.Name = "label3";
            label3.Size = new Size(133, 25);
            label3.TabIndex = 15;
            label3.Text = "Precio de venta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 98);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 14;
            label2.Text = "Costo";
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Location = new Point(39, 322);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(161, 46);
            btnUpdateProduct.TabIndex = 13;
            btnUpdateProduct.Text = "Editar";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(190, 45);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(347, 31);
            txtDescription.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 51);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 11;
            label1.Text = "Descripcion";
            // 
            // ProductUpdate
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
            Controls.Add(btnUpdateProduct);
            Controls.Add(txtDescription);
            Controls.Add(label1);
            Name = "ProductUpdate";
            Text = "Editar Producto";
            Load += ProductUpdate_Load;
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
        private Button btnUpdateProduct;
        private TextBox txtDescription;
        private Label label1;
    }
}