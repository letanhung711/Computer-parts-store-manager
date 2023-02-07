using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanMem_QuanLyKhoLinhKien.DTO;
using PhanMem_QuanLyKhoLinhKien.DAO;

namespace PhanMem_QuanLyKhoLinhKien
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        private void txtMaNV_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel);
            if (dlr == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            nv.Manv = txtMaNV.Text.ToUpper();
            nv.Matkhau = txtPassword.Text;
            DataTable dt = new DataTable();
            dt = NhanVienDAO.TK_MK(nv);
            int sodong = dt.Rows.Count;
            if (sodong == 1)
            {
                TrangChu menu = new TrangChu(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][6].ToString());
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác! \nVui lòng nhập lại!!!", "Thông báo");
                txtMaNV.Focus();
            }
        }

        private void DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.PasswordChar = '*';
        }
    }
}
