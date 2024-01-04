namespace SistemaGestionUserInterface.frmProductSold
{
    partial class ProductSoldCreate
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
            txtIdProduct = new TextBox();
            txtIdSold = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnCreateProductSold = new Button();
            txtStock = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtIdProduct
            // 
            txtIdProduct.Location = new Point(186, 89);
            txtIdProduct.Name = "txtIdProduct";
            txtIdProduct.Size = new Size(347, 31);
            txtIdProduct.TabIndex = 21;
            // 
            // txtIdSold
            // 
            txtIdSold.Location = new Point(186, 140);
            txtIdSold.Name = "txtIdSold";
            txtIdSold.Size = new Size(347, 31);
            txtIdSold.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 146);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 15;
            label3.Text = "ID Venta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 95);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 14;
            label2.Text = "ID Producto";
            // 
            // btnCreateProductSold
            // 
            btnCreateProductSold.Location = new Point(35, 212);
            btnCreateProductSold.Name = "btnCreateProductSold";
            btnCreateProductSold.Size = new Size(161, 46);
            btnCreateProductSold.TabIndex = 13;
            btnCreateProductSold.Text = "Cargar";
            btnCreateProductSold.UseVisualStyleBackColor = true;
            btnCreateProductSold.Click += btnCreateProductSold_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(186, 42);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(347, 31);
            txtStock.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 48);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 11;
            label1.Text = "Stock";
            // 
            // ProductSoldCreate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtIdProduct);
            Controls.Add(txtIdSold);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCreateProductSold);
            Controls.Add(txtStock);
            Controls.Add(label1);
            Name = "ProductSoldCreate";
            Text = "Cargar producto vendido";
            Load += ProductSoldCreate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdProduct;
        private TextBox txtIdSold;
        private Label label3;
        private Label label2;
        private Button btnCreateProductSold;
        private TextBox txtStock;
        private Label label1;
    }
}