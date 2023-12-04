using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0001
{
    public partial class frmBorrowed_List : Form
    {
        public frmBorrowed_List()
        {
            InitializeComponent();
            Showdata();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtListborrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmBorrowed_List_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string BookID = txtBookid.Text; 
            string Author = txtAuthor.Text;
            string BookName = txtbookName.Text;
            string connectionString = "Data Source=JJJJJ\\MAY1;Initial Catalog=LibraryOnline;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("them", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@BookID", @BookID));
                    cmd.Parameters.Add(new SqlParameter("@Author", @Author));
                    cmd.Parameters.Add(new SqlParameter("@BookName", @BookName));
                    try
                    {
                        conn.Open();
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        dtListborrow.DataSource = dt;
                        dtListborrow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        MessageBox.Show("add data successfully");
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Add data failed");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            Showdata();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dtListborrow.Rows[0];
            int BookID = (int)selectedRow.Cells[0].Value;
            using (SqlConnection connection = new SqlConnection("Data Source=JJJJJ\\MAY1;Initial Catalog=LibraryOnline;Integrated Security=True;TrustServerCertificate=True"))
            {
                SqlCommand cmd = new SqlCommand("Delete from book where BookID = @BookID", connection);
                cmd.Parameters.AddWithValue("@BookID", BookID);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Delete successfully", "Notification");
            Showdata();
        }
        public void Showdata()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=JJJJJ\\MAY1;Initial Catalog=LibraryOnline;Integrated Security=True;TrustServerCertificate=True"))
            {
                using (SqlCommand command = new SqlCommand("SELECT Book.BookID,Book.Author,Book.BookName", conn))
                {
                    try
                    {
                        conn.Open();
                        DataTable dt = new DataTable();
                        using (SqlDataAdapter da = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            da.Fill(dataTable);
                            dtListborrow.DataSource = dt;
                            dtListborrow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Add data failed");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomeST frmHomeST = new frmHomeST();
            frmHomeST.ShowDialog();
        }
    }
}
