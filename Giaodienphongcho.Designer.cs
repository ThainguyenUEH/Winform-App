﻿namespace Giaodien
{
    partial class Giaodienphongcho
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
            txtRoomCodeLogin = new TextBox();
            label1 = new Label();
            btn_CodeEnter = new Button();
            SuspendLayout();
            // 
            // txtRoomCodeLogin
            // 
            txtRoomCodeLogin.Font = new Font("Microsoft Sans Serif", 49.8000031F, FontStyle.Regular, GraphicsUnit.Point);
            txtRoomCodeLogin.Location = new Point(214, 146);
            txtRoomCodeLogin.MaxLength = 6;
            txtRoomCodeLogin.Name = "txtRoomCodeLogin";
            txtRoomCodeLogin.Size = new Size(345, 101);
            txtRoomCodeLogin.TabIndex = 0;
            txtRoomCodeLogin.WordWrap = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(266, 102);
            label1.Name = "label1";
            label1.Size = new Size(227, 31);
            label1.TabIndex = 1;
            label1.Text = "Nhập mã số phòng";
            // 
            // btn_CodeEnter
            // 
            btn_CodeEnter.BackColor = SystemColors.Info;
            btn_CodeEnter.Font = new Font("Tahoma", 11.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            btn_CodeEnter.ForeColor = SystemColors.ActiveCaptionText;
            btn_CodeEnter.Location = new Point(523, 300);
            btn_CodeEnter.Name = "btn_CodeEnter";
            btn_CodeEnter.Size = new Size(157, 78);
            btn_CodeEnter.TabIndex = 2;
            btn_CodeEnter.Text = "Nhập mã";
            btn_CodeEnter.UseVisualStyleBackColor = false;
            btn_CodeEnter.Click += btn_CodeEnter_Click;
            // 
            // Giaodienphongcho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_CodeEnter);
            Controls.Add(label1);
            Controls.Add(txtRoomCodeLogin);
            Name = "Giaodienphongcho";
            Text = "Giaodienphongcho";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRoomCodeLogin;
        private Label label1;
        private Button btn_CodeEnter;
    }
}