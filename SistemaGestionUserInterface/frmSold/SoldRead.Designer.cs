namespace SistemaGestionUserInterface.frmSold
{
    partial class SoldRead
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
            dtgvSold = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            IdUser = new DataGridViewTextBoxColumn();
            Commit = new DataGridViewTextBoxColumn();
            Update = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            btnCreateSold = new Button();
            btnBack = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvSold).BeginInit();
            SuspendLayout();
            // 
            // dtgvSold
            // 
            dtgvSold.AllowUserToAddRows = false;
            dtgvSold.AllowUserToDeleteRows = false;
            dtgvSold.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSold.Columns.AddRange(new DataGridViewColumn[] { Id, IdUser, Commit, Update, Delete });
            dtgvSold.Location = new Point(237, 121);
            dtgvSold.Name = "dtgvSold";
            dtgvSold.ReadOnly = true;
            dtgvSold.RowHeadersWidth = 62;
            dtgvSold.RowTemplate.Height = 33;
            dtgvSold.Size = new Size(815, 468);
            dtgvSold.TabIndex = 11;
            dtgvSold.CellContentClick += dtgvSold_CellContentClick;
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
            // IdUser
            // 
            IdUser.DataPropertyName = "IdUser";
            IdUser.HeaderText = "ID Usuario";
            IdUser.MinimumWidth = 8;
            IdUser.Name = "IdUser";
            IdUser.ReadOnly = true;
            IdUser.Width = 150;
            // 
            // Commit
            // 
            Commit.DataPropertyName = "Commit";
            Commit.HeaderText = "Comentario";
            Commit.MinimumWidth = 8;
            Commit.Name = "Commit";
            Commit.ReadOnly = true;
            Commit.Width = 150;
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
            // btnCreateSold
            // 
            btnCreateSold.Location = new Point(940, 35);
            btnCreateSold.Name = "btnCreateSold";
            btnCreateSold.Size = new Size(112, 34);
            btnCreateSold.TabIndex = 10;
            btnCreateSold.Text = "Cargar";
            btnCreateSold.UseVisualStyleBackColor = true;
            btnCreateSold.Click += btnCreateSold_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(237, 31);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 9;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(600, 40);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 8;
            label1.Text = "Ventas";
            // 
            // SoldRead
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 625);
            Controls.Add(dtgvSold);
            Controls.Add(btnCreateSold);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Name = "SoldRead";
            Text = "Gestor de ventas";
            Load += SoldRead_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvSold).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvSold;
        private Button btnCreateSold;
        private Button btnBack;
        private Label label1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn IdUser;
        private DataGridViewTextBoxColumn Commit;
        private DataGridViewButtonColumn Update;
        private DataGridViewButtonColumn Delete;
    }
}