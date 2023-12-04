using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0001
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int error = 0;
            string username = txtNhaptaikhoan.Text;
            string password = txtNhapmatkhau.Text;

            string connectionString = "Data Source=JJJJJ\\MAY1;Initial Catalog=LibraryOnline;Integrated Security=True;TrustServerCertificate=True;";
            string checkQuery = "SELECT * FROM tblAcc WHERE TenTaiKhoan = @TenTaiKhoan";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmdCheck = new SqlCommand(checkQuery, connection))
                {
                    cmdCheck.Parameters.AddWithValue("@TenTaiKhoan", username);

                    using (SqlDataReader reader = cmdCheck.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            error++;
                            MessageBox.Show("Tên người dùng này đã tồn tại, vui lòng chọn tên khác", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                if (error == 0)
                {
                    string insertQuery = "INSERT INTO tblAcc(TenTaiKhoan, MatKhau) VALUES(@TenTaiKhoan, @MatKhau)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@TenTaiKhoan", username);
                        cmd.Parameters.AddWithValue("@MatKhau", password);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Đăng ký thành công", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        frmDangnhap frmDangnhap = new frmDangnhap();
                        frmDangnhap.ShowDialog();
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangnhap frmDangnhap = new frmDangnhap();
            frmDangnhap.ShowDialog();
        }
    }
}
