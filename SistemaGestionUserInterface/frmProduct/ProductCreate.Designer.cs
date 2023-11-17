namespace SistemaGestionUserInterface.frmProduct
{
    partial class ProductCreate
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
            txtDescription = new TextBox();
            btnCrearProducto = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtStock = new TextBox();
            txtPriceSale = new TextBox();
            txtIdUser = new TextBox();
            txtCost = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 56);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 0;
            label1.Text = "Descripcion";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(212, 50);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(347, 31);
            txtDescription.TabIndex = 1;
            // 
            // btnCrearProducto
            // 
            btnCrearProducto.Location = new Point(61, 327);
            btnCrearProducto.Name = "btnCrearProducto";
            btnCrearProducto.Size = new Size(161, 46);
            btnCrearProducto.TabIndex = 2;
            btnCrearProducto.Text = "Crear";
            btnCrearProducto.UseVisualStyleBackColor = true;
            btnCrearProducto.Click += btnCrearProducto_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 103);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 3;
            label2.Text = "Costo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 154);
            label3.Name = "label3";
            label3.Size = new Size(133, 25);
            label3.TabIndex = 4;
            label3.Text = "Precio de venta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 207);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 5;
            label4.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 263);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 6;
            label5.Text = "ID Usuario";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(212, 201);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(347, 31);
            txtStock.TabIndex = 7;
            // 
            // txtPriceSale
            // 
            txtPriceSale.Location = new Point(212, 148);
            txtPriceSale.Name = "txtPriceSale";
            txtPriceSale.Size = new Size(347, 31);
            txtPriceSale.TabIndex = 8;
            // 
            // txtIdUser
            // 
            txtIdUser.Location = new Point(212, 257);
            txtIdUser.Name = "txtIdUser";
            txtIdUser.Size = new Size(347, 31);
            txtIdUser.TabIndex = 9;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(212, 97);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(347, 31);
            txtCost.TabIndex = 10;
            // 
            // ProductCreate
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
            Controls.Add(btnCrearProducto);
            Controls.Add(txtDescription);
            Controls.Add(label1);
            Name = "ProductCreate";
            Text = "Crear Producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDescription;
        private Button btnCrearProducto;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtStock;
        private TextBox txtPriceSale;
        private TextBox txtIdUser;
        private TextBox txtCost;
    }
}