namespace Giaodien
{
    partial class Giaodiendangki
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtPasswordConfirm = new TextBox();
            lblEmail = new Label();
            lblPassword = new Label();
            lblPasswordConfirm = new Label();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(133, 88);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(436, 27);
            txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(133, 163);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(436, 27);
            txtPassword.TabIndex = 1;
            // 
            // txtPasswordConfirm
            // 
            txtPasswordConfirm.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPasswordConfirm.Location = new Point(133, 243);
            txtPasswordConfirm.Name = "txtPasswordConfirm";
            txtPasswordConfirm.PasswordChar = '*';
            txtPasswordConfirm.Size = new Size(436, 27);
            txtPasswordConfirm.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(133, 65);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(86, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Nhập email";
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(133, 140);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(110, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Nhập mật khẩu";
            // 
            // lblPasswordConfirm
            // 
            lblPasswordConfirm.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblPasswordConfirm.AutoSize = true;
            lblPasswordConfirm.Location = new Point(133, 219);
            lblPasswordConfirm.Name = "lblPasswordConfirm";
            lblPasswordConfirm.Size = new Size(130, 20);
            lblPasswordConfirm.TabIndex = 5;
            lblPasswordConfirm.Text = "Nhập lại mật khẩu";
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRegister.Location = new Point(635, 341);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(129, 76);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // Giaodiendangki
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(btnRegister);
            Controls.Add(lblPasswordConfirm);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(txtPasswordConfirm);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            MinimumSize = new Size(600, 398);
            Name = "Giaodiendangki";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtPasswordConfirm;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblPasswordConfirm;
        private Button btnRegister;
    }
}