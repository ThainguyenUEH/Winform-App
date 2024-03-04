using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giaodien
{
    public partial class Giaodienphongcho : Form
    {
        private string email;
        private string password;
        private string connectionString;

        public Giaodienphongcho(string email, string password, string connectionString)
        {
            InitializeComponent();
            this.email = email;
            this.password = password;
            this.connectionString = connectionString;
        }

        private void btn_CodeEnter_Click(object sender, EventArgs e)
        {
            string roomCode = txtRoomCodeLogin.Text;

            if (roomCode == "123456") //Này là ví dụ khi nhập code đúng sẽ cho vào phòng đợi
            {
                MessageBox.Show("Vào phòng chờ thành công!");
             // Òm, chắc là viết tiếp gì đó ở đây..kiểu như làm mấy cái liên quan tới Waiting Room
            }
            else
            {
                MessageBox.Show("Mã phòng không chính xác, vui lòng nhập lại.");
            }
        }
    }
}
