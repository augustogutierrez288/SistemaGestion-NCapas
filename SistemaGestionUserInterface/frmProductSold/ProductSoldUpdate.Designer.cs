namespace SistemaGestionUserInterface.frmProductSold
{
    partial class ProductSoldUpdate
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
            btnUpdateProductSold = new Button();
            txtStock = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtIdProduct
            // 
            txtIdProduct.Location = new Point(204, 97);
            txtIdProduct.Name = "txtIdProduct";
            txtIdProduct.Size = new Size(347, 31);
            txtIdProduct.TabIndex = 28;
            // 
            // txtIdSold
            // 
            txtIdSold.Location = new Point(204, 148);
            txtIdSold.Name = "txtIdSold";
            txtIdSold.Size = new Size(347, 31);
            txtIdSold.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 154);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 26;
            label3.Text = "ID Venta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 103);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 25;
            label2.Text = "ID Producto";
            // 
            // btnUpdateProductSold
            // 
            btnUpdateProductSold.Location = new Point(53, 220);
            btnUpdateProductSold.Name = "btnUpdateProductSold";
            btnUpdateProductSold.Size = new Size(161, 46);
            btnUpdateProductSold.TabIndex = 24;
            btnUpdateProductSold.Text = "Editar";
            btnUpdateProductSold.UseVisualStyleBackColor = true;
            btnUpdateProductSold.Click += btnUpdateProductSold_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(204, 50);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(347, 31);
            txtStock.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 56);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 22;
            label1.Text = "Stock";
            // 
            // ProductSoldUpdate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtIdProduct);
            Controls.Add(txtIdSold);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnUpdateProductSold);
            Controls.Add(txtStock);
            Controls.Add(label1);
            Name = "ProductSoldUpdate";
            Text = "Editar producto vendido ";
            Load += ProductSoldUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdProduct;
        private TextBox txtIdSold;
        private Label label3;
        private Label label2;
        private Button btnUpdateProductSold;
        private TextBox txtStock;
        private Label label1;
    }
}