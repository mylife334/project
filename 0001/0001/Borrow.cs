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
    public partial class frmBorrow : Form
    {
        string ConnectionString = "Data Source=JJJJJ\\MAY1;Initial Catalog=LibraryOnline;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();
        public frmBorrow()
        {
            InitializeComponent();
        }

        private void btnHomeborrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomeST frmHomeST = new frmHomeST();
            frmHomeST.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmBorrow_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConnectionString);

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM tblBook", conn);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                dt1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDanhsachmuon_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBorrowed_List frmBorrowed_List = new frmBorrowed_List();
            frmBorrowed_List.ShowDialog();
        }
    }
}
