namespace SistemaGestionUserInterface.frmUser
{
    partial class UserUpdate
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
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtSurname = new TextBox();
            txtUser = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnUpdateUser = new Button();
            txtName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(193, 265);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(375, 31);
            txtPassword.TabIndex = 21;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(193, 208);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(375, 31);
            txtEmail.TabIndex = 20;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(193, 96);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(375, 31);
            txtSurname.TabIndex = 19;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(193, 154);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(375, 31);
            txtUser.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 271);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 17;
            label5.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 214);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 16;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 160);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 15;
            label3.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 102);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 14;
            label2.Text = "Apellido";
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.Location = new Point(66, 339);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(152, 41);
            btnUpdateUser.TabIndex = 13;
            btnUpdateUser.Text = "Modificar";
            btnUpdateUser.UseVisualStyleBackColor = true;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(193, 34);
            txtName.Name = "txtName";
            txtName.Size = new Size(375, 31);
            txtName.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 40);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 11;
            label1.Text = "Nombre";
            // 
            // UserUpdate
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
            Controls.Add(btnUpdateUser);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "UserUpdate";
            Text = "Modificar usuario";
            Load += UserUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtSurname;
        private TextBox txtUser;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnUpdateUser;
        private TextBox txtName;
        private Label label1;
    }
}