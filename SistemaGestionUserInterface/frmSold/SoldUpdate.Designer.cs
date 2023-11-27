namespace SistemaGestionUserInterface.frmSold
{
    partial class SoldUpdate
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
            txtIDUser = new TextBox();
            label2 = new Label();
            btnUpdateSold = new Button();
            txtCommit = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtIDUser
            // 
            txtIDUser.Location = new Point(169, 119);
            txtIDUser.Name = "txtIDUser";
            txtIDUser.Size = new Size(150, 31);
            txtIDUser.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 125);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 8;
            label2.Text = "ID Usuario";
            // 
            // btnUpdateSold
            // 
            btnUpdateSold.Location = new Point(48, 205);
            btnUpdateSold.Name = "btnUpdateSold";
            btnUpdateSold.Size = new Size(159, 55);
            btnUpdateSold.TabIndex = 7;
            btnUpdateSold.Text = "Modificar";
            btnUpdateSold.UseVisualStyleBackColor = true;
            btnUpdateSold.Click += btnUpdateSold_Click;
            // 
            // txtCommit
            // 
            txtCommit.Location = new Point(169, 56);
            txtCommit.Name = "txtCommit";
            txtCommit.Size = new Size(403, 31);
            txtCommit.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 56);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 5;
            label1.Text = "Comentario";
            // 
            // SoldUpdate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtIDUser);
            Controls.Add(label2);
            Controls.Add(btnUpdateSold);
            Controls.Add(txtCommit);
            Controls.Add(label1);
            Name = "SoldUpdate";
            Text = "Modificar venta";
            Load += SoldUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIDUser;
        private Label label2;
        private Button btnUpdateSold;
        private TextBox txtCommit;
        private Label label1;
    }
}