using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _0001
{
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=JJJJJ\\MAY1;Initial Catalog=LibraryOnline;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            try
            {
                conn.Open();
                string taikhoan = txtUsername.Text;
                string matkhau = txtPasswords.Text;
                string sql = "SELECT * FROM tblAcc WHERE TenTaiKhoan='@hung' AND MatKhau='@123'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@hung", taikhoan);
                cmd.Parameters.AddWithValue("@123", matkhau);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        MessageBox.Show("dang nhap thanh cong");
                        this.Hide();
                        frmHomeST frmHomeST = new frmHomeST();
                        frmHomeST.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("dang nhap khong thanh cong");
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("\"Error connecting to SQL\", \"Notification");
            }
            finally
            {
                conn.Close();
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister frmRegister = new frmRegister();
            frmRegister.ShowDialog();

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
