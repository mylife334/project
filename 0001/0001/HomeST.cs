using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0001
{
    public partial class frmHomeST : Form
    {
        public frmHomeST()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangnhap frmDangnhap = new frmDangnhap();
            frmDangnhap.ShowDialog();
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBorrowed_List frmBorrowed_List = new frmBorrowed_List();
            frmBorrowed_List.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmBorrow frmBorrow = new frmBorrow();
            frmBorrow.ShowDialog();
        }
    }
}
