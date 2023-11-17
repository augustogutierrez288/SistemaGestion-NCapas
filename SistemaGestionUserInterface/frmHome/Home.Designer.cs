namespace SistemaGestionUserInterface.Home
{
    partial class Home
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
            label2 = new Label();
            btnUser = new Button();
            btnProduct = new Button();
            btnProductSold = new Button();
            btnSold = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(371, 40);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 0;
            label1.Text = "Inicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 86);
            label2.Name = "label2";
            label2.Size = new Size(331, 25);
            label2.TabIndex = 1;
            label2.Text = "Selecciona con que tabla deseas trabajar";
            // 
            // btnUser
            // 
            btnUser.Location = new Point(138, 238);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(248, 45);
            btnUser.TabIndex = 3;
            btnUser.Text = "Usuario";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(138, 163);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(248, 45);
            btnProduct.TabIndex = 4;
            btnProduct.Text = "Producto";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnProductSold
            // 
            btnProductSold.Location = new Point(412, 163);
            btnProductSold.Name = "btnProductSold";
            btnProductSold.Size = new Size(248, 45);
            btnProductSold.TabIndex = 5;
            btnProductSold.Text = "Producto Vendido";
            btnProductSold.UseVisualStyleBackColor = true;
            btnProductSold.Click += btnProductSold_Click;
            // 
            // btnSold
            // 
            btnSold.Location = new Point(412, 238);
            btnSold.Name = "btnSold";
            btnSold.Size = new Size(248, 45);
            btnSold.TabIndex = 6;
            btnSold.Text = "Venta";
            btnSold.UseVisualStyleBackColor = true;
            btnSold.Click += btnSold_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSold);
            Controls.Add(btnProductSold);
            Controls.Add(btnProduct);
            Controls.Add(btnUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnUser;
        private Button btnProduct;
        private Button btnProductSold;
        private Button btnSold;
    }
}