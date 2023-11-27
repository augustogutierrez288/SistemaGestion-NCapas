namespace SistemaGestionUserInterface.frmUser
{
    partial class UserCreate
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
            txtName = new TextBox();
            btnCreateUser = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUser = new TextBox();
            txtSurname = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 51);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtName
            // 
            txtName.Location = new Point(162, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(375, 31);
            txtName.TabIndex = 1;
            // 
            // btnCreateUser
            // 
            btnCreateUser.Location = new Point(35, 350);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(152, 41);
            btnCreateUser.TabIndex = 2;
            btnCreateUser.Text = "Guardar";
            btnCreateUser.UseVisualStyleBackColor = true;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 113);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 3;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 171);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 4;
            label3.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 225);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 5;
            label4.Text = "Email";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 282);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 6;
            label5.Text = "Contraseña";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(162, 165);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(375, 31);
            txtUser.TabIndex = 7;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(162, 107);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(375, 31);
            txtSurname.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(162, 219);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(375, 31);
            txtEmail.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(162, 276);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(375, 31);
            txtPassword.TabIndex = 10;
            // 
            // UserCreate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtSurname);
            Controls.Add(txtUser);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCreateUser);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "UserCreate";
            Text = "Crear usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Button btnCreateUser;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUser;
        private TextBox txtSurname;
        private TextBox txtEmail;
        private TextBox txtPassword;
    }
}