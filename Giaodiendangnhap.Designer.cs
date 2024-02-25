namespace Giaodien
{
    partial class Giaodiendangnhap
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
            btnRegister = new Button();
            btnLogin = new Button();
            txtEmailLogin = new TextBox();
            txtPasswordLogin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRegister.Location = new Point(529, 250);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(127, 46);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLogin.Location = new Point(529, 184);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(127, 50);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtEmailLogin
            // 
            txtEmailLogin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEmailLogin.Location = new Point(61, 119);
            txtEmailLogin.Margin = new Padding(3, 2, 3, 2);
            txtEmailLogin.Name = "txtEmailLogin";
            txtEmailLogin.Size = new Size(415, 23);
            txtEmailLogin.TabIndex = 2;
            // 
            // txtPasswordLogin
            // 
            txtPasswordLogin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPasswordLogin.Location = new Point(61, 199);
            txtPasswordLogin.Margin = new Padding(3, 2, 3, 2);
            txtPasswordLogin.Name = "txtPasswordLogin";
            txtPasswordLogin.PasswordChar = '*';
            txtPasswordLogin.Size = new Size(415, 23);
            txtPasswordLogin.TabIndex = 3;
            txtPasswordLogin.TextChanged += txtPasswordLogin_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(61, 92);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 4;
            label1.Text = "Nhập tài khoản";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(61, 171);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 5;
            label2.Text = "Nhập mật khẩu";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(131, 44);
            label4.Name = "label4";
            label4.Size = new Size(187, 32);
            label4.TabIndex = 8;
            label4.Text = "ĐĂNG NHẬP";
            label4.Click += label4_Click;
            // 
            // Giaodiendangnhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(700, 338);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPasswordLogin);
            Controls.Add(txtEmailLogin);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(527, 310);
            Name = "Giaodiendangnhap";
            Text = "Giaodiendangnhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private Button btnLogin;
        private TextBox txtEmailLogin;
        private TextBox txtPasswordLogin;
        private Label label1;
        private Label label2;
        private Label label4;
    }
}