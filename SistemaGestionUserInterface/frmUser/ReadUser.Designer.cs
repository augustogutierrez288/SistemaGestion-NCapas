namespace SistemaGestionUserInterface.frmUser
{
    partial class ReadUser
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
            dtgvUsers = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            NameUser = new DataGridViewTextBoxColumn();
            Surname = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Update = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            btnCreateUser = new Button();
            btnBack = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvUsers).BeginInit();
            SuspendLayout();
            // 
            // dtgvUsers
            // 
            dtgvUsers.AllowUserToAddRows = false;
            dtgvUsers.AllowUserToDeleteRows = false;
            dtgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvUsers.Columns.AddRange(new DataGridViewColumn[] { Id, NameUser, Surname, Username, Email, Password, Update, Delete });
            dtgvUsers.Location = new Point(80, 143);
            dtgvUsers.Name = "dtgvUsers";
            dtgvUsers.ReadOnly = true;
            dtgvUsers.RowHeadersWidth = 62;
            dtgvUsers.RowTemplate.Height = 33;
            dtgvUsers.Size = new Size(1251, 468);
            dtgvUsers.TabIndex = 7;
            dtgvUsers.CellContentClick += dtgvUsers_CellContentClick;
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
            // NameUser
            // 
            NameUser.DataPropertyName = "NameUser";
            NameUser.HeaderText = "Nombre";
            NameUser.MinimumWidth = 8;
            NameUser.Name = "NameUser";
            NameUser.ReadOnly = true;
            NameUser.Width = 150;
            // 
            // Surname
            // 
            Surname.DataPropertyName = "Surname";
            Surname.HeaderText = "Apellido";
            Surname.MinimumWidth = 8;
            Surname.Name = "Surname";
            Surname.ReadOnly = true;
            Surname.Width = 150;
            // 
            // Username
            // 
            Username.DataPropertyName = "Username";
            Username.HeaderText = "Usuario";
            Username.MinimumWidth = 8;
            Username.Name = "Username";
            Username.ReadOnly = true;
            Username.Width = 150;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 150;
            // 
            // Password
            // 
            Password.DataPropertyName = "Password";
            Password.HeaderText = "Contraseña";
            Password.MinimumWidth = 8;
            Password.Name = "Password";
            Password.ReadOnly = true;
            Password.Width = 150;
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
            // btnCreateUser
            // 
            btnCreateUser.Location = new Point(1219, 48);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(112, 34);
            btnCreateUser.TabIndex = 6;
            btnCreateUser.Text = "Crear Producto";
            btnCreateUser.UseVisualStyleBackColor = true;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(80, 48);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 5;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(673, 53);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 4;
            label1.Text = "Usuario";
            // 
            // ReadUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1411, 658);
            Controls.Add(dtgvUsers);
            Controls.Add(btnCreateUser);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Name = "ReadUser";
            Text = "ReadUser";
            Load += ReadUser_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvUsers;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NameUser;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewButtonColumn Update;
        private DataGridViewButtonColumn Delete;
        private Button btnCreateUser;
        private Button btnBack;
        private Label label1;
    }
}