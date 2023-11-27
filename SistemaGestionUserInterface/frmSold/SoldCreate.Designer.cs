namespace SistemaGestionUserInterface.frmSold
{
    partial class SoldCreate
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
            txtCommit = new TextBox();
            btnCreateSold = new Button();
            label2 = new Label();
            txtIDUser = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 49);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 0;
            label1.Text = "Comentario";
            // 
            // txtCommit
            // 
            txtCommit.Location = new Point(171, 49);
            txtCommit.Name = "txtCommit";
            txtCommit.Size = new Size(403, 31);
            txtCommit.TabIndex = 1;
            // 
            // btnCreateSold
            // 
            btnCreateSold.Location = new Point(50, 198);
            btnCreateSold.Name = "btnCreateSold";
            btnCreateSold.Size = new Size(159, 55);
            btnCreateSold.TabIndex = 2;
            btnCreateSold.Text = "Cargar";
            btnCreateSold.UseVisualStyleBackColor = true;
            btnCreateSold.Click += btnCreateSold_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 118);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 3;
            label2.Text = "ID Usuario";
            // 
            // txtIDUser
            // 
            txtIDUser.Location = new Point(171, 112);
            txtIDUser.Name = "txtIDUser";
            txtIDUser.Size = new Size(150, 31);
            txtIDUser.TabIndex = 4;
            // 
            // SoldCreate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtIDUser);
            Controls.Add(label2);
            Controls.Add(btnCreateSold);
            Controls.Add(txtCommit);
            Controls.Add(label1);
            Name = "SoldCreate";
            Text = "Cargar Venta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCommit;
        private Button btnCreateSold;
        private Label label2;
        private TextBox txtIDUser;
    }
}