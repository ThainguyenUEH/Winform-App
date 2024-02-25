using System;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Giaodien
{
    public partial class Giaodiendangki : Form
    {
        public Giaodiendangki()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtPasswordConfirm.Text;

            // Kiểm tra định dạng email hợp lệ
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ. Vui lòng nhập đúng định dạng email của trường.");
                return;
            }

            // Kiểm tra độ dài mật khẩu
            if (password.Length < 5)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 5 ký tự.");
                return;
            }

            // Kiểm tra mật khẩu và nhập lại mật khẩu có trùng khớp
            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.");
                return;
            }

            // Nếu dữ liệu hợp lệ, hiển thị thông báo đăng ký thành công và đóng form đăng ký
            if (SaveAccount(email, password))
            {
                MessageBox.Show("Đăng ký thành công!");
                this.Close(); // Đóng form đăng ký
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi lưu tài khoản.");
            }
        }

        private bool IsValidEmail(string email)
        {
            // Sử dụng biểu thức chính quy để kiểm tra định dạng email
            string emailPattern = @"^[\w-]+(?:\.[\w-]+)*@(st\.)?ueh\.edu\.vn$";
            return Regex.IsMatch(email, emailPattern);
        }

        private bool SaveAccount(string email, string password)
        {
            string connectionString = "Data Source=Account.db;Version=3;"; // Kết nối tới csdl

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Kiểm tra và tạo bảng Users nếu chưa tồn tại
                    string createTableQuery = @"CREATE TABLE IF NOT EXISTS Users (
                                                UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                                                Username TEXT NOT NULL,
                                                Password TEXT NOT NULL
                                              )";
                    using (SQLiteCommand createTableCommand = new SQLiteCommand(createTableQuery, connection))
                    {
                        createTableCommand.ExecuteNonQuery();
                    }

                    // Thêm tài khoản vào bảng Users
                    string insertQuery = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";
                    using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", email);
                        command.Parameters.AddWithValue("@Password", password);
                        command.ExecuteNonQuery();
                    }

                    // Đóng kết nối sau khi thêm dữ liệu
                    connection.Close();

                    return true;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi khi thực hiện thêm tài khoản.");
                return false;
            }
        }
    }
}
