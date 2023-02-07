using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanMem_QuanLyKhoLinhKien.GUI;

namespace PhanMem_QuanLyKhoLinhKien
{
    public partial class TrangChu : Form
    {
        private Form activeForm;
        private bool isthoat = true;
        private string Manv;
        private string Matkhau;
        private string Chucvu;

        public TrangChu()
        {
            InitializeComponent();
        }

        public TrangChu(string Manv, string Matkhau, string Chucvu)
        {
            InitializeComponent();
            this.Manv = Manv;
            this.Matkhau = Matkhau;
            this.Chucvu = Chucvu;
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(childForm);
            this.panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void TrangChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isthoat)
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            isthoat = false;
            this.Close();
            DangNhap login = new DangNhap();
            login.Show();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            if (Chucvu == "CV02")
            {
                btnQL_NV.Visible = false;
                btnThuonghieu.Visible = false;
                btnQL_LoaiLK.Visible = false;
            }
        }

        private void btnQL_LK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LinhKien());
        }

        private void btnQL_LoaiLK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQl_Loailinhkien());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLKhachHang());
        }

        private void btnThuonghieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLThuongHieu());
        }

        private void btnQL_NV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQl_Nhanvien());
        }

        private void btnNhapkho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhapkho());
        }

        private void btnXuatkho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmXuatkho());
        }
    }
}
